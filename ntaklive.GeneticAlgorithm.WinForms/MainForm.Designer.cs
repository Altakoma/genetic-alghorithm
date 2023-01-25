namespace ntaklive.GeneticAlgorithm.WinForms
{
    partial class MainForm
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
            this.startGAButton = new System.Windows.Forms.Button();
            this.resultLabel = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.worksheetComboBox = new System.Windows.Forms.ComboBox();
            this.worksheetLabel = new System.Windows.Forms.Label();
            this.matrixSizeTextBox = new System.Windows.Forms.TextBox();
            this.matrixSizeLabel = new System.Windows.Forms.Label();
            this.label2X = new System.Windows.Forms.Label();
            this.matrixPointXValueTextBox = new System.Windows.Forms.TextBox();
            this.matrixPointYLabel = new System.Windows.Forms.Label();
            this.matrixPointYValueTextBox = new System.Windows.Forms.TextBox();
            this.matrixPointLabel = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.populationMaxValueTextBox = new System.Windows.Forms.TextBox();
            this.label4 = new System.Windows.Forms.Label();
            this.populationMinValueTextBox = new System.Windows.Forms.TextBox();
            this.label5 = new System.Windows.Forms.Label();
            this.generationsNumberTextBox = new System.Windows.Forms.TextBox();
            this.resultValueRichTextBox = new System.Windows.Forms.RichTextBox();
            this.SuspendLayout();
            // 
            // startGAButton
            // 
            this.startGAButton.Location = new System.Drawing.Point(12, 12);
            this.startGAButton.Name = "startGAButton";
            this.startGAButton.Size = new System.Drawing.Size(75, 23);
            this.startGAButton.TabIndex = 0;
            this.startGAButton.Text = "Искать";
            this.startGAButton.UseVisualStyleBackColor = true;
            this.startGAButton.Click += new System.EventHandler(this.startGAButton_Click);
            // 
            // resultLabel
            // 
            this.resultLabel.Location = new System.Drawing.Point(12, 189);
            this.resultLabel.Name = "resultLabel";
            this.resultLabel.Size = new System.Drawing.Size(75, 16);
            this.resultLabel.TabIndex = 1;
            this.resultLabel.Text = "Лог:";
            // 
            // label1
            // 
            this.label1.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.label1.Location = new System.Drawing.Point(15, 177);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(392, 2);
            this.label1.TabIndex = 2;
            // 
            // worksheetComboBox
            // 
            this.worksheetComboBox.FormattingEnabled = true;
            this.worksheetComboBox.Location = new System.Drawing.Point(93, 41);
            this.worksheetComboBox.Name = "worksheetComboBox";
            this.worksheetComboBox.Size = new System.Drawing.Size(314, 21);
            this.worksheetComboBox.TabIndex = 4;
            this.worksheetComboBox.DropDown += new System.EventHandler(this.worksheetDropDown_DropDown);
            this.worksheetComboBox.SelectedIndexChanged += new System.EventHandler(this.worksheetComboBox_SelectedIndexChanged);
            // 
            // worksheetLabel
            // 
            this.worksheetLabel.Location = new System.Drawing.Point(12, 39);
            this.worksheetLabel.Name = "worksheetLabel";
            this.worksheetLabel.Size = new System.Drawing.Size(60, 23);
            this.worksheetLabel.TabIndex = 5;
            this.worksheetLabel.Text = "Лист:";
            this.worksheetLabel.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // matrixSizeTextBox
            // 
            this.matrixSizeTextBox.Location = new System.Drawing.Point(93, 68);
            this.matrixSizeTextBox.Name = "matrixSizeTextBox";
            this.matrixSizeTextBox.Size = new System.Drawing.Size(314, 20);
            this.matrixSizeTextBox.TabIndex = 6;
            this.matrixSizeTextBox.TextChanged += new System.EventHandler(this.matrixSizeTextBox_TextChanged);
            // 
            // matrixSizeLabel
            // 
            this.matrixSizeLabel.Location = new System.Drawing.Point(12, 68);
            this.matrixSizeLabel.Name = "matrixSizeLabel";
            this.matrixSizeLabel.Size = new System.Drawing.Size(60, 23);
            this.matrixSizeLabel.TabIndex = 7;
            this.matrixSizeLabel.Text = "Размер:";
            this.matrixSizeLabel.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // label2X
            // 
            this.label2X.Location = new System.Drawing.Point(145, 92);
            this.label2X.Name = "label2X";
            this.label2X.Size = new System.Drawing.Size(39, 20);
            this.label2X.TabIndex = 9;
            this.label2X.Text = "X:";
            this.label2X.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // matrixPointXValueTextBox
            // 
            this.matrixPointXValueTextBox.Location = new System.Drawing.Point(190, 94);
            this.matrixPointXValueTextBox.Name = "matrixPointXValueTextBox";
            this.matrixPointXValueTextBox.Size = new System.Drawing.Size(83, 20);
            this.matrixPointXValueTextBox.TabIndex = 8;
            this.matrixPointXValueTextBox.TextChanged += new System.EventHandler(this.matrixPointXValueTextBox_TextChanged);
            // 
            // matrixPointYLabel
            // 
            this.matrixPointYLabel.Location = new System.Drawing.Point(279, 92);
            this.matrixPointYLabel.Name = "matrixPointYLabel";
            this.matrixPointYLabel.Size = new System.Drawing.Size(39, 20);
            this.matrixPointYLabel.TabIndex = 11;
            this.matrixPointYLabel.Text = "Y:";
            this.matrixPointYLabel.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // matrixPointYValueTextBox
            // 
            this.matrixPointYValueTextBox.Location = new System.Drawing.Point(324, 94);
            this.matrixPointYValueTextBox.Name = "matrixPointYValueTextBox";
            this.matrixPointYValueTextBox.Size = new System.Drawing.Size(83, 20);
            this.matrixPointYValueTextBox.TabIndex = 10;
            this.matrixPointYValueTextBox.TextChanged += new System.EventHandler(this.matrixPointYValueTextBox_TextChanged);
            // 
            // matrixPointLabel
            // 
            this.matrixPointLabel.Location = new System.Drawing.Point(12, 93);
            this.matrixPointLabel.Name = "matrixPointLabel";
            this.matrixPointLabel.Size = new System.Drawing.Size(127, 20);
            this.matrixPointLabel.TabIndex = 12;
            this.matrixPointLabel.Text = "Координаты матрицы:";
            this.matrixPointLabel.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // label2
            // 
            this.label2.Location = new System.Drawing.Point(12, 119);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(127, 20);
            this.label2.TabIndex = 17;
            this.label2.Text = "Размер популяции:";
            this.label2.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // label3
            // 
            this.label3.Location = new System.Drawing.Point(279, 118);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(39, 20);
            this.label3.TabIndex = 16;
            this.label3.Text = "Макс:";
            this.label3.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // populationMaxValueTextBox
            // 
            this.populationMaxValueTextBox.Location = new System.Drawing.Point(324, 120);
            this.populationMaxValueTextBox.Name = "populationMaxValueTextBox";
            this.populationMaxValueTextBox.Size = new System.Drawing.Size(83, 20);
            this.populationMaxValueTextBox.TabIndex = 15;
            this.populationMaxValueTextBox.TextChanged += new System.EventHandler(this.populationMaxValueTextBox_TextChanged);
            // 
            // label4
            // 
            this.label4.Location = new System.Drawing.Point(145, 118);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(39, 20);
            this.label4.TabIndex = 14;
            this.label4.Text = "Мин:";
            this.label4.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // populationMinValueTextBox
            // 
            this.populationMinValueTextBox.Location = new System.Drawing.Point(190, 120);
            this.populationMinValueTextBox.Name = "populationMinValueTextBox";
            this.populationMinValueTextBox.Size = new System.Drawing.Size(83, 20);
            this.populationMinValueTextBox.TabIndex = 13;
            this.populationMinValueTextBox.TextChanged += new System.EventHandler(this.populationMinValueTextBox_TextChanged);
            // 
            // label5
            // 
            this.label5.Location = new System.Drawing.Point(12, 146);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(75, 23);
            this.label5.TabIndex = 19;
            this.label5.Text = "Поколения:";
            this.label5.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // generationsNumberTextBox
            // 
            this.generationsNumberTextBox.Location = new System.Drawing.Point(93, 146);
            this.generationsNumberTextBox.Name = "generationsNumberTextBox";
            this.generationsNumberTextBox.Size = new System.Drawing.Size(314, 20);
            this.generationsNumberTextBox.TabIndex = 18;
            this.generationsNumberTextBox.TextChanged += new System.EventHandler(this.generationsNumberTextBox_TextChanged);
            // 
            // resultValueRichTextBox
            // 
            this.resultValueRichTextBox.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.resultValueRichTextBox.Location = new System.Drawing.Point(15, 208);
            this.resultValueRichTextBox.Name = "resultValueRichTextBox";
            this.resultValueRichTextBox.ReadOnly = true;
            this.resultValueRichTextBox.Size = new System.Drawing.Size(392, 250);
            this.resultValueRichTextBox.TabIndex = 20;
            this.resultValueRichTextBox.Text = "";
            // 
            // MainForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(421, 470);
            this.Controls.Add(this.resultValueRichTextBox);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.generationsNumberTextBox);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.populationMaxValueTextBox);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.populationMinValueTextBox);
            this.Controls.Add(this.matrixPointLabel);
            this.Controls.Add(this.matrixPointYLabel);
            this.Controls.Add(this.matrixPointYValueTextBox);
            this.Controls.Add(this.label2X);
            this.Controls.Add(this.matrixPointXValueTextBox);
            this.Controls.Add(this.matrixSizeLabel);
            this.Controls.Add(this.matrixSizeTextBox);
            this.Controls.Add(this.worksheetLabel);
            this.Controls.Add(this.worksheetComboBox);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.resultLabel);
            this.Controls.Add(this.startGAButton);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.MaximizeBox = false;
            this.Name = "MainForm";
            this.SizeGripStyle = System.Windows.Forms.SizeGripStyle.Hide;
            this.Text = "Genetic Algorithm";
            this.FormClosed += new System.Windows.Forms.FormClosedEventHandler(this.MainForm_FormClosed);
            this.Load += new System.EventHandler(this.MainForm_Load);
            this.ResumeLayout(false);
            this.PerformLayout();
        }

        private System.Windows.Forms.RichTextBox resultValueRichTextBox;

        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.TextBox populationMaxValueTextBox;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.TextBox populationMinValueTextBox;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.TextBox generationsNumberTextBox;

        private System.Windows.Forms.TextBox matrixSizeTextBox;

        private System.Windows.Forms.ComboBox worksheetComboBox;

        private System.Windows.Forms.Label label2X;
        private System.Windows.Forms.Label matrixPointYLabel;
        private System.Windows.Forms.TextBox matrixPointYValueTextBox;
        private System.Windows.Forms.Label matrixPointLabel;

        private System.Windows.Forms.TextBox matrixPointXValueTextBox;
        private System.Windows.Forms.Label matrixSizeLabel;

        private System.Windows.Forms.ComboBox Co;

        private System.Windows.Forms.Label worksheetLabel;

        private System.Windows.Forms.Label label1;

        private System.Windows.Forms.Button startGAButton;
        private System.Windows.Forms.Label resultLabel;

        #endregion
    }
}