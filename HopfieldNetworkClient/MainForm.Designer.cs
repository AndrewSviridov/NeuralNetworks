#region License
/*
 * This file is subject to the terms and conditions defined in
 * file 'LICENSE.txt', which is part of this source code package.
 */
#endregion

namespace HopfieldNetworkClient
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
            this.folderBrowser = new System.Windows.Forms.FolderBrowserDialog();
            this.label1 = new System.Windows.Forms.Label();
            this.groupBoxTeach = new System.Windows.Forms.GroupBox();
            this.labelPlease = new System.Windows.Forms.Label();
            this.btnTeach = new System.Windows.Forms.Button();
            this.btnRefresh = new System.Windows.Forms.Button();
            this.cmbBoxFiles = new System.Windows.Forms.ComboBox();
            this.labelFile = new System.Windows.Forms.Label();
            this.btnSelect = new System.Windows.Forms.Button();
            this.labelFolder = new System.Windows.Forms.Label();
            this.txtBoxFolder = new System.Windows.Forms.TextBox();
            this.groupBoxTest = new System.Windows.Forms.GroupBox();
            this.txtBoxOutputVector = new System.Windows.Forms.TextBox();
            this.labelOutputVector = new System.Windows.Forms.Label();
            this.btnTest = new System.Windows.Forms.Button();
            this.txtBoxPatternVector = new System.Windows.Forms.TextBox();
            this.labelPatternVector = new System.Windows.Forms.Label();
            this.groupBoxPattern = new System.Windows.Forms.GroupBox();
            this.btnClear = new System.Windows.Forms.Button();
            this.chBox15 = new System.Windows.Forms.CheckBox();
            this.chBox14 = new System.Windows.Forms.CheckBox();
            this.chBox13 = new System.Windows.Forms.CheckBox();
            this.chBox12 = new System.Windows.Forms.CheckBox();
            this.chBox11 = new System.Windows.Forms.CheckBox();
            this.chBox10 = new System.Windows.Forms.CheckBox();
            this.chBox09 = new System.Windows.Forms.CheckBox();
            this.chBox08 = new System.Windows.Forms.CheckBox();
            this.chBox07 = new System.Windows.Forms.CheckBox();
            this.chBox06 = new System.Windows.Forms.CheckBox();
            this.chBox05 = new System.Windows.Forms.CheckBox();
            this.chBox04 = new System.Windows.Forms.CheckBox();
            this.chBox03 = new System.Windows.Forms.CheckBox();
            this.chBox02 = new System.Windows.Forms.CheckBox();
            this.chBox01 = new System.Windows.Forms.CheckBox();
            this.statusStrip = new System.Windows.Forms.StatusStrip();
            this.statusStripInfo = new System.Windows.Forms.ToolStripStatusLabel();
            this.groupBoxTeach.SuspendLayout();
            this.groupBoxTest.SuspendLayout();
            this.groupBoxPattern.SuspendLayout();
            this.statusStrip.SuspendLayout();
            this.SuspendLayout();
            // 
            // folderBrowser
            // 
            this.folderBrowser.ShowNewFolderButton = false;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.BackColor = System.Drawing.Color.Transparent;
            this.label1.Location = new System.Drawing.Point(375, 287);
            this.label1.Margin = new System.Windows.Forms.Padding(0);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(158, 13);
            this.label1.TabIndex = 0;
            this.label1.Text = "Author: Łukasz Rabiec, 2016 ©";
            // 
            // groupBoxTeach
            // 
            this.groupBoxTeach.Controls.Add(this.labelPlease);
            this.groupBoxTeach.Controls.Add(this.btnTeach);
            this.groupBoxTeach.Controls.Add(this.btnRefresh);
            this.groupBoxTeach.Controls.Add(this.cmbBoxFiles);
            this.groupBoxTeach.Controls.Add(this.labelFile);
            this.groupBoxTeach.Controls.Add(this.btnSelect);
            this.groupBoxTeach.Controls.Add(this.labelFolder);
            this.groupBoxTeach.Controls.Add(this.txtBoxFolder);
            this.groupBoxTeach.Location = new System.Drawing.Point(12, 12);
            this.groupBoxTeach.Name = "groupBoxTeach";
            this.groupBoxTeach.Size = new System.Drawing.Size(518, 102);
            this.groupBoxTeach.TabIndex = 10;
            this.groupBoxTeach.TabStop = false;
            this.groupBoxTeach.Text = "Teach";
            // 
            // labelPlease
            // 
            this.labelPlease.AutoSize = true;
            this.labelPlease.Location = new System.Drawing.Point(65, 79);
            this.labelPlease.Name = "labelPlease";
            this.labelPlease.Size = new System.Drawing.Size(305, 13);
            this.labelPlease.TabIndex = 12;
            this.labelPlease.Text = "(Please select file with only three vectors with space separator.)";
            // 
            // btnTeach
            // 
            this.btnTeach.Location = new System.Drawing.Point(399, 74);
            this.btnTeach.Name = "btnTeach";
            this.btnTeach.Size = new System.Drawing.Size(113, 23);
            this.btnTeach.TabIndex = 4;
            this.btnTeach.Text = "Teach";
            this.btnTeach.UseVisualStyleBackColor = true;
            this.btnTeach.Click += new System.EventHandler(this.buttonTeach_Click);
            // 
            // btnRefresh
            // 
            this.btnRefresh.Location = new System.Drawing.Point(250, 47);
            this.btnRefresh.Name = "btnRefresh";
            this.btnRefresh.Size = new System.Drawing.Size(75, 23);
            this.btnRefresh.TabIndex = 3;
            this.btnRefresh.Text = "Refresh";
            this.btnRefresh.UseVisualStyleBackColor = true;
            this.btnRefresh.Click += new System.EventHandler(this.buttonRefresh_Click);
            // 
            // cmbBoxFiles
            // 
            this.cmbBoxFiles.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cmbBoxFiles.FormattingEnabled = true;
            this.cmbBoxFiles.Location = new System.Drawing.Point(68, 49);
            this.cmbBoxFiles.Name = "cmbBoxFiles";
            this.cmbBoxFiles.Size = new System.Drawing.Size(176, 21);
            this.cmbBoxFiles.TabIndex = 2;
            // 
            // labelFile
            // 
            this.labelFile.AutoSize = true;
            this.labelFile.Location = new System.Drawing.Point(36, 52);
            this.labelFile.Name = "labelFile";
            this.labelFile.Size = new System.Drawing.Size(26, 13);
            this.labelFile.TabIndex = 11;
            this.labelFile.Text = "File:";
            // 
            // btnSelect
            // 
            this.btnSelect.Location = new System.Drawing.Point(437, 20);
            this.btnSelect.Name = "btnSelect";
            this.btnSelect.Size = new System.Drawing.Size(75, 23);
            this.btnSelect.TabIndex = 1;
            this.btnSelect.Text = "Select";
            this.btnSelect.UseVisualStyleBackColor = true;
            this.btnSelect.Click += new System.EventHandler(this.buttonSelect_Click);
            // 
            // labelFolder
            // 
            this.labelFolder.AutoSize = true;
            this.labelFolder.Location = new System.Drawing.Point(23, 25);
            this.labelFolder.Name = "labelFolder";
            this.labelFolder.Size = new System.Drawing.Size(39, 13);
            this.labelFolder.TabIndex = 0;
            this.labelFolder.Text = "Folder:";
            // 
            // txtBoxFolder
            // 
            this.txtBoxFolder.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.txtBoxFolder.Cursor = System.Windows.Forms.Cursors.IBeam;
            this.txtBoxFolder.Location = new System.Drawing.Point(68, 22);
            this.txtBoxFolder.Name = "txtBoxFolder";
            this.txtBoxFolder.ReadOnly = true;
            this.txtBoxFolder.Size = new System.Drawing.Size(363, 20);
            this.txtBoxFolder.TabIndex = 10;
            this.txtBoxFolder.TabStop = false;
            this.txtBoxFolder.WordWrap = false;
            // 
            // groupBoxTest
            // 
            this.groupBoxTest.Controls.Add(this.txtBoxOutputVector);
            this.groupBoxTest.Controls.Add(this.labelOutputVector);
            this.groupBoxTest.Controls.Add(this.btnTest);
            this.groupBoxTest.Controls.Add(this.txtBoxPatternVector);
            this.groupBoxTest.Controls.Add(this.labelPatternVector);
            this.groupBoxTest.Controls.Add(this.groupBoxPattern);
            this.groupBoxTest.Location = new System.Drawing.Point(13, 120);
            this.groupBoxTest.Name = "groupBoxTest";
            this.groupBoxTest.Size = new System.Drawing.Size(517, 164);
            this.groupBoxTest.TabIndex = 0;
            this.groupBoxTest.TabStop = false;
            this.groupBoxTest.Text = "Test";
            // 
            // txtBoxOutputVector
            // 
            this.txtBoxOutputVector.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.txtBoxOutputVector.Location = new System.Drawing.Point(189, 94);
            this.txtBoxOutputVector.Name = "txtBoxOutputVector";
            this.txtBoxOutputVector.ReadOnly = true;
            this.txtBoxOutputVector.Size = new System.Drawing.Size(241, 20);
            this.txtBoxOutputVector.TabIndex = 7;
            this.txtBoxOutputVector.TabStop = false;
            // 
            // labelOutputVector
            // 
            this.labelOutputVector.AutoSize = true;
            this.labelOutputVector.Location = new System.Drawing.Point(106, 96);
            this.labelOutputVector.Name = "labelOutputVector";
            this.labelOutputVector.Size = new System.Drawing.Size(75, 13);
            this.labelOutputVector.TabIndex = 6;
            this.labelOutputVector.Text = "Output vector:";
            // 
            // btnTest
            // 
            this.btnTest.Location = new System.Drawing.Point(436, 44);
            this.btnTest.Name = "btnTest";
            this.btnTest.Size = new System.Drawing.Size(75, 23);
            this.btnTest.TabIndex = 6;
            this.btnTest.Text = "Test";
            this.btnTest.UseVisualStyleBackColor = true;
            this.btnTest.Click += new System.EventHandler(this.buttonTest_Click);
            // 
            // txtBoxPatternVector
            // 
            this.txtBoxPatternVector.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.txtBoxPatternVector.Location = new System.Drawing.Point(189, 47);
            this.txtBoxPatternVector.Name = "txtBoxPatternVector";
            this.txtBoxPatternVector.ReadOnly = true;
            this.txtBoxPatternVector.Size = new System.Drawing.Size(241, 20);
            this.txtBoxPatternVector.TabIndex = 40;
            this.txtBoxPatternVector.TabStop = false;
            // 
            // labelPatternVector
            // 
            this.labelPatternVector.AutoSize = true;
            this.labelPatternVector.Location = new System.Drawing.Point(106, 49);
            this.labelPatternVector.Name = "labelPatternVector";
            this.labelPatternVector.Size = new System.Drawing.Size(77, 13);
            this.labelPatternVector.TabIndex = 1;
            this.labelPatternVector.Text = "Pattern vector:";
            // 
            // groupBoxPattern
            // 
            this.groupBoxPattern.Controls.Add(this.btnClear);
            this.groupBoxPattern.Controls.Add(this.chBox15);
            this.groupBoxPattern.Controls.Add(this.chBox14);
            this.groupBoxPattern.Controls.Add(this.chBox13);
            this.groupBoxPattern.Controls.Add(this.chBox12);
            this.groupBoxPattern.Controls.Add(this.chBox11);
            this.groupBoxPattern.Controls.Add(this.chBox10);
            this.groupBoxPattern.Controls.Add(this.chBox09);
            this.groupBoxPattern.Controls.Add(this.chBox08);
            this.groupBoxPattern.Controls.Add(this.chBox07);
            this.groupBoxPattern.Controls.Add(this.chBox06);
            this.groupBoxPattern.Controls.Add(this.chBox05);
            this.groupBoxPattern.Controls.Add(this.chBox04);
            this.groupBoxPattern.Controls.Add(this.chBox03);
            this.groupBoxPattern.Controls.Add(this.chBox02);
            this.groupBoxPattern.Controls.Add(this.chBox01);
            this.groupBoxPattern.Location = new System.Drawing.Point(22, 19);
            this.groupBoxPattern.Name = "groupBoxPattern";
            this.groupBoxPattern.Size = new System.Drawing.Size(66, 140);
            this.groupBoxPattern.TabIndex = 0;
            this.groupBoxPattern.TabStop = false;
            this.groupBoxPattern.Text = "Pattern:";
            // 
            // btnClear
            // 
            this.btnClear.Location = new System.Drawing.Point(6, 111);
            this.btnClear.Name = "btnClear";
            this.btnClear.Size = new System.Drawing.Size(54, 23);
            this.btnClear.TabIndex = 5;
            this.btnClear.Text = "Clear";
            this.btnClear.UseVisualStyleBackColor = true;
            this.btnClear.Click += new System.EventHandler(this.buttonClear_Click);
            // 
            // chBox15
            // 
            this.chBox15.AutoSize = true;
            this.chBox15.Location = new System.Drawing.Point(45, 92);
            this.chBox15.Margin = new System.Windows.Forms.Padding(2);
            this.chBox15.Name = "chBox15";
            this.chBox15.Size = new System.Drawing.Size(15, 14);
            this.chBox15.TabIndex = 12;
            this.chBox15.TabStop = false;
            this.chBox15.UseVisualStyleBackColor = false;
            this.chBox15.CheckedChanged += new System.EventHandler(this.chBox_CheckedChanged);
            // 
            // chBox14
            // 
            this.chBox14.AutoSize = true;
            this.chBox14.Location = new System.Drawing.Point(26, 92);
            this.chBox14.Margin = new System.Windows.Forms.Padding(2);
            this.chBox14.Name = "chBox14";
            this.chBox14.Size = new System.Drawing.Size(15, 14);
            this.chBox14.TabIndex = 3;
            this.chBox14.TabStop = false;
            this.chBox14.UseVisualStyleBackColor = false;
            this.chBox14.CheckedChanged += new System.EventHandler(this.chBox_CheckedChanged);
            // 
            // chBox13
            // 
            this.chBox13.AutoSize = true;
            this.chBox13.Location = new System.Drawing.Point(7, 92);
            this.chBox13.Margin = new System.Windows.Forms.Padding(2);
            this.chBox13.Name = "chBox13";
            this.chBox13.Size = new System.Drawing.Size(15, 14);
            this.chBox13.TabIndex = 11;
            this.chBox13.TabStop = false;
            this.chBox13.UseVisualStyleBackColor = false;
            this.chBox13.CheckedChanged += new System.EventHandler(this.chBox_CheckedChanged);
            // 
            // chBox12
            // 
            this.chBox12.AutoSize = true;
            this.chBox12.Location = new System.Drawing.Point(45, 74);
            this.chBox12.Margin = new System.Windows.Forms.Padding(2);
            this.chBox12.Name = "chBox12";
            this.chBox12.Size = new System.Drawing.Size(15, 14);
            this.chBox12.TabIndex = 10;
            this.chBox12.TabStop = false;
            this.chBox12.UseVisualStyleBackColor = false;
            this.chBox12.CheckedChanged += new System.EventHandler(this.chBox_CheckedChanged);
            // 
            // chBox11
            // 
            this.chBox11.AutoSize = true;
            this.chBox11.Location = new System.Drawing.Point(26, 74);
            this.chBox11.Margin = new System.Windows.Forms.Padding(2);
            this.chBox11.Name = "chBox11";
            this.chBox11.Size = new System.Drawing.Size(15, 14);
            this.chBox11.TabIndex = 9;
            this.chBox11.TabStop = false;
            this.chBox11.UseVisualStyleBackColor = false;
            this.chBox11.CheckedChanged += new System.EventHandler(this.chBox_CheckedChanged);
            // 
            // chBox10
            // 
            this.chBox10.AutoSize = true;
            this.chBox10.Location = new System.Drawing.Point(7, 74);
            this.chBox10.Margin = new System.Windows.Forms.Padding(2);
            this.chBox10.Name = "chBox10";
            this.chBox10.Size = new System.Drawing.Size(15, 14);
            this.chBox10.TabIndex = 3;
            this.chBox10.TabStop = false;
            this.chBox10.UseVisualStyleBackColor = false;
            this.chBox10.CheckedChanged += new System.EventHandler(this.chBox_CheckedChanged);
            // 
            // chBox09
            // 
            this.chBox09.AutoSize = true;
            this.chBox09.Location = new System.Drawing.Point(45, 56);
            this.chBox09.Margin = new System.Windows.Forms.Padding(2);
            this.chBox09.Name = "chBox09";
            this.chBox09.Size = new System.Drawing.Size(15, 14);
            this.chBox09.TabIndex = 8;
            this.chBox09.TabStop = false;
            this.chBox09.UseVisualStyleBackColor = false;
            this.chBox09.CheckedChanged += new System.EventHandler(this.chBox_CheckedChanged);
            // 
            // chBox08
            // 
            this.chBox08.AutoSize = true;
            this.chBox08.Location = new System.Drawing.Point(26, 56);
            this.chBox08.Margin = new System.Windows.Forms.Padding(2);
            this.chBox08.Name = "chBox08";
            this.chBox08.Size = new System.Drawing.Size(15, 14);
            this.chBox08.TabIndex = 7;
            this.chBox08.TabStop = false;
            this.chBox08.UseVisualStyleBackColor = false;
            this.chBox08.CheckedChanged += new System.EventHandler(this.chBox_CheckedChanged);
            // 
            // chBox07
            // 
            this.chBox07.AutoSize = true;
            this.chBox07.Location = new System.Drawing.Point(7, 56);
            this.chBox07.Margin = new System.Windows.Forms.Padding(2);
            this.chBox07.Name = "chBox07";
            this.chBox07.Size = new System.Drawing.Size(15, 14);
            this.chBox07.TabIndex = 6;
            this.chBox07.TabStop = false;
            this.chBox07.UseVisualStyleBackColor = false;
            this.chBox07.CheckedChanged += new System.EventHandler(this.chBox_CheckedChanged);
            // 
            // chBox06
            // 
            this.chBox06.AutoSize = true;
            this.chBox06.Location = new System.Drawing.Point(45, 38);
            this.chBox06.Margin = new System.Windows.Forms.Padding(2);
            this.chBox06.Name = "chBox06";
            this.chBox06.Size = new System.Drawing.Size(15, 14);
            this.chBox06.TabIndex = 5;
            this.chBox06.TabStop = false;
            this.chBox06.UseVisualStyleBackColor = false;
            this.chBox06.CheckedChanged += new System.EventHandler(this.chBox_CheckedChanged);
            // 
            // chBox05
            // 
            this.chBox05.AutoSize = true;
            this.chBox05.Location = new System.Drawing.Point(26, 38);
            this.chBox05.Margin = new System.Windows.Forms.Padding(2);
            this.chBox05.Name = "chBox05";
            this.chBox05.Size = new System.Drawing.Size(15, 14);
            this.chBox05.TabIndex = 4;
            this.chBox05.TabStop = false;
            this.chBox05.UseVisualStyleBackColor = false;
            this.chBox05.CheckedChanged += new System.EventHandler(this.chBox_CheckedChanged);
            // 
            // chBox04
            // 
            this.chBox04.AutoSize = true;
            this.chBox04.Location = new System.Drawing.Point(7, 38);
            this.chBox04.Margin = new System.Windows.Forms.Padding(2);
            this.chBox04.Name = "chBox04";
            this.chBox04.Size = new System.Drawing.Size(15, 14);
            this.chBox04.TabIndex = 3;
            this.chBox04.TabStop = false;
            this.chBox04.UseVisualStyleBackColor = false;
            this.chBox04.CheckedChanged += new System.EventHandler(this.chBox_CheckedChanged);
            // 
            // chBox03
            // 
            this.chBox03.AutoSize = true;
            this.chBox03.Location = new System.Drawing.Point(45, 20);
            this.chBox03.Margin = new System.Windows.Forms.Padding(2);
            this.chBox03.Name = "chBox03";
            this.chBox03.Size = new System.Drawing.Size(15, 14);
            this.chBox03.TabIndex = 2;
            this.chBox03.TabStop = false;
            this.chBox03.UseVisualStyleBackColor = false;
            this.chBox03.CheckedChanged += new System.EventHandler(this.chBox_CheckedChanged);
            // 
            // chBox02
            // 
            this.chBox02.AutoSize = true;
            this.chBox02.Location = new System.Drawing.Point(26, 20);
            this.chBox02.Margin = new System.Windows.Forms.Padding(2);
            this.chBox02.Name = "chBox02";
            this.chBox02.Size = new System.Drawing.Size(15, 14);
            this.chBox02.TabIndex = 1;
            this.chBox02.TabStop = false;
            this.chBox02.UseVisualStyleBackColor = false;
            this.chBox02.CheckedChanged += new System.EventHandler(this.chBox_CheckedChanged);
            // 
            // chBox01
            // 
            this.chBox01.AutoSize = true;
            this.chBox01.Location = new System.Drawing.Point(7, 20);
            this.chBox01.Margin = new System.Windows.Forms.Padding(2);
            this.chBox01.Name = "chBox01";
            this.chBox01.Size = new System.Drawing.Size(15, 14);
            this.chBox01.TabIndex = 0;
            this.chBox01.TabStop = false;
            this.chBox01.UseVisualStyleBackColor = false;
            this.chBox01.CheckedChanged += new System.EventHandler(this.chBox_CheckedChanged);
            // 
            // statusStrip
            // 
            this.statusStrip.BackColor = System.Drawing.Color.LightBlue;
            this.statusStrip.GripMargin = new System.Windows.Forms.Padding(0);
            this.statusStrip.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.statusStripInfo});
            this.statusStrip.Location = new System.Drawing.Point(0, 316);
            this.statusStrip.Name = "statusStrip";
            this.statusStrip.Size = new System.Drawing.Size(542, 22);
            this.statusStrip.SizingGrip = false;
            this.statusStrip.TabIndex = 11;
            // 
            // statusStripInfo
            // 
            this.statusStripInfo.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Text;
            this.statusStripInfo.Name = "statusStripInfo";
            this.statusStripInfo.Size = new System.Drawing.Size(0, 17);
            // 
            // MainForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(542, 338);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.groupBoxTest);
            this.Controls.Add(this.groupBoxTeach);
            this.Controls.Add(this.statusStrip);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedDialog;
            this.Location = new System.Drawing.Point(2, 2);
            this.MaximizeBox = false;
            this.Name = "MainForm";
            this.Text = "Hopfield Network";
            this.groupBoxTeach.ResumeLayout(false);
            this.groupBoxTeach.PerformLayout();
            this.groupBoxTest.ResumeLayout(false);
            this.groupBoxTest.PerformLayout();
            this.groupBoxPattern.ResumeLayout(false);
            this.groupBoxPattern.PerformLayout();
            this.statusStrip.ResumeLayout(false);
            this.statusStrip.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.FolderBrowserDialog folderBrowser;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.GroupBox groupBoxTeach;
        private System.Windows.Forms.Button btnSelect;
        private System.Windows.Forms.Label labelFolder;
        private System.Windows.Forms.TextBox txtBoxFolder;
        private System.Windows.Forms.GroupBox groupBoxTest;
        private System.Windows.Forms.Button btnTeach;
        private System.Windows.Forms.Button btnRefresh;
        private System.Windows.Forms.ComboBox cmbBoxFiles;
        private System.Windows.Forms.Label labelFile;
        private System.Windows.Forms.GroupBox groupBoxPattern;
        private System.Windows.Forms.CheckBox chBox06;
        private System.Windows.Forms.CheckBox chBox05;
        private System.Windows.Forms.CheckBox chBox04;
        private System.Windows.Forms.CheckBox chBox03;
        private System.Windows.Forms.CheckBox chBox02;
        private System.Windows.Forms.CheckBox chBox01;
        private System.Windows.Forms.CheckBox chBox15;
        private System.Windows.Forms.CheckBox chBox14;
        private System.Windows.Forms.CheckBox chBox13;
        private System.Windows.Forms.CheckBox chBox12;
        private System.Windows.Forms.CheckBox chBox11;
        private System.Windows.Forms.CheckBox chBox10;
        private System.Windows.Forms.CheckBox chBox09;
        private System.Windows.Forms.CheckBox chBox08;
        private System.Windows.Forms.CheckBox chBox07;
        private System.Windows.Forms.StatusStrip statusStrip;
        private System.Windows.Forms.ToolStripStatusLabel statusStripInfo;
        private System.Windows.Forms.Label labelPatternVector;
        private System.Windows.Forms.TextBox txtBoxPatternVector;
        private System.Windows.Forms.TextBox txtBoxOutputVector;
        private System.Windows.Forms.Label labelOutputVector;
        private System.Windows.Forms.Button btnTest;
        private System.Windows.Forms.Button btnClear;
        private System.Windows.Forms.Label labelPlease;
    }
}

