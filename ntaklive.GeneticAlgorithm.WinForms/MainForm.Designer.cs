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
            this.populationSizeLabel = new System.Windows.Forms.Label();
            this.maxPopulationSizeLabel = new System.Windows.Forms.Label();
            this.populationMaxValueTextBox = new System.Windows.Forms.TextBox();
            this.minPopulationSizeLabel = new System.Windows.Forms.Label();
            this.populationMinValueTextBox = new System.Windows.Forms.TextBox();
            this.generationsLabel = new System.Windows.Forms.Label();
            this.generationsNumberTextBox = new System.Windows.Forms.TextBox();
            this.resultValueRichTextBox = new System.Windows.Forms.RichTextBox();
            this.selectionsBox = new System.Windows.Forms.GroupBox();
            this.radioButton4 = new System.Windows.Forms.RadioButton();
            this.radioButton3 = new System.Windows.Forms.RadioButton();
            this.radioButton2 = new System.Windows.Forms.RadioButton();
            this.radioButton1 = new System.Windows.Forms.RadioButton();
            this.crossoversBox = new System.Windows.Forms.GroupBox();
            this.radioButton15 = new System.Windows.Forms.RadioButton();
            this.radioButton14 = new System.Windows.Forms.RadioButton();
            this.radioButton13 = new System.Windows.Forms.RadioButton();
            this.radioButton12 = new System.Windows.Forms.RadioButton();
            this.radioButton11 = new System.Windows.Forms.RadioButton();
            this.radioButton10 = new System.Windows.Forms.RadioButton();
            this.radioButton9 = new System.Windows.Forms.RadioButton();
            this.radioButton5 = new System.Windows.Forms.RadioButton();
            this.radioButton6 = new System.Windows.Forms.RadioButton();
            this.mutationsBox = new System.Windows.Forms.GroupBox();
            this.radioButton21 = new System.Windows.Forms.RadioButton();
            this.radioButton22 = new System.Windows.Forms.RadioButton();
            this.radioButton24 = new System.Windows.Forms.RadioButton();
            this.radioButton26 = new System.Windows.Forms.RadioButton();
            this.fitnessesBox = new System.Windows.Forms.GroupBox();
            this.radioButton19 = new System.Windows.Forms.RadioButton();
            this.populationsBox = new System.Windows.Forms.GroupBox();
            this.radioButton16 = new System.Windows.Forms.RadioButton();
            this.populationsTable = new System.Windows.Forms.DataGridView();
            this.MinPopulations = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.MaxPopulations = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.generationsCountTable = new System.Windows.Forms.DataGridView();
            this.GenerationsCount = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Repeats = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.mode = new System.Windows.Forms.GroupBox();
            this.many = new System.Windows.Forms.RadioButton();
            this.single = new System.Windows.Forms.RadioButton();
            this.folderButton = new System.Windows.Forms.Button();
            this.folderLabel = new System.Windows.Forms.Label();
            this.exportTypeGroup = new System.Windows.Forms.GroupBox();
            this.jsonExportMode = new System.Windows.Forms.RadioButton();
            this.excelMode = new System.Windows.Forms.RadioButton();
            this.exportExcelLabel = new System.Windows.Forms.Label();
            this.exportExcelButton = new System.Windows.Forms.Button();
            this.selectionsBox.SuspendLayout();
            this.crossoversBox.SuspendLayout();
            this.mutationsBox.SuspendLayout();
            this.fitnessesBox.SuspendLayout();
            this.populationsBox.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.populationsTable)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.generationsCountTable)).BeginInit();
            this.mode.SuspendLayout();
            this.exportTypeGroup.SuspendLayout();
            this.SuspendLayout();
            // 
            // startGAButton
            // 
            this.startGAButton.Location = new System.Drawing.Point(16, 15);
            this.startGAButton.Margin = new System.Windows.Forms.Padding(4);
            this.startGAButton.Name = "startGAButton";
            this.startGAButton.Size = new System.Drawing.Size(100, 28);
            this.startGAButton.TabIndex = 0;
            this.startGAButton.Text = "Искать";
            this.startGAButton.UseVisualStyleBackColor = true;
            this.startGAButton.Click += new System.EventHandler(this.startGAButton_Click);
            // 
            // resultLabel
            // 
            this.resultLabel.Location = new System.Drawing.Point(16, 233);
            this.resultLabel.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.resultLabel.Name = "resultLabel";
            this.resultLabel.Size = new System.Drawing.Size(100, 20);
            this.resultLabel.TabIndex = 1;
            this.resultLabel.Text = "Лог:";
            // 
            // label1
            // 
            this.label1.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.label1.Location = new System.Drawing.Point(20, 218);
            this.label1.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(523, 2);
            this.label1.TabIndex = 2;
            // 
            // worksheetComboBox
            // 
            this.worksheetComboBox.FormattingEnabled = true;
            this.worksheetComboBox.Location = new System.Drawing.Point(124, 50);
            this.worksheetComboBox.Margin = new System.Windows.Forms.Padding(4);
            this.worksheetComboBox.Name = "worksheetComboBox";
            this.worksheetComboBox.Size = new System.Drawing.Size(417, 24);
            this.worksheetComboBox.TabIndex = 4;
            this.worksheetComboBox.DropDown += new System.EventHandler(this.worksheetDropDown_DropDown);
            this.worksheetComboBox.SelectedIndexChanged += new System.EventHandler(this.worksheetComboBox_SelectedIndexChanged);
            // 
            // worksheetLabel
            // 
            this.worksheetLabel.Location = new System.Drawing.Point(16, 48);
            this.worksheetLabel.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.worksheetLabel.Name = "worksheetLabel";
            this.worksheetLabel.Size = new System.Drawing.Size(80, 28);
            this.worksheetLabel.TabIndex = 5;
            this.worksheetLabel.Text = "Лист:";
            this.worksheetLabel.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // matrixSizeTextBox
            // 
            this.matrixSizeTextBox.Location = new System.Drawing.Point(124, 84);
            this.matrixSizeTextBox.Margin = new System.Windows.Forms.Padding(4);
            this.matrixSizeTextBox.Name = "matrixSizeTextBox";
            this.matrixSizeTextBox.Size = new System.Drawing.Size(417, 22);
            this.matrixSizeTextBox.TabIndex = 6;
            this.matrixSizeTextBox.TextChanged += new System.EventHandler(this.matrixSizeTextBox_TextChanged);
            // 
            // matrixSizeLabel
            // 
            this.matrixSizeLabel.Location = new System.Drawing.Point(16, 84);
            this.matrixSizeLabel.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.matrixSizeLabel.Name = "matrixSizeLabel";
            this.matrixSizeLabel.Size = new System.Drawing.Size(80, 28);
            this.matrixSizeLabel.TabIndex = 7;
            this.matrixSizeLabel.Text = "Размер:";
            this.matrixSizeLabel.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // label2X
            // 
            this.label2X.Location = new System.Drawing.Point(193, 113);
            this.label2X.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label2X.Name = "label2X";
            this.label2X.Size = new System.Drawing.Size(52, 25);
            this.label2X.TabIndex = 9;
            this.label2X.Text = "X:";
            this.label2X.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // matrixPointXValueTextBox
            // 
            this.matrixPointXValueTextBox.Location = new System.Drawing.Point(253, 116);
            this.matrixPointXValueTextBox.Margin = new System.Windows.Forms.Padding(4);
            this.matrixPointXValueTextBox.Name = "matrixPointXValueTextBox";
            this.matrixPointXValueTextBox.Size = new System.Drawing.Size(109, 22);
            this.matrixPointXValueTextBox.TabIndex = 8;
            this.matrixPointXValueTextBox.TextChanged += new System.EventHandler(this.matrixPointXValueTextBox_TextChanged);
            // 
            // matrixPointYLabel
            // 
            this.matrixPointYLabel.Location = new System.Drawing.Point(372, 113);
            this.matrixPointYLabel.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.matrixPointYLabel.Name = "matrixPointYLabel";
            this.matrixPointYLabel.Size = new System.Drawing.Size(52, 25);
            this.matrixPointYLabel.TabIndex = 11;
            this.matrixPointYLabel.Text = "Y:";
            this.matrixPointYLabel.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // matrixPointYValueTextBox
            // 
            this.matrixPointYValueTextBox.Location = new System.Drawing.Point(432, 116);
            this.matrixPointYValueTextBox.Margin = new System.Windows.Forms.Padding(4);
            this.matrixPointYValueTextBox.Name = "matrixPointYValueTextBox";
            this.matrixPointYValueTextBox.Size = new System.Drawing.Size(109, 22);
            this.matrixPointYValueTextBox.TabIndex = 10;
            this.matrixPointYValueTextBox.TextChanged += new System.EventHandler(this.matrixPointYValueTextBox_TextChanged);
            // 
            // matrixPointLabel
            // 
            this.matrixPointLabel.Location = new System.Drawing.Point(16, 114);
            this.matrixPointLabel.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.matrixPointLabel.Name = "matrixPointLabel";
            this.matrixPointLabel.Size = new System.Drawing.Size(169, 25);
            this.matrixPointLabel.TabIndex = 12;
            this.matrixPointLabel.Text = "Координаты матрицы:";
            this.matrixPointLabel.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // populationSizeLabel
            // 
            this.populationSizeLabel.Location = new System.Drawing.Point(16, 146);
            this.populationSizeLabel.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.populationSizeLabel.Name = "populationSizeLabel";
            this.populationSizeLabel.Size = new System.Drawing.Size(169, 25);
            this.populationSizeLabel.TabIndex = 17;
            this.populationSizeLabel.Text = "Размер популяции:";
            this.populationSizeLabel.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // maxPopulationSizeLabel
            // 
            this.maxPopulationSizeLabel.Location = new System.Drawing.Point(372, 145);
            this.maxPopulationSizeLabel.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.maxPopulationSizeLabel.Name = "maxPopulationSizeLabel";
            this.maxPopulationSizeLabel.Size = new System.Drawing.Size(52, 25);
            this.maxPopulationSizeLabel.TabIndex = 16;
            this.maxPopulationSizeLabel.Text = "Макс:";
            this.maxPopulationSizeLabel.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // populationMaxValueTextBox
            // 
            this.populationMaxValueTextBox.Location = new System.Drawing.Point(432, 148);
            this.populationMaxValueTextBox.Margin = new System.Windows.Forms.Padding(4);
            this.populationMaxValueTextBox.Name = "populationMaxValueTextBox";
            this.populationMaxValueTextBox.Size = new System.Drawing.Size(109, 22);
            this.populationMaxValueTextBox.TabIndex = 15;
            this.populationMaxValueTextBox.TextChanged += new System.EventHandler(this.populationMaxValueTextBox_TextChanged);
            // 
            // minPopulationSizeLabel
            // 
            this.minPopulationSizeLabel.Location = new System.Drawing.Point(193, 145);
            this.minPopulationSizeLabel.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.minPopulationSizeLabel.Name = "minPopulationSizeLabel";
            this.minPopulationSizeLabel.Size = new System.Drawing.Size(52, 25);
            this.minPopulationSizeLabel.TabIndex = 14;
            this.minPopulationSizeLabel.Text = "Мин:";
            this.minPopulationSizeLabel.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // populationMinValueTextBox
            // 
            this.populationMinValueTextBox.Location = new System.Drawing.Point(253, 148);
            this.populationMinValueTextBox.Margin = new System.Windows.Forms.Padding(4);
            this.populationMinValueTextBox.Name = "populationMinValueTextBox";
            this.populationMinValueTextBox.Size = new System.Drawing.Size(109, 22);
            this.populationMinValueTextBox.TabIndex = 13;
            this.populationMinValueTextBox.TextChanged += new System.EventHandler(this.populationMinValueTextBox_TextChanged);
            // 
            // generationsLabel
            // 
            this.generationsLabel.Location = new System.Drawing.Point(16, 180);
            this.generationsLabel.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.generationsLabel.Name = "generationsLabel";
            this.generationsLabel.Size = new System.Drawing.Size(100, 28);
            this.generationsLabel.TabIndex = 19;
            this.generationsLabel.Text = "Поколения:";
            this.generationsLabel.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // generationsNumberTextBox
            // 
            this.generationsNumberTextBox.Location = new System.Drawing.Point(124, 180);
            this.generationsNumberTextBox.Margin = new System.Windows.Forms.Padding(4);
            this.generationsNumberTextBox.Name = "generationsNumberTextBox";
            this.generationsNumberTextBox.Size = new System.Drawing.Size(417, 22);
            this.generationsNumberTextBox.TabIndex = 18;
            this.generationsNumberTextBox.TextChanged += new System.EventHandler(this.generationsNumberTextBox_TextChanged);
            // 
            // resultValueRichTextBox
            // 
            this.resultValueRichTextBox.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.resultValueRichTextBox.Location = new System.Drawing.Point(20, 256);
            this.resultValueRichTextBox.Margin = new System.Windows.Forms.Padding(4);
            this.resultValueRichTextBox.Name = "resultValueRichTextBox";
            this.resultValueRichTextBox.ReadOnly = true;
            this.resultValueRichTextBox.Size = new System.Drawing.Size(521, 307);
            this.resultValueRichTextBox.TabIndex = 20;
            this.resultValueRichTextBox.Text = "";
            // 
            // selectionsBox
            // 
            this.selectionsBox.Controls.Add(this.radioButton4);
            this.selectionsBox.Controls.Add(this.radioButton3);
            this.selectionsBox.Controls.Add(this.radioButton2);
            this.selectionsBox.Controls.Add(this.radioButton1);
            this.selectionsBox.Location = new System.Drawing.Point(571, 48);
            this.selectionsBox.Name = "selectionsBox";
            this.selectionsBox.Size = new System.Drawing.Size(216, 143);
            this.selectionsBox.TabIndex = 21;
            this.selectionsBox.TabStop = false;
            this.selectionsBox.Text = "Selections";
            // 
            // radioButton4
            // 
            this.radioButton4.AutoSize = true;
            this.radioButton4.Checked = true;
            this.radioButton4.Location = new System.Drawing.Point(6, 109);
            this.radioButton4.Name = "radioButton4";
            this.radioButton4.Size = new System.Drawing.Size(100, 20);
            this.radioButton4.TabIndex = 3;
            this.radioButton4.TabStop = true;
            this.radioButton4.Text = "Tournament";
            this.radioButton4.UseVisualStyleBackColor = true;
            // 
            // radioButton3
            // 
            this.radioButton3.AutoSize = true;
            this.radioButton3.Location = new System.Drawing.Point(6, 83);
            this.radioButton3.Name = "radioButton3";
            this.radioButton3.Size = new System.Drawing.Size(204, 20);
            this.radioButton3.TabIndex = 2;
            this.radioButton3.Text = "StochasticUniversalSampling";
            this.radioButton3.UseVisualStyleBackColor = true;
            // 
            // radioButton2
            // 
            this.radioButton2.AutoSize = true;
            this.radioButton2.Location = new System.Drawing.Point(6, 57);
            this.radioButton2.Name = "radioButton2";
            this.radioButton2.Size = new System.Drawing.Size(117, 20);
            this.radioButton2.TabIndex = 1;
            this.radioButton2.Text = "RouletteWheel";
            this.radioButton2.UseVisualStyleBackColor = true;
            // 
            // radioButton1
            // 
            this.radioButton1.AutoSize = true;
            this.radioButton1.Location = new System.Drawing.Point(6, 31);
            this.radioButton1.Name = "radioButton1";
            this.radioButton1.Size = new System.Drawing.Size(54, 20);
            this.radioButton1.TabIndex = 0;
            this.radioButton1.Text = "Elite";
            this.radioButton1.UseVisualStyleBackColor = true;
            // 
            // crossoversBox
            // 
            this.crossoversBox.Controls.Add(this.radioButton15);
            this.crossoversBox.Controls.Add(this.radioButton14);
            this.crossoversBox.Controls.Add(this.radioButton13);
            this.crossoversBox.Controls.Add(this.radioButton12);
            this.crossoversBox.Controls.Add(this.radioButton11);
            this.crossoversBox.Controls.Add(this.radioButton10);
            this.crossoversBox.Controls.Add(this.radioButton9);
            this.crossoversBox.Controls.Add(this.radioButton5);
            this.crossoversBox.Controls.Add(this.radioButton6);
            this.crossoversBox.Location = new System.Drawing.Point(807, 50);
            this.crossoversBox.Name = "crossoversBox";
            this.crossoversBox.Size = new System.Drawing.Size(210, 266);
            this.crossoversBox.TabIndex = 22;
            this.crossoversBox.TabStop = false;
            this.crossoversBox.Text = "Crossovers";
            // 
            // radioButton15
            // 
            this.radioButton15.AutoSize = true;
            this.radioButton15.Location = new System.Drawing.Point(6, 29);
            this.radioButton15.Name = "radioButton15";
            this.radioButton15.Size = new System.Drawing.Size(74, 20);
            this.radioButton15.TabIndex = 10;
            this.radioButton15.Text = "Uniform";
            this.radioButton15.UseVisualStyleBackColor = true;
            // 
            // radioButton14
            // 
            this.radioButton14.AutoSize = true;
            this.radioButton14.Location = new System.Drawing.Point(6, 57);
            this.radioButton14.Name = "radioButton14";
            this.radioButton14.Size = new System.Drawing.Size(84, 20);
            this.radioButton14.TabIndex = 9;
            this.radioButton14.Text = "TwoPoint";
            this.radioButton14.UseVisualStyleBackColor = true;
            // 
            // radioButton13
            // 
            this.radioButton13.AutoSize = true;
            this.radioButton13.Location = new System.Drawing.Point(6, 238);
            this.radioButton13.Name = "radioButton13";
            this.radioButton13.Size = new System.Drawing.Size(103, 20);
            this.radioButton13.TabIndex = 8;
            this.radioButton13.Text = "ThreeParent";
            this.radioButton13.UseVisualStyleBackColor = true;
            // 
            // radioButton12
            // 
            this.radioButton12.AutoSize = true;
            this.radioButton12.Location = new System.Drawing.Point(6, 212);
            this.radioButton12.Name = "radioButton12";
            this.radioButton12.Size = new System.Drawing.Size(116, 20);
            this.radioButton12.TabIndex = 7;
            this.radioButton12.Text = "PositionBased";
            this.radioButton12.UseVisualStyleBackColor = true;
            // 
            // radioButton11
            // 
            this.radioButton11.AutoSize = true;
            this.radioButton11.Location = new System.Drawing.Point(6, 186);
            this.radioButton11.Name = "radioButton11";
            this.radioButton11.Size = new System.Drawing.Size(127, 20);
            this.radioButton11.TabIndex = 6;
            this.radioButton11.Text = "PartiallyMapped";
            this.radioButton11.UseVisualStyleBackColor = true;
            // 
            // radioButton10
            // 
            this.radioButton10.AutoSize = true;
            this.radioButton10.Checked = true;
            this.radioButton10.Location = new System.Drawing.Point(6, 160);
            this.radioButton10.Name = "radioButton10";
            this.radioButton10.Size = new System.Drawing.Size(78, 20);
            this.radioButton10.TabIndex = 5;
            this.radioButton10.TabStop = true;
            this.radioButton10.Text = "Ordered";
            this.radioButton10.UseVisualStyleBackColor = true;
            // 
            // radioButton9
            // 
            this.radioButton9.AutoSize = true;
            this.radioButton9.Location = new System.Drawing.Point(6, 134);
            this.radioButton9.Name = "radioButton9";
            this.radioButton9.Size = new System.Drawing.Size(102, 20);
            this.radioButton9.TabIndex = 4;
            this.radioButton9.Text = "OrderBased";
            this.radioButton9.UseVisualStyleBackColor = true;
            // 
            // radioButton5
            // 
            this.radioButton5.AutoSize = true;
            this.radioButton5.Location = new System.Drawing.Point(6, 109);
            this.radioButton5.Name = "radioButton5";
            this.radioButton5.Size = new System.Drawing.Size(83, 20);
            this.radioButton5.TabIndex = 3;
            this.radioButton5.Text = "OnePoint";
            this.radioButton5.UseVisualStyleBackColor = true;
            // 
            // radioButton6
            // 
            this.radioButton6.AutoSize = true;
            this.radioButton6.Location = new System.Drawing.Point(6, 83);
            this.radioButton6.Name = "radioButton6";
            this.radioButton6.Size = new System.Drawing.Size(62, 20);
            this.radioButton6.TabIndex = 2;
            this.radioButton6.Text = "Cycle";
            this.radioButton6.UseVisualStyleBackColor = true;
            // 
            // mutationsBox
            // 
            this.mutationsBox.Controls.Add(this.radioButton21);
            this.mutationsBox.Controls.Add(this.radioButton22);
            this.mutationsBox.Controls.Add(this.radioButton24);
            this.mutationsBox.Controls.Add(this.radioButton26);
            this.mutationsBox.Location = new System.Drawing.Point(571, 197);
            this.mutationsBox.Name = "mutationsBox";
            this.mutationsBox.Size = new System.Drawing.Size(216, 137);
            this.mutationsBox.TabIndex = 23;
            this.mutationsBox.TabStop = false;
            this.mutationsBox.Text = "Mutations";
            // 
            // radioButton21
            // 
            this.radioButton21.AutoSize = true;
            this.radioButton21.Location = new System.Drawing.Point(6, 109);
            this.radioButton21.Name = "radioButton21";
            this.radioButton21.Size = new System.Drawing.Size(65, 20);
            this.radioButton21.TabIndex = 5;
            this.radioButton21.Text = "Twors";
            this.radioButton21.UseVisualStyleBackColor = true;
            // 
            // radioButton22
            // 
            this.radioButton22.AutoSize = true;
            this.radioButton22.Location = new System.Drawing.Point(6, 83);
            this.radioButton22.Name = "radioButton22";
            this.radioButton22.Size = new System.Drawing.Size(142, 20);
            this.radioButton22.TabIndex = 4;
            this.radioButton22.Text = "ReverseSequence";
            this.radioButton22.UseVisualStyleBackColor = true;
            // 
            // radioButton24
            // 
            this.radioButton24.AutoSize = true;
            this.radioButton24.Checked = true;
            this.radioButton24.Location = new System.Drawing.Point(6, 57);
            this.radioButton24.Name = "radioButton24";
            this.radioButton24.Size = new System.Drawing.Size(78, 20);
            this.radioButton24.TabIndex = 2;
            this.radioButton24.TabStop = true;
            this.radioButton24.Text = "Insertion";
            this.radioButton24.UseVisualStyleBackColor = true;
            // 
            // radioButton26
            // 
            this.radioButton26.AutoSize = true;
            this.radioButton26.Location = new System.Drawing.Point(6, 31);
            this.radioButton26.Name = "radioButton26";
            this.radioButton26.Size = new System.Drawing.Size(111, 20);
            this.radioButton26.TabIndex = 0;
            this.radioButton26.Text = "Displacement";
            this.radioButton26.TextAlign = System.Drawing.ContentAlignment.BottomCenter;
            this.radioButton26.UseVisualStyleBackColor = true;
            // 
            // fitnessesBox
            // 
            this.fitnessesBox.Controls.Add(this.radioButton19);
            this.fitnessesBox.Location = new System.Drawing.Point(807, 347);
            this.fitnessesBox.Name = "fitnessesBox";
            this.fitnessesBox.Size = new System.Drawing.Size(210, 64);
            this.fitnessesBox.TabIndex = 22;
            this.fitnessesBox.TabStop = false;
            this.fitnessesBox.Text = "Fitnesses";
            // 
            // radioButton19
            // 
            this.radioButton19.AutoSize = true;
            this.radioButton19.Checked = true;
            this.radioButton19.Location = new System.Drawing.Point(6, 31);
            this.radioButton19.Name = "radioButton19";
            this.radioButton19.Size = new System.Drawing.Size(89, 20);
            this.radioButton19.TabIndex = 0;
            this.radioButton19.TabStop = true;
            this.radioButton19.Text = "MyFitness";
            this.radioButton19.UseVisualStyleBackColor = true;
            // 
            // populationsBox
            // 
            this.populationsBox.Controls.Add(this.radioButton16);
            this.populationsBox.Location = new System.Drawing.Point(571, 346);
            this.populationsBox.Name = "populationsBox";
            this.populationsBox.Size = new System.Drawing.Size(216, 64);
            this.populationsBox.TabIndex = 23;
            this.populationsBox.TabStop = false;
            this.populationsBox.Text = "Populations";
            // 
            // radioButton16
            // 
            this.radioButton16.AutoSize = true;
            this.radioButton16.Checked = true;
            this.radioButton16.Location = new System.Drawing.Point(6, 31);
            this.radioButton16.Name = "radioButton16";
            this.radioButton16.Size = new System.Drawing.Size(117, 20);
            this.radioButton16.TabIndex = 0;
            this.radioButton16.TabStop = true;
            this.radioButton16.Text = "TPLPopulation";
            this.radioButton16.UseVisualStyleBackColor = true;
            // 
            // populationsTable
            // 
            this.populationsTable.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.ColumnHeader;
            this.populationsTable.AutoSizeRowsMode = System.Windows.Forms.DataGridViewAutoSizeRowsMode.AllCellsExceptHeaders;
            this.populationsTable.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.populationsTable.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.MinPopulations,
            this.MaxPopulations});
            this.populationsTable.Location = new System.Drawing.Point(1033, 56);
            this.populationsTable.Margin = new System.Windows.Forms.Padding(0);
            this.populationsTable.Name = "populationsTable";
            this.populationsTable.RowHeadersWidthSizeMode = System.Windows.Forms.DataGridViewRowHeadersWidthSizeMode.AutoSizeToAllHeaders;
            this.populationsTable.RowTemplate.Height = 24;
            this.populationsTable.ScrollBars = System.Windows.Forms.ScrollBars.Vertical;
            this.populationsTable.Size = new System.Drawing.Size(325, 135);
            this.populationsTable.TabIndex = 24;
            this.populationsTable.Visible = false;
            // 
            // MinPopulations
            // 
            this.MinPopulations.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.ColumnHeader;
            this.MinPopulations.Frozen = true;
            this.MinPopulations.HeaderText = "MinPopulations";
            this.MinPopulations.MinimumWidth = 100;
            this.MinPopulations.Name = "MinPopulations";
            this.MinPopulations.Resizable = System.Windows.Forms.DataGridViewTriState.False;
            this.MinPopulations.Width = 128;
            // 
            // MaxPopulations
            // 
            this.MaxPopulations.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.ColumnHeader;
            this.MaxPopulations.HeaderText = "MaxPopulations";
            this.MaxPopulations.MinimumWidth = 100;
            this.MaxPopulations.Name = "MaxPopulations";
            this.MaxPopulations.Resizable = System.Windows.Forms.DataGridViewTriState.False;
            this.MaxPopulations.Width = 132;
            // 
            // generationsCountTable
            // 
            this.generationsCountTable.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.ColumnHeader;
            this.generationsCountTable.AutoSizeRowsMode = System.Windows.Forms.DataGridViewAutoSizeRowsMode.AllHeaders;
            this.generationsCountTable.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.generationsCountTable.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.GenerationsCount,
            this.Repeats});
            this.generationsCountTable.Location = new System.Drawing.Point(1033, 236);
            this.generationsCountTable.Name = "generationsCountTable";
            this.generationsCountTable.RowHeadersWidthSizeMode = System.Windows.Forms.DataGridViewRowHeadersWidthSizeMode.AutoSizeToAllHeaders;
            this.generationsCountTable.RowTemplate.Height = 24;
            this.generationsCountTable.ScrollBars = System.Windows.Forms.ScrollBars.Vertical;
            this.generationsCountTable.Size = new System.Drawing.Size(325, 135);
            this.generationsCountTable.TabIndex = 25;
            this.generationsCountTable.Visible = false;
            // 
            // GenerationsCount
            // 
            this.GenerationsCount.HeaderText = "GenerationsCount";
            this.GenerationsCount.MinimumWidth = 6;
            this.GenerationsCount.Name = "GenerationsCount";
            this.GenerationsCount.Width = 143;
            // 
            // Repeats
            // 
            this.Repeats.HeaderText = "Repeats";
            this.Repeats.MinimumWidth = 6;
            this.Repeats.Name = "Repeats";
            this.Repeats.Width = 88;
            // 
            // mode
            // 
            this.mode.Controls.Add(this.many);
            this.mode.Controls.Add(this.single);
            this.mode.Location = new System.Drawing.Point(217, 3);
            this.mode.Name = "mode";
            this.mode.Size = new System.Drawing.Size(338, 38);
            this.mode.TabIndex = 27;
            this.mode.TabStop = false;
            // 
            // many
            // 
            this.many.AutoSize = true;
            this.many.Location = new System.Drawing.Point(171, 12);
            this.many.Name = "many";
            this.many.Size = new System.Drawing.Size(135, 20);
            this.many.TabIndex = 1;
            this.many.Text = "Множественный";
            this.many.UseVisualStyleBackColor = true;
            this.many.CheckedChanged += new System.EventHandler(this.many_CheckedChanged);
            // 
            // single
            // 
            this.single.AutoSize = true;
            this.single.Checked = true;
            this.single.Location = new System.Drawing.Point(35, 12);
            this.single.Name = "single";
            this.single.Size = new System.Drawing.Size(103, 20);
            this.single.TabIndex = 0;
            this.single.TabStop = true;
            this.single.Text = "Одиночный";
            this.single.UseVisualStyleBackColor = true;
            this.single.CheckedChanged += new System.EventHandler(this.single_CheckedChanged);
            // 
            // folderButton
            // 
            this.folderButton.Location = new System.Drawing.Point(1033, 429);
            this.folderButton.Name = "folderButton";
            this.folderButton.Size = new System.Drawing.Size(75, 23);
            this.folderButton.TabIndex = 28;
            this.folderButton.Text = "Вывод";
            this.folderButton.UseVisualStyleBackColor = true;
            this.folderButton.Visible = false;
            this.folderButton.Click += new System.EventHandler(this.button1_Click);
            // 
            // folderLabel
            // 
            this.folderLabel.AutoSize = true;
            this.folderLabel.Location = new System.Drawing.Point(1030, 394);
            this.folderLabel.Name = "folderLabel";
            this.folderLabel.Size = new System.Drawing.Size(223, 16);
            this.folderLabel.TabIndex = 29;
            this.folderLabel.Text = "Выберите папку на вывод файла";
            this.folderLabel.Visible = false;
            // 
            // exportTypeGroup
            // 
            this.exportTypeGroup.Controls.Add(this.jsonExportMode);
            this.exportTypeGroup.Controls.Add(this.excelMode);
            this.exportTypeGroup.Location = new System.Drawing.Point(807, 417);
            this.exportTypeGroup.Name = "exportTypeGroup";
            this.exportTypeGroup.Size = new System.Drawing.Size(119, 100);
            this.exportTypeGroup.TabIndex = 30;
            this.exportTypeGroup.TabStop = false;
            this.exportTypeGroup.Visible = false;
            this.exportTypeGroup.Enter += new System.EventHandler(this.groupBox1_Enter);
            // 
            // jsonExportMode
            // 
            this.jsonExportMode.AutoSize = true;
            this.jsonExportMode.Checked = true;
            this.jsonExportMode.Location = new System.Drawing.Point(4, 60);
            this.jsonExportMode.Name = "jsonExportMode";
            this.jsonExportMode.Size = new System.Drawing.Size(53, 20);
            this.jsonExportMode.TabIndex = 1;
            this.jsonExportMode.TabStop = true;
            this.jsonExportMode.Text = "json";
            this.jsonExportMode.UseVisualStyleBackColor = true;
            this.jsonExportMode.CheckedChanged += new System.EventHandler(this.jsonExportMode_CheckedChanged);
            // 
            // excelMode
            // 
            this.excelMode.AutoSize = true;
            this.excelMode.Location = new System.Drawing.Point(6, 21);
            this.excelMode.Name = "excelMode";
            this.excelMode.Size = new System.Drawing.Size(60, 20);
            this.excelMode.TabIndex = 0;
            this.excelMode.Text = "excel";
            this.excelMode.UseVisualStyleBackColor = true;
            this.excelMode.CheckedChanged += new System.EventHandler(this.excelMode_CheckedChanged);
            // 
            // exportExcelLabel
            // 
            this.exportExcelLabel.AutoSize = true;
            this.exportExcelLabel.Location = new System.Drawing.Point(1030, 488);
            this.exportExcelLabel.Name = "exportExcelLabel";
            this.exportExcelLabel.Size = new System.Drawing.Size(208, 16);
            this.exportExcelLabel.TabIndex = 31;
            this.exportExcelLabel.Text = "Выберите excel файл на вывод";
            this.exportExcelLabel.Visible = false;
            // 
            // exportExcelButton
            // 
            this.exportExcelButton.Location = new System.Drawing.Point(1033, 523);
            this.exportExcelButton.Name = "exportExcelButton";
            this.exportExcelButton.Size = new System.Drawing.Size(131, 23);
            this.exportExcelButton.TabIndex = 32;
            this.exportExcelButton.Text = "Вывод в excel";
            this.exportExcelButton.UseVisualStyleBackColor = true;
            this.exportExcelButton.Visible = false;
            this.exportExcelButton.Click += new System.EventHandler(this.exportExcelButton_Click);
            // 
            // MainForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1486, 600);
            this.Controls.Add(this.exportExcelButton);
            this.Controls.Add(this.exportExcelLabel);
            this.Controls.Add(this.exportTypeGroup);
            this.Controls.Add(this.folderLabel);
            this.Controls.Add(this.folderButton);
            this.Controls.Add(this.mode);
            this.Controls.Add(this.generationsCountTable);
            this.Controls.Add(this.populationsTable);
            this.Controls.Add(this.populationsBox);
            this.Controls.Add(this.fitnessesBox);
            this.Controls.Add(this.mutationsBox);
            this.Controls.Add(this.crossoversBox);
            this.Controls.Add(this.selectionsBox);
            this.Controls.Add(this.resultValueRichTextBox);
            this.Controls.Add(this.generationsLabel);
            this.Controls.Add(this.generationsNumberTextBox);
            this.Controls.Add(this.populationSizeLabel);
            this.Controls.Add(this.maxPopulationSizeLabel);
            this.Controls.Add(this.populationMaxValueTextBox);
            this.Controls.Add(this.minPopulationSizeLabel);
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
            this.Margin = new System.Windows.Forms.Padding(4);
            this.MaximizeBox = false;
            this.Name = "MainForm";
            this.SizeGripStyle = System.Windows.Forms.SizeGripStyle.Hide;
            this.Text = "Genetic Algorithm";
            this.FormClosed += new System.Windows.Forms.FormClosedEventHandler(this.MainForm_FormClosed);
            this.Load += new System.EventHandler(this.MainForm_Load);
            this.selectionsBox.ResumeLayout(false);
            this.selectionsBox.PerformLayout();
            this.crossoversBox.ResumeLayout(false);
            this.crossoversBox.PerformLayout();
            this.mutationsBox.ResumeLayout(false);
            this.mutationsBox.PerformLayout();
            this.fitnessesBox.ResumeLayout(false);
            this.fitnessesBox.PerformLayout();
            this.populationsBox.ResumeLayout(false);
            this.populationsBox.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.populationsTable)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.generationsCountTable)).EndInit();
            this.mode.ResumeLayout(false);
            this.mode.PerformLayout();
            this.exportTypeGroup.ResumeLayout(false);
            this.exportTypeGroup.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        private System.Windows.Forms.RichTextBox resultValueRichTextBox;

        private System.Windows.Forms.Label populationSizeLabel;
        private System.Windows.Forms.Label maxPopulationSizeLabel;
        private System.Windows.Forms.TextBox populationMaxValueTextBox;
        private System.Windows.Forms.Label minPopulationSizeLabel;
        private System.Windows.Forms.TextBox populationMinValueTextBox;
        private System.Windows.Forms.Label generationsLabel;
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

        private System.Windows.Forms.GroupBox selectionsBox;
        private System.Windows.Forms.RadioButton radioButton2;
        private System.Windows.Forms.RadioButton radioButton1;
        private System.Windows.Forms.RadioButton radioButton3;
        private System.Windows.Forms.RadioButton radioButton4;
        private System.Windows.Forms.GroupBox crossoversBox;
        private System.Windows.Forms.RadioButton radioButton5;
        private System.Windows.Forms.RadioButton radioButton6;
        private System.Windows.Forms.RadioButton radioButton11;
        private System.Windows.Forms.RadioButton radioButton10;
        private System.Windows.Forms.RadioButton radioButton9;
        private System.Windows.Forms.RadioButton radioButton15;
        private System.Windows.Forms.RadioButton radioButton14;
        private System.Windows.Forms.RadioButton radioButton13;
        private System.Windows.Forms.RadioButton radioButton12;
        private System.Windows.Forms.GroupBox mutationsBox;
        private System.Windows.Forms.RadioButton radioButton21;
        private System.Windows.Forms.RadioButton radioButton22;
        private System.Windows.Forms.RadioButton radioButton24;
        private System.Windows.Forms.RadioButton radioButton26;
        private System.Windows.Forms.GroupBox fitnessesBox;
        private System.Windows.Forms.RadioButton radioButton19;
        private System.Windows.Forms.GroupBox populationsBox;
        private System.Windows.Forms.RadioButton radioButton16;
        private System.Windows.Forms.DataGridView populationsTable;
        private System.Windows.Forms.DataGridView generationsCountTable;
        private System.Windows.Forms.GroupBox mode;
        private System.Windows.Forms.RadioButton many;
        private System.Windows.Forms.RadioButton single;
        private System.Windows.Forms.DataGridViewTextBoxColumn MinPopulations;
        private System.Windows.Forms.DataGridViewTextBoxColumn MaxPopulations;
        private System.Windows.Forms.Button folderButton;
        private System.Windows.Forms.Label folderLabel;
        private System.Windows.Forms.DataGridViewTextBoxColumn GenerationsCount;
        private System.Windows.Forms.DataGridViewTextBoxColumn Repeats;
        private System.Windows.Forms.GroupBox exportTypeGroup;
        private System.Windows.Forms.RadioButton jsonExportMode;
        private System.Windows.Forms.RadioButton excelMode;
        private System.Windows.Forms.Label exportExcelLabel;
        private System.Windows.Forms.Button exportExcelButton;
    }
}