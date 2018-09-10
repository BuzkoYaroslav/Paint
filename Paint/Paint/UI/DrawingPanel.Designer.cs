namespace Paint
{
    partial class DrawingPanel
    {
        /// <summary>
        /// Обязательная переменная конструктора.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Освободить все используемые ресурсы.
        /// </summary>
        /// <param name="disposing">истинно, если управляемый ресурс должен быть удален; иначе ложно.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Код, автоматически созданный конструктором форм Windows

        /// <summary>
        /// Требуемый метод для поддержки конструктора — не изменяйте 
        /// содержимое этого метода с помощью редактора кода.
        /// </summary>
        private void InitializeComponent()
        {
            this.splitContainer1 = new System.Windows.Forms.SplitContainer();
            this.toolsFlowLayoutPanel = new System.Windows.Forms.FlowLayoutPanel();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.toolsComboBox = new System.Windows.Forms.ComboBox();
            this.groupBox2 = new System.Windows.Forms.GroupBox();
            this.borderWidthNumUpDown = new System.Windows.Forms.NumericUpDown();
            this.borderColorButton = new System.Windows.Forms.Button();
            this.label3 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.groupBox3 = new System.Windows.Forms.GroupBox();
            this.backgroundPresenceCheckBox = new System.Windows.Forms.CheckBox();
            this.backgroundColorButton = new System.Windows.Forms.Button();
            this.label4 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.groupBox4 = new System.Windows.Forms.GroupBox();
            this.performOperationButton = new System.Windows.Forms.Button();
            this.operationsOnPictureComboBox = new System.Windows.Forms.ComboBox();
            this.drawingPictureBox = new System.Windows.Forms.PictureBox();
            this.menuStrip1 = new System.Windows.Forms.MenuStrip();
            this.файлToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.createProjectButton = new System.Windows.Forms.ToolStripMenuItem();
            this.savePictureButton = new System.Windows.Forms.ToolStripMenuItem();
            this.openPictureButton = new System.Windows.Forms.ToolStripMenuItem();
            this.saveProjectButton = new System.Windows.Forms.ToolStripMenuItem();
            this.openProjectButton = new System.Windows.Forms.ToolStripMenuItem();
            this.inversionProgressStatusStrip = new System.Windows.Forms.StatusStrip();
            this.toolStripStatusLabel1 = new System.Windows.Forms.ToolStripStatusLabel();
            this.inversionProgressBar = new System.Windows.Forms.ToolStripProgressBar();
            ((System.ComponentModel.ISupportInitialize)(this.splitContainer1)).BeginInit();
            this.splitContainer1.Panel1.SuspendLayout();
            this.splitContainer1.Panel2.SuspendLayout();
            this.splitContainer1.SuspendLayout();
            this.toolsFlowLayoutPanel.SuspendLayout();
            this.groupBox1.SuspendLayout();
            this.groupBox2.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.borderWidthNumUpDown)).BeginInit();
            this.groupBox3.SuspendLayout();
            this.groupBox4.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.drawingPictureBox)).BeginInit();
            this.menuStrip1.SuspendLayout();
            this.inversionProgressStatusStrip.SuspendLayout();
            this.SuspendLayout();
            // 
            // splitContainer1
            // 
            this.splitContainer1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.splitContainer1.FixedPanel = System.Windows.Forms.FixedPanel.Panel1;
            this.splitContainer1.IsSplitterFixed = true;
            this.splitContainer1.Location = new System.Drawing.Point(0, 24);
            this.splitContainer1.Name = "splitContainer1";
            this.splitContainer1.Orientation = System.Windows.Forms.Orientation.Horizontal;
            // 
            // splitContainer1.Panel1
            // 
            this.splitContainer1.Panel1.Controls.Add(this.toolsFlowLayoutPanel);
            // 
            // splitContainer1.Panel2
            // 
            this.splitContainer1.Panel2.AutoScroll = true;
            this.splitContainer1.Panel2.Controls.Add(this.drawingPictureBox);
            this.splitContainer1.Size = new System.Drawing.Size(837, 559);
            this.splitContainer1.SplitterDistance = 99;
            this.splitContainer1.TabIndex = 0;
            // 
            // toolsFlowLayoutPanel
            // 
            this.toolsFlowLayoutPanel.Controls.Add(this.groupBox1);
            this.toolsFlowLayoutPanel.Controls.Add(this.groupBox2);
            this.toolsFlowLayoutPanel.Controls.Add(this.groupBox3);
            this.toolsFlowLayoutPanel.Controls.Add(this.groupBox4);
            this.toolsFlowLayoutPanel.Dock = System.Windows.Forms.DockStyle.Fill;
            this.toolsFlowLayoutPanel.Location = new System.Drawing.Point(0, 0);
            this.toolsFlowLayoutPanel.Name = "toolsFlowLayoutPanel";
            this.toolsFlowLayoutPanel.Size = new System.Drawing.Size(837, 99);
            this.toolsFlowLayoutPanel.TabIndex = 0;
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.toolsComboBox);
            this.groupBox1.Location = new System.Drawing.Point(3, 3);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(200, 93);
            this.groupBox1.TabIndex = 0;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Инструменты";
            // 
            // toolsComboBox
            // 
            this.toolsComboBox.Items.AddRange(new object[] {
            "Карандаш",
            "Прямая линия",
            "Елипс",
            "Прямоугольник"});
            this.toolsComboBox.Location = new System.Drawing.Point(9, 19);
            this.toolsComboBox.Name = "toolsComboBox";
            this.toolsComboBox.Size = new System.Drawing.Size(185, 21);
            this.toolsComboBox.TabIndex = 0;
            // 
            // groupBox2
            // 
            this.groupBox2.Controls.Add(this.borderWidthNumUpDown);
            this.groupBox2.Controls.Add(this.borderColorButton);
            this.groupBox2.Controls.Add(this.label3);
            this.groupBox2.Controls.Add(this.label1);
            this.groupBox2.Location = new System.Drawing.Point(209, 3);
            this.groupBox2.Name = "groupBox2";
            this.groupBox2.Size = new System.Drawing.Size(127, 93);
            this.groupBox2.TabIndex = 1;
            this.groupBox2.TabStop = false;
            this.groupBox2.Text = "Граница";
            // 
            // borderWidthNumUpDown
            // 
            this.borderWidthNumUpDown.Location = new System.Drawing.Point(78, 20);
            this.borderWidthNumUpDown.Maximum = new decimal(new int[] {
            20,
            0,
            0,
            0});
            this.borderWidthNumUpDown.Minimum = new decimal(new int[] {
            1,
            0,
            0,
            0});
            this.borderWidthNumUpDown.Name = "borderWidthNumUpDown";
            this.borderWidthNumUpDown.Size = new System.Drawing.Size(43, 20);
            this.borderWidthNumUpDown.TabIndex = 1;
            this.borderWidthNumUpDown.Value = new decimal(new int[] {
            1,
            0,
            0,
            0});
            // 
            // borderColorButton
            // 
            this.borderColorButton.Location = new System.Drawing.Point(78, 44);
            this.borderColorButton.Name = "borderColorButton";
            this.borderColorButton.Size = new System.Drawing.Size(43, 27);
            this.borderColorButton.TabIndex = 1;
            this.borderColorButton.UseVisualStyleBackColor = true;
            this.borderColorButton.Click += new System.EventHandler(this.borderColorButton_Click);
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(6, 22);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(53, 13);
            this.label3.TabIndex = 0;
            this.label3.Text = "Толщина";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(6, 44);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(32, 13);
            this.label1.TabIndex = 0;
            this.label1.Text = "Цвет";
            // 
            // groupBox3
            // 
            this.groupBox3.Controls.Add(this.backgroundPresenceCheckBox);
            this.groupBox3.Controls.Add(this.backgroundColorButton);
            this.groupBox3.Controls.Add(this.label4);
            this.groupBox3.Controls.Add(this.label2);
            this.groupBox3.Location = new System.Drawing.Point(342, 3);
            this.groupBox3.Name = "groupBox3";
            this.groupBox3.Size = new System.Drawing.Size(124, 93);
            this.groupBox3.TabIndex = 2;
            this.groupBox3.TabStop = false;
            this.groupBox3.Text = "Фон";
            // 
            // backgroundPresenceCheckBox
            // 
            this.backgroundPresenceCheckBox.AutoSize = true;
            this.backgroundPresenceCheckBox.Location = new System.Drawing.Point(103, 19);
            this.backgroundPresenceCheckBox.Name = "backgroundPresenceCheckBox";
            this.backgroundPresenceCheckBox.Size = new System.Drawing.Size(15, 14);
            this.backgroundPresenceCheckBox.TabIndex = 2;
            this.backgroundPresenceCheckBox.UseVisualStyleBackColor = true;
            // 
            // backgroundColorButton
            // 
            this.backgroundColorButton.Location = new System.Drawing.Point(77, 44);
            this.backgroundColorButton.Name = "backgroundColorButton";
            this.backgroundColorButton.Size = new System.Drawing.Size(41, 27);
            this.backgroundColorButton.TabIndex = 1;
            this.backgroundColorButton.UseVisualStyleBackColor = true;
            this.backgroundColorButton.Click += new System.EventHandler(this.backgroundColorButton_Click);
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(6, 44);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(32, 13);
            this.label4.TabIndex = 0;
            this.label4.Text = "Цвет";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(6, 19);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(79, 13);
            this.label2.TabIndex = 0;
            this.label2.Text = "Наличие фона";
            // 
            // groupBox4
            // 
            this.groupBox4.Controls.Add(this.performOperationButton);
            this.groupBox4.Controls.Add(this.operationsOnPictureComboBox);
            this.groupBox4.Location = new System.Drawing.Point(472, 3);
            this.groupBox4.Name = "groupBox4";
            this.groupBox4.Size = new System.Drawing.Size(200, 93);
            this.groupBox4.TabIndex = 3;
            this.groupBox4.TabStop = false;
            this.groupBox4.Text = "Инверсия изображения";
            // 
            // performOperationButton
            // 
            this.performOperationButton.Location = new System.Drawing.Point(6, 48);
            this.performOperationButton.Name = "performOperationButton";
            this.performOperationButton.Size = new System.Drawing.Size(188, 23);
            this.performOperationButton.TabIndex = 6;
            this.performOperationButton.Text = "Выполнить";
            this.performOperationButton.UseVisualStyleBackColor = true;
            this.performOperationButton.Click += new System.EventHandler(this.performOperationButton_Click);
            // 
            // operationsOnPictureComboBox
            // 
            this.operationsOnPictureComboBox.FormattingEnabled = true;
            this.operationsOnPictureComboBox.Items.AddRange(new object[] {
            "Инверсия цвета",
            "Поворот на 90 градусов по часовой стрелке",
            "Поворот на 90 градусов против часовой стрелки",
            "Отобразить по горизонтале",
            "Отобразить по вертикали",
            "Масштабировать"});
            this.operationsOnPictureComboBox.Location = new System.Drawing.Point(6, 19);
            this.operationsOnPictureComboBox.Name = "operationsOnPictureComboBox";
            this.operationsOnPictureComboBox.Size = new System.Drawing.Size(188, 21);
            this.operationsOnPictureComboBox.TabIndex = 5;
            // 
            // drawingPictureBox
            // 
            this.drawingPictureBox.BackColor = System.Drawing.Color.White;
            this.drawingPictureBox.Location = new System.Drawing.Point(0, 0);
            this.drawingPictureBox.Name = "drawingPictureBox";
            this.drawingPictureBox.Size = new System.Drawing.Size(1000, 200);
            this.drawingPictureBox.TabIndex = 4;
            this.drawingPictureBox.TabStop = false;
            this.drawingPictureBox.MouseDown += new System.Windows.Forms.MouseEventHandler(this.drawingPictureBox_MouseDown);
            this.drawingPictureBox.MouseMove += new System.Windows.Forms.MouseEventHandler(this.drawingPictureBox_MouseMove);
            this.drawingPictureBox.MouseUp += new System.Windows.Forms.MouseEventHandler(this.drawingPictureBox_MouseUp);
            // 
            // menuStrip1
            // 
            this.menuStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.файлToolStripMenuItem});
            this.menuStrip1.Location = new System.Drawing.Point(0, 0);
            this.menuStrip1.Name = "menuStrip1";
            this.menuStrip1.Size = new System.Drawing.Size(837, 24);
            this.menuStrip1.TabIndex = 1;
            this.menuStrip1.Text = "menuStrip1";
            // 
            // файлToolStripMenuItem
            // 
            this.файлToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.createProjectButton,
            this.savePictureButton,
            this.openPictureButton,
            this.saveProjectButton,
            this.openProjectButton});
            this.файлToolStripMenuItem.Name = "файлToolStripMenuItem";
            this.файлToolStripMenuItem.Size = new System.Drawing.Size(48, 20);
            this.файлToolStripMenuItem.Text = "Файл";
            // 
            // createProjectButton
            // 
            this.createProjectButton.Name = "createProjectButton";
            this.createProjectButton.Size = new System.Drawing.Size(173, 22);
            this.createProjectButton.Text = "Создать";
            this.createProjectButton.Click += new System.EventHandler(this.createProjectButton_Click);
            // 
            // savePictureButton
            // 
            this.savePictureButton.Name = "savePictureButton";
            this.savePictureButton.Size = new System.Drawing.Size(173, 22);
            this.savePictureButton.Text = "Сохранить";
            this.savePictureButton.Click += new System.EventHandler(this.savePictureButton_Click);
            // 
            // openPictureButton
            // 
            this.openPictureButton.Name = "openPictureButton";
            this.openPictureButton.Size = new System.Drawing.Size(173, 22);
            this.openPictureButton.Text = "Открыть";
            this.openPictureButton.Click += new System.EventHandler(this.openPictureButton_Click);
            // 
            // saveProjectButton
            // 
            this.saveProjectButton.Name = "saveProjectButton";
            this.saveProjectButton.Size = new System.Drawing.Size(173, 22);
            this.saveProjectButton.Text = "Сохранить проект";
            this.saveProjectButton.Click += new System.EventHandler(this.saveProjectButton_Click);
            // 
            // openProjectButton
            // 
            this.openProjectButton.Name = "openProjectButton";
            this.openProjectButton.Size = new System.Drawing.Size(173, 22);
            this.openProjectButton.Text = "Открыть проект";
            this.openProjectButton.Click += new System.EventHandler(this.openProjectButton_Click);
            // 
            // inversionProgressStatusStrip
            // 
            this.inversionProgressStatusStrip.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.toolStripStatusLabel1,
            this.inversionProgressBar});
            this.inversionProgressStatusStrip.Location = new System.Drawing.Point(0, 561);
            this.inversionProgressStatusStrip.Name = "inversionProgressStatusStrip";
            this.inversionProgressStatusStrip.Size = new System.Drawing.Size(837, 22);
            this.inversionProgressStatusStrip.TabIndex = 2;
            this.inversionProgressStatusStrip.Text = "statusStrip1";
            this.inversionProgressStatusStrip.Visible = false;
            // 
            // toolStripStatusLabel1
            // 
            this.toolStripStatusLabel1.Name = "toolStripStatusLabel1";
            this.toolStripStatusLabel1.Size = new System.Drawing.Size(154, 17);
            this.toolStripStatusLabel1.Text = "Прогресс инвертирования";
            // 
            // inversionProgressBar
            // 
            this.inversionProgressBar.Name = "inversionProgressBar";
            this.inversionProgressBar.Size = new System.Drawing.Size(100, 16);
            // 
            // DrawingPanel
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(837, 583);
            this.Controls.Add(this.inversionProgressStatusStrip);
            this.Controls.Add(this.splitContainer1);
            this.Controls.Add(this.menuStrip1);
            this.MainMenuStrip = this.menuStrip1;
            this.Name = "DrawingPanel";
            this.Text = "Paint";
            this.FormClosing += new System.Windows.Forms.FormClosingEventHandler(this.DrawingPanel_FormClosing);
            this.Load += new System.EventHandler(this.DrawingPanel_Load);
            this.splitContainer1.Panel1.ResumeLayout(false);
            this.splitContainer1.Panel2.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.splitContainer1)).EndInit();
            this.splitContainer1.ResumeLayout(false);
            this.toolsFlowLayoutPanel.ResumeLayout(false);
            this.groupBox1.ResumeLayout(false);
            this.groupBox2.ResumeLayout(false);
            this.groupBox2.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.borderWidthNumUpDown)).EndInit();
            this.groupBox3.ResumeLayout(false);
            this.groupBox3.PerformLayout();
            this.groupBox4.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.drawingPictureBox)).EndInit();
            this.menuStrip1.ResumeLayout(false);
            this.menuStrip1.PerformLayout();
            this.inversionProgressStatusStrip.ResumeLayout(false);
            this.inversionProgressStatusStrip.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.SplitContainer splitContainer1;
        private System.Windows.Forms.FlowLayoutPanel toolsFlowLayoutPanel;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.ComboBox toolsComboBox;
        private System.Windows.Forms.GroupBox groupBox2;
        private System.Windows.Forms.NumericUpDown borderWidthNumUpDown;
        private System.Windows.Forms.Button borderColorButton;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.GroupBox groupBox3;
        private System.Windows.Forms.CheckBox backgroundPresenceCheckBox;
        private System.Windows.Forms.Button backgroundColorButton;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.GroupBox groupBox4;
        private System.Windows.Forms.Button performOperationButton;
        private System.Windows.Forms.ComboBox operationsOnPictureComboBox;
        private System.Windows.Forms.PictureBox drawingPictureBox;
        private System.Windows.Forms.MenuStrip menuStrip1;
        private System.Windows.Forms.ToolStripMenuItem файлToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem savePictureButton;
        private System.Windows.Forms.ToolStripMenuItem openPictureButton;
        private System.Windows.Forms.StatusStrip inversionProgressStatusStrip;
        private System.Windows.Forms.ToolStripStatusLabel toolStripStatusLabel1;
        private System.Windows.Forms.ToolStripProgressBar inversionProgressBar;
        private System.Windows.Forms.ToolStripMenuItem createProjectButton;
        private System.Windows.Forms.ToolStripMenuItem saveProjectButton;
        private System.Windows.Forms.ToolStripMenuItem openProjectButton;
    }
}

