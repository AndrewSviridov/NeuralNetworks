namespace MultiLayerPerceptronClient
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
            this.grpBoxConfiguration = new System.Windows.Forms.GroupBox();
            this.grpBoxLayers = new System.Windows.Forms.GroupBox();
            this.numLayer5 = new System.Windows.Forms.NumericUpDown();
            this.numLayer1 = new System.Windows.Forms.NumericUpDown();
            this.label7 = new System.Windows.Forms.Label();
            this.label9 = new System.Windows.Forms.Label();
            this.numLayer2 = new System.Windows.Forms.NumericUpDown();
            this.numLayer3 = new System.Windows.Forms.NumericUpDown();
            this.numLayer4 = new System.Windows.Forms.NumericUpDown();
            this.label6 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.label8 = new System.Windows.Forms.Label();
            this.cmbBoxActivationFunc = new System.Windows.Forms.ComboBox();
            this.btnCreateBack = new System.Windows.Forms.Button();
            this.lblActivationFunc = new System.Windows.Forms.Label();
            this.numInputs = new System.Windows.Forms.NumericUpDown();
            this.numLayers = new System.Windows.Forms.NumericUpDown();
            this.lblNumInputs = new System.Windows.Forms.Label();
            this.lblNumNeurons = new System.Windows.Forms.Label();
            this.grpBoxTeach = new System.Windows.Forms.GroupBox();
            this.btnResetWeights = new System.Windows.Forms.Button();
            this.progBarTeaching = new System.Windows.Forms.ProgressBar();
            this.btnTeachAbort = new System.Windows.Forms.Button();
            this.numLearningRate = new System.Windows.Forms.NumericUpDown();
            this.label11 = new System.Windows.Forms.Label();
            this.numIterations = new System.Windows.Forms.NumericUpDown();
            this.label10 = new System.Windows.Forms.Label();
            this.btnRefresh = new System.Windows.Forms.Button();
            this.btnSelect = new System.Windows.Forms.Button();
            this.cmbBoxTeachingFiles = new System.Windows.Forms.ComboBox();
            this.labelFile = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.txtBoxFolder = new System.Windows.Forms.TextBox();
            this.folderBrowser = new System.Windows.Forms.FolderBrowserDialog();
            this.statusStrip = new System.Windows.Forms.StatusStrip();
            this.statusStripInfo = new System.Windows.Forms.ToolStripStatusLabel();
            this.grpBoxTest = new System.Windows.Forms.GroupBox();
            this.btnTest = new System.Windows.Forms.Button();
            this.cmbBoxTestingFiles = new System.Windows.Forms.ComboBox();
            this.label12 = new System.Windows.Forms.Label();
            this.label13 = new System.Windows.Forms.Label();
            this.groupBox3 = new System.Windows.Forms.GroupBox();
            this.label2 = new System.Windows.Forms.Label();
            this.txtBoxExpected = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.txtBoxCalculated = new System.Windows.Forms.TextBox();
            this.bgWorker = new System.ComponentModel.BackgroundWorker();
            this.grpBoxConfiguration.SuspendLayout();
            this.grpBoxLayers.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.numLayer5)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.numLayer1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.numLayer2)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.numLayer3)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.numLayer4)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.numInputs)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.numLayers)).BeginInit();
            this.grpBoxTeach.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.numLearningRate)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.numIterations)).BeginInit();
            this.statusStrip.SuspendLayout();
            this.grpBoxTest.SuspendLayout();
            this.groupBox3.SuspendLayout();
            this.SuspendLayout();
            // 
            // grpBoxConfiguration
            // 
            this.grpBoxConfiguration.Controls.Add(this.grpBoxLayers);
            this.grpBoxConfiguration.Controls.Add(this.cmbBoxActivationFunc);
            this.grpBoxConfiguration.Controls.Add(this.btnCreateBack);
            this.grpBoxConfiguration.Controls.Add(this.lblActivationFunc);
            this.grpBoxConfiguration.Controls.Add(this.numInputs);
            this.grpBoxConfiguration.Controls.Add(this.numLayers);
            this.grpBoxConfiguration.Controls.Add(this.lblNumInputs);
            this.grpBoxConfiguration.Controls.Add(this.lblNumNeurons);
            this.grpBoxConfiguration.Location = new System.Drawing.Point(12, 12);
            this.grpBoxConfiguration.Name = "grpBoxConfiguration";
            this.grpBoxConfiguration.Size = new System.Drawing.Size(415, 186);
            this.grpBoxConfiguration.TabIndex = 0;
            this.grpBoxConfiguration.TabStop = false;
            this.grpBoxConfiguration.Text = "Network configuration";
            // 
            // grpBoxLayers
            // 
            this.grpBoxLayers.Controls.Add(this.numLayer5);
            this.grpBoxLayers.Controls.Add(this.numLayer1);
            this.grpBoxLayers.Controls.Add(this.label7);
            this.grpBoxLayers.Controls.Add(this.label9);
            this.grpBoxLayers.Controls.Add(this.numLayer2);
            this.grpBoxLayers.Controls.Add(this.numLayer3);
            this.grpBoxLayers.Controls.Add(this.numLayer4);
            this.grpBoxLayers.Controls.Add(this.label6);
            this.grpBoxLayers.Controls.Add(this.label5);
            this.grpBoxLayers.Controls.Add(this.label8);
            this.grpBoxLayers.Location = new System.Drawing.Point(232, 19);
            this.grpBoxLayers.Name = "grpBoxLayers";
            this.grpBoxLayers.Size = new System.Drawing.Size(133, 157);
            this.grpBoxLayers.TabIndex = 7;
            this.grpBoxLayers.TabStop = false;
            this.grpBoxLayers.Text = "Neurons per layer:";
            // 
            // numLayer5
            // 
            this.numLayer5.Enabled = false;
            this.numLayer5.Location = new System.Drawing.Point(33, 123);
            this.numLayer5.Maximum = new decimal(new int[] {
            1,
            0,
            0,
            0});
            this.numLayer5.Name = "numLayer5";
            this.numLayer5.Size = new System.Drawing.Size(71, 20);
            this.numLayer5.TabIndex = 17;
            this.numLayer5.TabStop = false;
            // 
            // numLayer1
            // 
            this.numLayer1.Location = new System.Drawing.Point(33, 19);
            this.numLayer1.Maximum = new decimal(new int[] {
            1,
            0,
            0,
            0});
            this.numLayer1.Minimum = new decimal(new int[] {
            1,
            0,
            0,
            0});
            this.numLayer1.Name = "numLayer1";
            this.numLayer1.Size = new System.Drawing.Size(71, 20);
            this.numLayer1.TabIndex = 9;
            this.numLayer1.TabStop = false;
            this.numLayer1.Value = new decimal(new int[] {
            1,
            0,
            0,
            0});
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Location = new System.Drawing.Point(11, 73);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(16, 13);
            this.label7.TabIndex = 12;
            this.label7.Text = "3:";
            // 
            // label9
            // 
            this.label9.AutoSize = true;
            this.label9.Location = new System.Drawing.Point(11, 125);
            this.label9.Name = "label9";
            this.label9.Size = new System.Drawing.Size(16, 13);
            this.label9.TabIndex = 16;
            this.label9.Text = "5:";
            // 
            // numLayer2
            // 
            this.numLayer2.Enabled = false;
            this.numLayer2.Location = new System.Drawing.Point(33, 45);
            this.numLayer2.Maximum = new decimal(new int[] {
            1,
            0,
            0,
            0});
            this.numLayer2.Name = "numLayer2";
            this.numLayer2.Size = new System.Drawing.Size(71, 20);
            this.numLayer2.TabIndex = 11;
            this.numLayer2.TabStop = false;
            // 
            // numLayer3
            // 
            this.numLayer3.Enabled = false;
            this.numLayer3.Location = new System.Drawing.Point(33, 71);
            this.numLayer3.Maximum = new decimal(new int[] {
            1,
            0,
            0,
            0});
            this.numLayer3.Name = "numLayer3";
            this.numLayer3.Size = new System.Drawing.Size(71, 20);
            this.numLayer3.TabIndex = 13;
            this.numLayer3.TabStop = false;
            // 
            // numLayer4
            // 
            this.numLayer4.Enabled = false;
            this.numLayer4.Location = new System.Drawing.Point(33, 97);
            this.numLayer4.Maximum = new decimal(new int[] {
            1,
            0,
            0,
            0});
            this.numLayer4.Name = "numLayer4";
            this.numLayer4.Size = new System.Drawing.Size(71, 20);
            this.numLayer4.TabIndex = 15;
            this.numLayer4.TabStop = false;
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(11, 47);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(16, 13);
            this.label6.TabIndex = 10;
            this.label6.Text = "2:";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(11, 21);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(16, 13);
            this.label5.TabIndex = 8;
            this.label5.Text = "1:";
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Location = new System.Drawing.Point(11, 99);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(16, 13);
            this.label8.TabIndex = 14;
            this.label8.Text = "4:";
            // 
            // cmbBoxActivationFunc
            // 
            this.cmbBoxActivationFunc.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cmbBoxActivationFunc.FormattingEnabled = true;
            this.cmbBoxActivationFunc.Items.AddRange(new object[] {
            "Bipolar sigmoid",
            "Unipolar sigmoid"});
            this.cmbBoxActivationFunc.Location = new System.Drawing.Point(9, 103);
            this.cmbBoxActivationFunc.Name = "cmbBoxActivationFunc";
            this.cmbBoxActivationFunc.Size = new System.Drawing.Size(169, 21);
            this.cmbBoxActivationFunc.TabIndex = 5;
            this.cmbBoxActivationFunc.TabStop = false;
            // 
            // btnCreateBack
            // 
            this.btnCreateBack.Location = new System.Drawing.Point(9, 142);
            this.btnCreateBack.Name = "btnCreateBack";
            this.btnCreateBack.Size = new System.Drawing.Size(169, 28);
            this.btnCreateBack.TabIndex = 1;
            this.btnCreateBack.Text = "Create a network";
            this.btnCreateBack.UseVisualStyleBackColor = true;
            this.btnCreateBack.Click += new System.EventHandler(this.btnCreateBack_Click);
            // 
            // lblActivationFunc
            // 
            this.lblActivationFunc.AutoSize = true;
            this.lblActivationFunc.Location = new System.Drawing.Point(6, 87);
            this.lblActivationFunc.Name = "lblActivationFunc";
            this.lblActivationFunc.Size = new System.Drawing.Size(98, 13);
            this.lblActivationFunc.TabIndex = 4;
            this.lblActivationFunc.Text = "Activation function:";
            // 
            // numInputs
            // 
            this.numInputs.Location = new System.Drawing.Point(101, 52);
            this.numInputs.Maximum = new decimal(new int[] {
            10,
            0,
            0,
            0});
            this.numInputs.Minimum = new decimal(new int[] {
            1,
            0,
            0,
            0});
            this.numInputs.Name = "numInputs";
            this.numInputs.Size = new System.Drawing.Size(38, 20);
            this.numInputs.TabIndex = 3;
            this.numInputs.TabStop = false;
            this.numInputs.Value = new decimal(new int[] {
            4,
            0,
            0,
            0});
            // 
            // numLayers
            // 
            this.numLayers.Location = new System.Drawing.Point(101, 26);
            this.numLayers.Maximum = new decimal(new int[] {
            5,
            0,
            0,
            0});
            this.numLayers.Minimum = new decimal(new int[] {
            1,
            0,
            0,
            0});
            this.numLayers.Name = "numLayers";
            this.numLayers.Size = new System.Drawing.Size(38, 20);
            this.numLayers.TabIndex = 2;
            this.numLayers.TabStop = false;
            this.numLayers.Value = new decimal(new int[] {
            1,
            0,
            0,
            0});
            this.numLayers.ValueChanged += new System.EventHandler(this.numLayers_ValueChanged);
            // 
            // lblNumInputs
            // 
            this.lblNumInputs.AutoSize = true;
            this.lblNumInputs.Location = new System.Drawing.Point(6, 54);
            this.lblNumInputs.Name = "lblNumInputs";
            this.lblNumInputs.Size = new System.Drawing.Size(90, 13);
            this.lblNumInputs.TabIndex = 1;
            this.lblNumInputs.Text = "Number of inputs:";
            // 
            // lblNumNeurons
            // 
            this.lblNumNeurons.AutoSize = true;
            this.lblNumNeurons.Location = new System.Drawing.Point(6, 28);
            this.lblNumNeurons.Name = "lblNumNeurons";
            this.lblNumNeurons.Size = new System.Drawing.Size(89, 13);
            this.lblNumNeurons.TabIndex = 0;
            this.lblNumNeurons.Text = "Number of layers:";
            // 
            // grpBoxTeach
            // 
            this.grpBoxTeach.Controls.Add(this.btnResetWeights);
            this.grpBoxTeach.Controls.Add(this.progBarTeaching);
            this.grpBoxTeach.Controls.Add(this.btnTeachAbort);
            this.grpBoxTeach.Controls.Add(this.numLearningRate);
            this.grpBoxTeach.Controls.Add(this.label11);
            this.grpBoxTeach.Controls.Add(this.numIterations);
            this.grpBoxTeach.Controls.Add(this.label10);
            this.grpBoxTeach.Controls.Add(this.btnRefresh);
            this.grpBoxTeach.Controls.Add(this.btnSelect);
            this.grpBoxTeach.Controls.Add(this.cmbBoxTeachingFiles);
            this.grpBoxTeach.Controls.Add(this.labelFile);
            this.grpBoxTeach.Controls.Add(this.label4);
            this.grpBoxTeach.Controls.Add(this.txtBoxFolder);
            this.grpBoxTeach.Enabled = false;
            this.grpBoxTeach.Location = new System.Drawing.Point(12, 204);
            this.grpBoxTeach.Name = "grpBoxTeach";
            this.grpBoxTeach.Size = new System.Drawing.Size(415, 173);
            this.grpBoxTeach.TabIndex = 1;
            this.grpBoxTeach.TabStop = false;
            this.grpBoxTeach.Text = "Teach";
            // 
            // btnResetWeights
            // 
            this.btnResetWeights.Enabled = false;
            this.btnResetWeights.Location = new System.Drawing.Point(240, 76);
            this.btnResetWeights.Name = "btnResetWeights";
            this.btnResetWeights.Size = new System.Drawing.Size(169, 23);
            this.btnResetWeights.TabIndex = 20;
            this.btnResetWeights.Text = "Reset weights";
            this.btnResetWeights.UseVisualStyleBackColor = true;
            this.btnResetWeights.Click += new System.EventHandler(this.btnResetWeights_Click);
            // 
            // progBarTeaching
            // 
            this.progBarTeaching.Location = new System.Drawing.Point(9, 141);
            this.progBarTeaching.Name = "progBarTeaching";
            this.progBarTeaching.Size = new System.Drawing.Size(403, 23);
            this.progBarTeaching.TabIndex = 17;
            // 
            // btnTeachAbort
            // 
            this.btnTeachAbort.Location = new System.Drawing.Point(240, 107);
            this.btnTeachAbort.Name = "btnTeachAbort";
            this.btnTeachAbort.Size = new System.Drawing.Size(169, 28);
            this.btnTeachAbort.TabIndex = 17;
            this.btnTeachAbort.Text = "Teach";
            this.btnTeachAbort.UseVisualStyleBackColor = true;
            this.btnTeachAbort.Click += new System.EventHandler(this.btnTeachAbort_Click);
            // 
            // numLearningRate
            // 
            this.numLearningRate.DecimalPlaces = 3;
            this.numLearningRate.Increment = new decimal(new int[] {
            1,
            0,
            0,
            65536});
            this.numLearningRate.Location = new System.Drawing.Point(113, 113);
            this.numLearningRate.Maximum = new decimal(new int[] {
            2,
            0,
            0,
            0});
            this.numLearningRate.Minimum = new decimal(new int[] {
            1,
            0,
            0,
            196608});
            this.numLearningRate.Name = "numLearningRate";
            this.numLearningRate.Size = new System.Drawing.Size(103, 20);
            this.numLearningRate.TabIndex = 19;
            this.numLearningRate.TabStop = false;
            this.numLearningRate.Value = new decimal(new int[] {
            2,
            0,
            0,
            65536});
            // 
            // label11
            // 
            this.label11.AutoSize = true;
            this.label11.Location = new System.Drawing.Point(35, 115);
            this.label11.Name = "label11";
            this.label11.Size = new System.Drawing.Size(72, 13);
            this.label11.TabIndex = 18;
            this.label11.Text = "Learning rate:";
            // 
            // numIterations
            // 
            this.numIterations.Increment = new decimal(new int[] {
            1000,
            0,
            0,
            0});
            this.numIterations.Location = new System.Drawing.Point(113, 79);
            this.numIterations.Maximum = new decimal(new int[] {
            1000000000,
            0,
            0,
            0});
            this.numIterations.Minimum = new decimal(new int[] {
            1000,
            0,
            0,
            0});
            this.numIterations.Name = "numIterations";
            this.numIterations.Size = new System.Drawing.Size(103, 20);
            this.numIterations.TabIndex = 16;
            this.numIterations.TabStop = false;
            this.numIterations.ThousandsSeparator = true;
            this.numIterations.Value = new decimal(new int[] {
            100000,
            0,
            0,
            0});
            // 
            // label10
            // 
            this.label10.AutoSize = true;
            this.label10.Location = new System.Drawing.Point(6, 81);
            this.label10.Name = "label10";
            this.label10.Size = new System.Drawing.Size(101, 13);
            this.label10.TabIndex = 15;
            this.label10.Text = "Number of trainings:";
            // 
            // btnRefresh
            // 
            this.btnRefresh.Location = new System.Drawing.Point(240, 43);
            this.btnRefresh.Name = "btnRefresh";
            this.btnRefresh.Size = new System.Drawing.Size(88, 23);
            this.btnRefresh.TabIndex = 8;
            this.btnRefresh.Text = "Refresh";
            this.btnRefresh.UseVisualStyleBackColor = true;
            this.btnRefresh.Click += new System.EventHandler(this.btnRefresh_Click);
            // 
            // btnSelect
            // 
            this.btnSelect.Location = new System.Drawing.Point(334, 16);
            this.btnSelect.Name = "btnSelect";
            this.btnSelect.Size = new System.Drawing.Size(75, 23);
            this.btnSelect.TabIndex = 7;
            this.btnSelect.Text = "Select";
            this.btnSelect.UseVisualStyleBackColor = true;
            this.btnSelect.Click += new System.EventHandler(this.btnSelect_Click);
            // 
            // cmbBoxTeachingFiles
            // 
            this.cmbBoxTeachingFiles.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cmbBoxTeachingFiles.FormattingEnabled = true;
            this.cmbBoxTeachingFiles.Location = new System.Drawing.Point(51, 45);
            this.cmbBoxTeachingFiles.Name = "cmbBoxTeachingFiles";
            this.cmbBoxTeachingFiles.Size = new System.Drawing.Size(183, 21);
            this.cmbBoxTeachingFiles.TabIndex = 12;
            // 
            // labelFile
            // 
            this.labelFile.AutoSize = true;
            this.labelFile.Location = new System.Drawing.Point(19, 48);
            this.labelFile.Name = "labelFile";
            this.labelFile.Size = new System.Drawing.Size(26, 13);
            this.labelFile.TabIndex = 14;
            this.labelFile.Text = "File:";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(6, 21);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(39, 13);
            this.label4.TabIndex = 12;
            this.label4.Text = "Folder:";
            // 
            // txtBoxFolder
            // 
            this.txtBoxFolder.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.txtBoxFolder.Cursor = System.Windows.Forms.Cursors.IBeam;
            this.txtBoxFolder.Location = new System.Drawing.Point(51, 19);
            this.txtBoxFolder.Name = "txtBoxFolder";
            this.txtBoxFolder.ReadOnly = true;
            this.txtBoxFolder.Size = new System.Drawing.Size(277, 20);
            this.txtBoxFolder.TabIndex = 11;
            this.txtBoxFolder.TabStop = false;
            this.txtBoxFolder.WordWrap = false;
            // 
            // folderBrowser
            // 
            this.folderBrowser.ShowNewFolderButton = false;
            // 
            // statusStrip
            // 
            this.statusStrip.BackColor = System.Drawing.Color.LightBlue;
            this.statusStrip.GripMargin = new System.Windows.Forms.Padding(0);
            this.statusStrip.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.statusStripInfo});
            this.statusStrip.Location = new System.Drawing.Point(0, 477);
            this.statusStrip.Name = "statusStrip";
            this.statusStrip.Size = new System.Drawing.Size(666, 22);
            this.statusStrip.SizingGrip = false;
            this.statusStrip.Stretch = false;
            this.statusStrip.TabIndex = 12;
            // 
            // statusStripInfo
            // 
            this.statusStripInfo.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Text;
            this.statusStripInfo.Name = "statusStripInfo";
            this.statusStripInfo.Size = new System.Drawing.Size(0, 17);
            // 
            // grpBoxTest
            // 
            this.grpBoxTest.Controls.Add(this.btnTest);
            this.grpBoxTest.Controls.Add(this.cmbBoxTestingFiles);
            this.grpBoxTest.Controls.Add(this.label12);
            this.grpBoxTest.Enabled = false;
            this.grpBoxTest.Location = new System.Drawing.Point(12, 383);
            this.grpBoxTest.Name = "grpBoxTest";
            this.grpBoxTest.Size = new System.Drawing.Size(415, 56);
            this.grpBoxTest.TabIndex = 13;
            this.grpBoxTest.TabStop = false;
            this.grpBoxTest.Text = "Test";
            // 
            // btnTest
            // 
            this.btnTest.Location = new System.Drawing.Point(240, 14);
            this.btnTest.Name = "btnTest";
            this.btnTest.Size = new System.Drawing.Size(169, 29);
            this.btnTest.TabIndex = 20;
            this.btnTest.Text = "Test";
            this.btnTest.UseVisualStyleBackColor = true;
            this.btnTest.Click += new System.EventHandler(this.btnTest_Click);
            // 
            // cmbBoxTestingFiles
            // 
            this.cmbBoxTestingFiles.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cmbBoxTestingFiles.FormattingEnabled = true;
            this.cmbBoxTestingFiles.Location = new System.Drawing.Point(51, 19);
            this.cmbBoxTestingFiles.Name = "cmbBoxTestingFiles";
            this.cmbBoxTestingFiles.Size = new System.Drawing.Size(183, 21);
            this.cmbBoxTestingFiles.TabIndex = 21;
            // 
            // label12
            // 
            this.label12.AutoSize = true;
            this.label12.Location = new System.Drawing.Point(19, 22);
            this.label12.Name = "label12";
            this.label12.Size = new System.Drawing.Size(26, 13);
            this.label12.TabIndex = 22;
            this.label12.Text = "File:";
            // 
            // label13
            // 
            this.label13.AutoSize = true;
            this.label13.BackColor = System.Drawing.Color.Transparent;
            this.label13.Location = new System.Drawing.Point(494, 442);
            this.label13.Margin = new System.Windows.Forms.Padding(0);
            this.label13.Name = "label13";
            this.label13.Size = new System.Drawing.Size(158, 13);
            this.label13.TabIndex = 14;
            this.label13.Text = "Author: Łukasz Rabiec, 2016 ©";
            // 
            // groupBox3
            // 
            this.groupBox3.Controls.Add(this.label2);
            this.groupBox3.Controls.Add(this.txtBoxExpected);
            this.groupBox3.Controls.Add(this.label1);
            this.groupBox3.Controls.Add(this.txtBoxCalculated);
            this.groupBox3.Location = new System.Drawing.Point(433, 12);
            this.groupBox3.Name = "groupBox3";
            this.groupBox3.Size = new System.Drawing.Size(225, 427);
            this.groupBox3.TabIndex = 15;
            this.groupBox3.TabStop = false;
            this.groupBox3.Text = "Results";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(66, 16);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(60, 13);
            this.label2.TabIndex = 2;
            this.label2.Text = "Calculated:";
            // 
            // txtBoxExpected
            // 
            this.txtBoxExpected.Location = new System.Drawing.Point(6, 32);
            this.txtBoxExpected.Multiline = true;
            this.txtBoxExpected.Name = "txtBoxExpected";
            this.txtBoxExpected.ReadOnly = true;
            this.txtBoxExpected.ScrollBars = System.Windows.Forms.ScrollBars.Both;
            this.txtBoxExpected.Size = new System.Drawing.Size(57, 389);
            this.txtBoxExpected.TabIndex = 1;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(4, 16);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(55, 13);
            this.label1.TabIndex = 1;
            this.label1.Text = "Expected:";
            // 
            // txtBoxCalculated
            // 
            this.txtBoxCalculated.Location = new System.Drawing.Point(69, 32);
            this.txtBoxCalculated.Multiline = true;
            this.txtBoxCalculated.Name = "txtBoxCalculated";
            this.txtBoxCalculated.ReadOnly = true;
            this.txtBoxCalculated.ScrollBars = System.Windows.Forms.ScrollBars.Both;
            this.txtBoxCalculated.Size = new System.Drawing.Size(150, 389);
            this.txtBoxCalculated.TabIndex = 0;
            // 
            // bgWorker
            // 
            this.bgWorker.WorkerReportsProgress = true;
            this.bgWorker.WorkerSupportsCancellation = true;
            this.bgWorker.DoWork += new System.ComponentModel.DoWorkEventHandler(this.bgWorker_DoWork);
            // 
            // MainForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(666, 499);
            this.Controls.Add(this.groupBox3);
            this.Controls.Add(this.label13);
            this.Controls.Add(this.grpBoxTest);
            this.Controls.Add(this.statusStrip);
            this.Controls.Add(this.grpBoxTeach);
            this.Controls.Add(this.grpBoxConfiguration);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.MaximizeBox = false;
            this.Name = "MainForm";
            this.Text = "Multi Layer Perceptron";
            this.grpBoxConfiguration.ResumeLayout(false);
            this.grpBoxConfiguration.PerformLayout();
            this.grpBoxLayers.ResumeLayout(false);
            this.grpBoxLayers.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.numLayer5)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.numLayer1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.numLayer2)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.numLayer3)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.numLayer4)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.numInputs)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.numLayers)).EndInit();
            this.grpBoxTeach.ResumeLayout(false);
            this.grpBoxTeach.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.numLearningRate)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.numIterations)).EndInit();
            this.statusStrip.ResumeLayout(false);
            this.statusStrip.PerformLayout();
            this.grpBoxTest.ResumeLayout(false);
            this.grpBoxTest.PerformLayout();
            this.groupBox3.ResumeLayout(false);
            this.groupBox3.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.GroupBox grpBoxConfiguration;
        private System.Windows.Forms.NumericUpDown numLayer1;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Button btnCreateBack;
        private System.Windows.Forms.ComboBox cmbBoxActivationFunc;
        private System.Windows.Forms.Label lblActivationFunc;
        private System.Windows.Forms.NumericUpDown numInputs;
        private System.Windows.Forms.NumericUpDown numLayers;
        private System.Windows.Forms.Label lblNumInputs;
        private System.Windows.Forms.Label lblNumNeurons;
        private System.Windows.Forms.GroupBox grpBoxLayers;
        private System.Windows.Forms.NumericUpDown numLayer5;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.Label label9;
        private System.Windows.Forms.NumericUpDown numLayer2;
        private System.Windows.Forms.NumericUpDown numLayer3;
        private System.Windows.Forms.NumericUpDown numLayer4;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.GroupBox grpBoxTeach;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.TextBox txtBoxFolder;
        private System.Windows.Forms.FolderBrowserDialog folderBrowser;
        private System.Windows.Forms.Button btnSelect;
        private System.Windows.Forms.Button btnRefresh;
        private System.Windows.Forms.ComboBox cmbBoxTeachingFiles;
        private System.Windows.Forms.Label labelFile;
        private System.Windows.Forms.StatusStrip statusStrip;
        private System.Windows.Forms.ToolStripStatusLabel statusStripInfo;
        private System.Windows.Forms.NumericUpDown numIterations;
        private System.Windows.Forms.Label label10;
        private System.Windows.Forms.NumericUpDown numLearningRate;
        private System.Windows.Forms.Label label11;
        private System.Windows.Forms.Button btnTeachAbort;
        private System.Windows.Forms.ProgressBar progBarTeaching;
        private System.Windows.Forms.GroupBox grpBoxTest;
        private System.Windows.Forms.Button btnTest;
        private System.Windows.Forms.ComboBox cmbBoxTestingFiles;
        private System.Windows.Forms.Label label12;
        private System.Windows.Forms.Label label13;
        private System.Windows.Forms.GroupBox groupBox3;
        private System.Windows.Forms.TextBox txtBoxCalculated;
        private System.ComponentModel.BackgroundWorker bgWorker;
        private System.Windows.Forms.Button btnResetWeights;
        private System.Windows.Forms.TextBox txtBoxExpected;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label1;
    }
}

