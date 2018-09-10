namespace Paint
{
    partial class CreateProject
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
            this.tableLayoutPanel1 = new System.Windows.Forms.TableLayoutPanel();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.widthNumUpDown = new System.Windows.Forms.NumericUpDown();
            this.heightNumUpDown = new System.Windows.Forms.NumericUpDown();
            this.createButton = new System.Windows.Forms.Button();
            this.label4 = new System.Windows.Forms.Label();
            this.backgroundTransparancyCheckBox = new System.Windows.Forms.CheckBox();
            this.tableLayoutPanel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.widthNumUpDown)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.heightNumUpDown)).BeginInit();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(8, 9);
            this.label1.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(301, 20);
            this.label1.TabIndex = 0;
            this.label1.Text = "Введите размеры области рисования:\r\n";
            // 
            // tableLayoutPanel1
            // 
            this.tableLayoutPanel1.ColumnCount = 2;
            this.tableLayoutPanel1.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 50F));
            this.tableLayoutPanel1.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 50F));
            this.tableLayoutPanel1.Controls.Add(this.label2, 0, 0);
            this.tableLayoutPanel1.Controls.Add(this.label3, 0, 1);
            this.tableLayoutPanel1.Controls.Add(this.widthNumUpDown, 1, 0);
            this.tableLayoutPanel1.Controls.Add(this.heightNumUpDown, 1, 1);
            this.tableLayoutPanel1.Controls.Add(this.label4, 0, 2);
            this.tableLayoutPanel1.Controls.Add(this.backgroundTransparancyCheckBox, 1, 2);
            this.tableLayoutPanel1.Location = new System.Drawing.Point(12, 32);
            this.tableLayoutPanel1.Name = "tableLayoutPanel1";
            this.tableLayoutPanel1.RowCount = 3;
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 50F));
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 50F));
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 50F));
            this.tableLayoutPanel1.Size = new System.Drawing.Size(355, 160);
            this.tableLayoutPanel1.TabIndex = 1;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(3, 0);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(71, 20);
            this.label2.TabIndex = 0;
            this.label2.Text = "Ширина:";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(3, 55);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(70, 20);
            this.label3.TabIndex = 0;
            this.label3.Text = "Высота:";
            // 
            // widthNumUpDown
            // 
            this.widthNumUpDown.Location = new System.Drawing.Point(180, 3);
            this.widthNumUpDown.Maximum = new decimal(new int[] {
            2000,
            0,
            0,
            0});
            this.widthNumUpDown.Minimum = new decimal(new int[] {
            100,
            0,
            0,
            0});
            this.widthNumUpDown.Name = "widthNumUpDown";
            this.widthNumUpDown.Size = new System.Drawing.Size(172, 26);
            this.widthNumUpDown.TabIndex = 1;
            this.widthNumUpDown.Value = new decimal(new int[] {
            100,
            0,
            0,
            0});
            // 
            // heightNumUpDown
            // 
            this.heightNumUpDown.Location = new System.Drawing.Point(180, 58);
            this.heightNumUpDown.Maximum = new decimal(new int[] {
            2000,
            0,
            0,
            0});
            this.heightNumUpDown.Minimum = new decimal(new int[] {
            100,
            0,
            0,
            0});
            this.heightNumUpDown.Name = "heightNumUpDown";
            this.heightNumUpDown.Size = new System.Drawing.Size(172, 26);
            this.heightNumUpDown.TabIndex = 1;
            this.heightNumUpDown.Value = new decimal(new int[] {
            100,
            0,
            0,
            0});
            // 
            // createButton
            // 
            this.createButton.Location = new System.Drawing.Point(12, 198);
            this.createButton.Name = "createButton";
            this.createButton.Size = new System.Drawing.Size(355, 34);
            this.createButton.TabIndex = 2;
            this.createButton.Text = "Создать проект";
            this.createButton.UseVisualStyleBackColor = true;
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(3, 110);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(144, 20);
            this.label4.TabIndex = 0;
            this.label4.Text = "Прозрачный фон:";
            // 
            // backgroundTransparancyCheckBox
            // 
            this.backgroundTransparancyCheckBox.AutoSize = true;
            this.backgroundTransparancyCheckBox.Location = new System.Drawing.Point(180, 113);
            this.backgroundTransparancyCheckBox.Name = "backgroundTransparancyCheckBox";
            this.backgroundTransparancyCheckBox.Size = new System.Drawing.Size(15, 14);
            this.backgroundTransparancyCheckBox.TabIndex = 2;
            this.backgroundTransparancyCheckBox.UseVisualStyleBackColor = true;
            // 
            // CreateProject
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(379, 244);
            this.Controls.Add(this.createButton);
            this.Controls.Add(this.tableLayoutPanel1);
            this.Controls.Add(this.label1);
            this.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedToolWindow;
            this.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.Name = "CreateProject";
            this.Text = "Создание проекта";
            this.tableLayoutPanel1.ResumeLayout(false);
            this.tableLayoutPanel1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.widthNumUpDown)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.heightNumUpDown)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TableLayoutPanel tableLayoutPanel1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        internal System.Windows.Forms.NumericUpDown widthNumUpDown;
        internal System.Windows.Forms.NumericUpDown heightNumUpDown;
        internal System.Windows.Forms.Button createButton;
        private System.Windows.Forms.Label label4;
        public System.Windows.Forms.CheckBox backgroundTransparancyCheckBox;
    }
}