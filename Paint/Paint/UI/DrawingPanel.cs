using System;
using System.Drawing;
using System.Windows.Forms;
using Paint.Geometric_framework;

namespace Paint
{
    public partial class DrawingPanel : Form, IImageDisplayable, IProgress
    {
        private bool isSaved = true;
        private bool isClosed = false;

        private Canvas currentCanvas;

        public DrawingPanel()
        {
            InitializeComponent();
            
            currentCanvas = new Canvas(new Size(Constants.DrawingPanel.initialWidth, 
                Constants.DrawingPanel.initialHeight));
        }

        #region Color picking

        private void borderColorButton_Click(object sender, EventArgs e)
        {
            var color = GetColor();

            borderColorButton.BackColor = color;
        }

        private void backgroundColorButton_Click(object sender, EventArgs e)
        {
            var color = GetColor();

            backgroundColorButton.BackColor = color;
        }

        private Color GetColor()
        {
            var colorDialog = new ColorDialog();

            if (colorDialog.ShowDialog() == DialogResult.OK)
                return colorDialog.Color;
            else
                return Color.Black;
        }

        #endregion

        #region Form Loading

        private void DrawingPanel_Load(object sender, EventArgs e)
        {
            currentCanvas.Display = this;
        }

        #endregion

        #region Form closing

        private void DrawingPanel_FormClosing(object sender, FormClosingEventArgs e)
        {
            isClosed = true;

            if (!isSaved &&
                SaveProjectQuestionMessage() == DialogResult.Yes)
                SaveCurrentCanvasAsPicture();
        }

        #endregion

        #region Mouse Events

        private void drawingPictureBox_MouseDown(object sender, MouseEventArgs e)
        {
            if (toolsComboBox.SelectedIndex == -1)
            {
                InformationMessage(Constants.DrawingPanel.chooseInstrumentForDrawingInformationMessage);
                return;
            }

            isSaved = false;

            currentCanvas.StartFigure((CanvasTool)toolsComboBox.SelectedIndex,
                borderColorButton.BackColor, (float)borderWidthNumUpDown.Value,
                backgroundColorButton.BackColor, backgroundPresenceCheckBox.Checked, e.Location);
        }

        private void drawingPictureBox_MouseUp(object sender, MouseEventArgs e)
        {
            currentCanvas.FinishFigure();
        }

        private void drawingPictureBox_MouseMove(object sender, MouseEventArgs e)
        {
            currentCanvas.ContinueFigure(e.Location);
        }

        #endregion

        #region Operations with drawing

        private void performOperationButton_Click(object sender, EventArgs e)
        {
            switch (operationsOnPictureComboBox.SelectedIndex)
            {
                case 0:
                    currentCanvas.InverseColor(this);
                    isSaved = false;

                    break;
                case 1:
                    currentCanvas.RotateFlip(RotateFlipType.Rotate90FlipNone, this);
                    isSaved = false;

                    break;
                case 2:
                    currentCanvas.RotateFlip(RotateFlipType.Rotate270FlipNone, this);
                    isSaved = false;

                    break;
                case 3:
                    currentCanvas.RotateFlip(RotateFlipType.RotateNoneFlipX, this);
                    isSaved = false;

                    break;
                case 4:
                    currentCanvas.RotateFlip(RotateFlipType.RotateNoneFlipY, this);
                    isSaved = false;

                    break;
                case 5:
                    var zoomingForm = new ZoomingPanel();

                    zoomingForm.resizeButton.Click += (s, earg) =>
                    {
                        currentCanvas.Scale((float)(zoomingForm.horizontalNumUpDown.Value / 100),
                            (float)(zoomingForm.verticalNumUpDown.Value / 100), this);
                        isSaved = false;

                        zoomingForm.Close();
                    };

                    zoomingForm.Show();

                    break;
            }
        }

        #endregion

        #region IImageDisplayable

        public void DisplayImage(Image image)
        {
            Invoke(new Action(() => { drawingPictureBox.Image = image; }));
        }

        public void ResizeDisplay(Size size)
        {
            Invoke(new Action(() => { drawingPictureBox.Size = size; }));
        }

        #endregion

        #region IProgress

        public void SetTaskNumber(int number)
        {
            if (isClosed) return;

            Invoke(new Action(() => { inversionProgressBar.Maximum = number; }));
        }

        public void TaskCompleted(int count)
        {
            if (isClosed) return;

            Invoke(new Action(() => { inversionProgressBar.Value += count; }));
        }

