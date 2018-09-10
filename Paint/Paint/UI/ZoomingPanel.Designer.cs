namespace Paint
{
    partial class ZoomingPanel
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.tableLayoutPanel1 = new System.Windows.Forms.TableLayoutPanel();
            this.horizontalNumUpDown = new System.Windows.Forms.NumericUpDown();
            this.verticalNumUpDown = new System.Windows.Forms.NumericUpDown();
            this.resizeButton = new System.Windows.Forms.Button();
            this.tableLayoutPanel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.horizontalNumUpDown)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.verticalNumUpDown)).BeginInit();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.Location = new System.Drawing.Point(13, 9);
            this.label1.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(290, 46);
            this.label1.TabIndex = 0;
            this.label1.Text = "Введите степень масштабирования в процентах:\r\n";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(4, 50);
            this.label2.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(115, 20);
            this.label2.TabIndex = 1;
            this.label2.Text = "По вертикали";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(4, 0);
            this.label3.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(131, 20);
            this.label3.TabIndex = 1;
            this.label3.Text = "По горизонтали";
            // 
            // tableLayoutPanel1
            // 
            this.tableLayoutPanel1.ColumnCount = 2;
            this.tableLayoutPanel1.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 50F));
            this.tableLayoutPanel1.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 50F));
            this.tableLayoutPanel1.Controls.Add(this.label3, 0, 0);
            this.tableLayoutPanel1.Controls.Add(this.label2, 0, 1);
            this.tableLayoutPanel1.Controls.Add(this.horizontalNumUpDown, 1, 0);
            this.tableLayoutPanel1.Controls.Add(this.verticalNumUpDown, 1, 1);
            this.tableLayoutPanel1.Location = new System.Drawing.Point(17, 58);
            this.tableLayoutPanel1.Name = "tableLayoutPanel1";
            this.tableLayoutPanel1.RowCount = 2;
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 50F));
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 50F));
            this.tableLayoutPanel1.Size = new System.Drawing.Size(286, 100);
            this.tableLayoutPanel1.TabIndex = 2;
            // 
            // horizontalNumUpDown
            // 
            this.horizontalNumUpDown.Location = new System.Drawing.Point(146, 3);
            this.horizontalNumUpDown.Maximum = new decimal(new int[] {
            1000,
            0,
            0,
            0});
            this.horizontalNumUpDown.Minimum = new decimal(new int[] {
            25,
            0,
            0,
            0});
            this.horizontalNumUpDown.Name = "horizontalNumUpDown";
            this.horizontalNumUpDown.Size = new System.Drawing.Size(137, 26);
            this.horizontalNumUpDown.TabIndex = 2;
            this.horizontalNumUpDown.Value = new decimal(new int[] {
            100,
            0,
            0,
            0});
            // 
            // verticalNumUpDown
            // 
            this.verticalNumUpDown.Location = new System.Drawing.Point(146, 53);
            this.verticalNumUpDown.Maximum = new decimal(new int[] {
            1000,
            0,
            0,
            0});
            this.verticalNumUpDown.Minimum = new decimal(new int[] {
            25,
            0,
            0,
            0});
            this.verticalNumUpDown.Name = "verticalNumUpDown";
            this.verticalNumUpDown.Size = new System.Drawing.Size(137, 26);
            this.verticalNumUpDown.TabIndex = 2;
            this.verticalNumUpDown.Value = new decimal(new int[] {
            100,
            0,
            0,
            0});
            // 
            // resizeButton
            // 
            this.resizeButton.Location = new System.Drawing.Point(17, 164);
            this.resizeButton.Name = "resizeButton";
            this.resizeButton.Size = new System.Drawing.Size(287, 38);
            this.resizeButton.TabIndex = 3;
            this.resizeButton.Text = "Масштабировать";
            this.resizeButton.UseVisualStyleBackColor = true;
            // 
            // ZoomingPanel
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(316, 214);
            this.Controls.Add(this.resizeButton);
            this.Controls.Add(this.tableLayoutPanel1);
            this.Controls.Add(this.label1);
            this.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedToolWindow;
            this.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.Name = "ZoomingPanel";
            this.Text = "Масштабирование";
            this.tableLayoutPanel1.ResumeLayout(false);
            this.tableLayoutPanel1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.horizontalNumUpDown)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.verticalNumUpDown)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.TableLayoutPanel tableLayoutPanel1;
        internal System.Windows.Forms.NumericUpDown horizontalNumUpDown;
        internal System.Windows.Forms.NumericUpDown verticalNumUpDown;
        internal System.Windows.Forms.Button resizeButton;
    }
}