        public void CompletionIsStarted()
        {
            if (isClosed) return;

            Invoke(new Action(() =>
            {
                inversionProgressStatusStrip.Visible = true;
                drawingPictureBox.Enabled = false;
                toolsFlowLayoutPanel.Enabled = false;
                menuStrip1.Enabled = false;

                inversionProgressBar.Value = 0;
            }));
        }

        public void CompletionIsFinished()
        {
            if (isClosed) return;

            Invoke(new Action(() =>
            {
                inversionProgressStatusStrip.Visible = false;
                drawingPictureBox.Enabled = true;
                toolsFlowLayoutPanel.Enabled = true;
                menuStrip1.Enabled = true;
            }));
        }

        #endregion

        #region Creating project

        private void createProjectButton_Click(object sender, EventArgs e)
        {
            var createForm = new CreateProject();

            createForm.createButton.Click += (s, arg) =>
            {
                createForm.Close();

                if (currentCanvas != null &&
                    SaveProjectQuestionMessage() == DialogResult.Yes)
                    SaveCurrentCanvasAsPicture();

                currentCanvas = new Canvas(new Size(Convert.ToInt32(createForm.widthNumUpDown.Value), 
                    Convert.ToInt32(createForm.heightNumUpDown.Value)), createForm.backgroundTransparancyCheckBox.Checked);
                currentCanvas.Display = this;

                isSaved = true;
            };

            createForm.Show();
        }

        #endregion

        #region Saving/opening project

        private void savePictureButton_Click(object sender, EventArgs e)
        {
            SaveCurrentCanvasAsPicture();
        }

        private void openPictureButton_Click(object sender, EventArgs e)
        {
            if (!isSaved &&
                SaveProjectQuestionMessage() == DialogResult.Yes)
                SaveCurrentCanvasAsPicture();

            var fileName = PickFileToOpen(Constants.DrawingPanel.pictureFileDialogFilter);

            if (fileName != null)
            {
                currentCanvas = DrawingProjectManager.OpenCanvasPicture(fileName);
                currentCanvas.Display = this;

                isSaved = true;
            }
        }

        private void saveProjectButton_Click(object sender, EventArgs e)
        {
            isSaved = true;

            var fileName = PickFileToSave(Constants.DrawingPanel.projectFileDialogFilter);

            if (fileName != null)
                DrawingProjectManager.SaveCanvasProject(currentCanvas, fileName);

        }

        private void openProjectButton_Click(object sender, EventArgs e)
        {
            if (!isSaved &&
                SaveProjectQuestionMessage() == DialogResult.Yes)
                SaveCurrentCanvasAsPicture();

            var fileName = PickFileToOpen(Constants.DrawingPanel.projectFileDialogFilter);

            if (fileName != null)
            {
                currentCanvas = DrawingProjectManager.LoadCanvasProject(fileName);
                currentCanvas.Display = this;

                isSaved = true;
            }
        }

        private void SaveCurrentCanvasAsPicture()
        {
            var fileName = PickFileToSave(Constants.DrawingPanel.pictureFileDialogFilter);

            if (fileName != null)
            {
                DrawingProjectManager.SaveCanvasPicture(currentCanvas, fileName);

                isSaved = true;
            }
        }

        #endregion

        #region Messages

        private DialogResult InformationMessage(string message)
        {
            return MessageBox.Show(message, Constants.DrawingPanel.informationMessageTitle, 
                MessageBoxButtons.OK, MessageBoxIcon.Information);
        }
        private DialogResult SaveProjectQuestionMessage()
        {
            return MessageBox.Show(Constants.DrawingPanel.saveFileMessageBoxText, 
                Constants.DrawingPanel.saveFileMessageBoxTitle,
                MessageBoxButtons.YesNo, MessageBoxIcon.Exclamation);
        }

        #endregion

        #region File Dialogs 

        private string PickFileToOpen(string filter)
        {
            var openFileDialog = new OpenFileDialog();

            openFileDialog.Title = Constants.DrawingPanel.openFileDialogTitle;
            openFileDialog.Filter = filter;

            if (openFileDialog.ShowDialog() == DialogResult.OK)
                return openFileDialog.FileName;
            else
                return null;
        }

        private string PickFileToSave(string filter)
        {
            var saveFileDialog = new SaveFileDialog();

            saveFileDialog.Title = Constants.DrawingPanel.saveFileDialogTitle
            saveFileDialog.Filter = filter;

            if (saveFileDialog.ShowDialog() == DialogResult.OK)
                return saveFileDialog.FileName;
            else
                return null;
        }

        #endregion

    }
}
