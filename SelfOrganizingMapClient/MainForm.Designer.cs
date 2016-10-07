#region License
/*
 * This file is subject to the terms and conditions defined in
 * file 'LICENSE.txt', which is part of this source code package.
 */
#endregion

namespace SelfOrganizingMapClient
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
            this.components = new System.ComponentModel.Container();
            this.picBoxMap = new System.Windows.Forms.PictureBox();
            this.labelAuthor = new System.Windows.Forms.Label();
            this.timer = new System.Windows.Forms.Timer(this.components);
            this.btnStartPause = new System.Windows.Forms.Button();
            this.numNeurons = new System.Windows.Forms.NumericUpDown();
            this.labelNeurons = new System.Windows.Forms.Label();
            this.btnGenerate = new System.Windows.Forms.Button();
            this.btnStop = new System.Windows.Forms.Button();
            this.labelIteration = new System.Windows.Forms.Label();
            this.lblIterationInfo = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.numNeighborRadius = new System.Windows.Forms.NumericUpDown();
            this.numRadiusDecay = new System.Windows.Forms.NumericUpDown();
            this.label2 = new System.Windows.Forms.Label();
            this.numShiftFactor = new System.Windows.Forms.NumericUpDown();
            this.label3 = new System.Windows.Forms.Label();
            this.numShiftDecayRate = new System.Windows.Forms.NumericUpDown();
            this.label4 = new System.Windows.Forms.Label();
            this.grpBoxConfig = new System.Windows.Forms.GroupBox();
            this.numDrawFreq = new System.Windows.Forms.NumericUpDown();
            this.label5 = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.picBoxMap)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.numNeurons)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.numNeighborRadius)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.numRadiusDecay)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.numShiftFactor)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.numShiftDecayRate)).BeginInit();
            this.grpBoxConfig.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.numDrawFreq)).BeginInit();
            this.SuspendLayout();
            // 
            // picBoxMap
            // 
            this.picBoxMap.BackColor = System.Drawing.Color.White;
            this.picBoxMap.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.picBoxMap.Location = new System.Drawing.Point(12, 12);
            this.picBoxMap.Name = "picBoxMap";
            this.picBoxMap.Size = new System.Drawing.Size(500, 500);
            this.picBoxMap.TabIndex = 0;
            this.picBoxMap.TabStop = false;
            // 
            // labelAuthor
            // 
            this.labelAuthor.AutoSize = true;
            this.labelAuthor.Location = new System.Drawing.Point(574, 499);
            this.labelAuthor.Name = "labelAuthor";
            this.labelAuthor.Size = new System.Drawing.Size(158, 13);
            this.labelAuthor.TabIndex = 1;
            this.labelAuthor.Text = "Author: Łukasz Rabiec, 2016 ©";
            // 
            // timer
            // 
            this.timer.Interval = 1;
            this.timer.Tick += new System.EventHandler(this.timer_Tick);
            // 
            // btnStartPause
            // 
            this.btnStartPause.Enabled = false;
            this.btnStartPause.Location = new System.Drawing.Point(518, 281);
            this.btnStartPause.Name = "btnStartPause";
            this.btnStartPause.Size = new System.Drawing.Size(99, 27);
            this.btnStartPause.TabIndex = 1;
            this.btnStartPause.Text = "Start";
            this.btnStartPause.UseVisualStyleBackColor = true;
            this.btnStartPause.Click += new System.EventHandler(this.buttonStartPause_Click);
            // 
            // numNeurons
            // 
            this.numNeurons.Increment = new decimal(new int[] {
            10,
            0,
            0,
            0});
            this.numNeurons.Location = new System.Drawing.Point(135, 23);
            this.numNeurons.Maximum = new decimal(new int[] {
            1000,
            0,
            0,
            0});
            this.numNeurons.Minimum = new decimal(new int[] {
            1,
            0,
            0,
            0});
            this.numNeurons.Name = "numNeurons";
            this.numNeurons.Size = new System.Drawing.Size(59, 20);
            this.numNeurons.TabIndex = 0;
            this.numNeurons.TabStop = false;
            this.numNeurons.Value = new decimal(new int[] {
            100,
            0,
            0,
            0});
            // 
            // labelNeurons
            // 
            this.labelNeurons.AutoSize = true;
            this.labelNeurons.Location = new System.Drawing.Point(15, 25);
            this.labelNeurons.Name = "labelNeurons";
            this.labelNeurons.Size = new System.Drawing.Size(100, 13);
            this.labelNeurons.TabIndex = 3;
            this.labelNeurons.Text = "Number of neurons:";
            // 
            // btnGenerate
            // 
            this.btnGenerate.Location = new System.Drawing.Point(518, 248);
            this.btnGenerate.Name = "btnGenerate";
            this.btnGenerate.Size = new System.Drawing.Size(214, 27);
            this.btnGenerate.TabIndex = 0;
            this.btnGenerate.Text = "Generate";
            this.btnGenerate.UseVisualStyleBackColor = true;
            this.btnGenerate.Click += new System.EventHandler(this.buttonGenerate_Click);
            // 
            // btnStop
            // 
            this.btnStop.Enabled = false;
            this.btnStop.Location = new System.Drawing.Point(633, 281);
            this.btnStop.Name = "btnStop";
            this.btnStop.Size = new System.Drawing.Size(99, 27);
            this.btnStop.TabIndex = 2;
            this.btnStop.Text = "Stop";
            this.btnStop.UseVisualStyleBackColor = true;
            this.btnStop.Click += new System.EventHandler(this.buttonStop_Click);
            // 
            // labelIteration
            // 
            this.labelIteration.AutoSize = true;
            this.labelIteration.Location = new System.Drawing.Point(518, 220);
            this.labelIteration.Name = "labelIteration";
            this.labelIteration.Size = new System.Drawing.Size(48, 13);
            this.labelIteration.TabIndex = 5;
            this.labelIteration.Text = "Iteration:";
            // 
            // lblIterationInfo
            // 
            this.lblIterationInfo.AutoSize = true;
            this.lblIterationInfo.Location = new System.Drawing.Point(572, 220);
            this.lblIterationInfo.Name = "lblIterationInfo";
            this.lblIterationInfo.Size = new System.Drawing.Size(13, 13);
            this.lblIterationInfo.TabIndex = 6;
            this.lblIterationInfo.Text = "0";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(15, 51);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(84, 13);
            this.label1.TabIndex = 7;
            this.label1.Text = "Neighbor radius:";
            // 
            // numNeighborRadius
            // 
            this.numNeighborRadius.Location = new System.Drawing.Point(135, 49);
            this.numNeighborRadius.Maximum = new decimal(new int[] {
            1000,
            0,
            0,
            0});
            this.numNeighborRadius.Name = "numNeighborRadius";
            this.numNeighborRadius.Size = new System.Drawing.Size(59, 20);
            this.numNeighborRadius.TabIndex = 8;
            this.numNeighborRadius.TabStop = false;
            this.numNeighborRadius.Value = new decimal(new int[] {
            20,
            0,
            0,
            0});
            // 
            // numRadiusDecay
            // 
            this.numRadiusDecay.Increment = new decimal(new int[] {
            10,
            0,
            0,
            0});
            this.numRadiusDecay.Location = new System.Drawing.Point(135, 75);
            this.numRadiusDecay.Maximum = new decimal(new int[] {
            1000,
            0,
            0,
            0});
            this.numRadiusDecay.Name = "numRadiusDecay";
            this.numRadiusDecay.Size = new System.Drawing.Size(59, 20);
            this.numRadiusDecay.TabIndex = 10;
            this.numRadiusDecay.TabStop = false;
            this.numRadiusDecay.Value = new decimal(new int[] {
            300,
            0,
            0,
            0});
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(15, 77);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(96, 13);
            this.label2.TabIndex = 9;
            this.label2.Text = "Radius decay rate:";
            // 
            // numShiftFactor
            // 
            this.numShiftFactor.DecimalPlaces = 2;
            this.numShiftFactor.Increment = new decimal(new int[] {
            1,
            0,
            0,
            131072});
            this.numShiftFactor.Location = new System.Drawing.Point(135, 101);
            this.numShiftFactor.Maximum = new decimal(new int[] {
            5,
            0,
            0,
            0});
            this.numShiftFactor.Name = "numShiftFactor";
            this.numShiftFactor.Size = new System.Drawing.Size(59, 20);
            this.numShiftFactor.TabIndex = 12;
            this.numShiftFactor.TabStop = false;
            this.numShiftFactor.Value = new decimal(new int[] {
            75,
            0,
            0,
            131072});
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(15, 103);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(61, 13);
            this.label3.TabIndex = 11;
            this.label3.Text = "Shift factor:";
            // 
            // numShiftDecayRate
            // 
            this.numShiftDecayRate.Increment = new decimal(new int[] {
            10,
            0,
            0,
            0});
            this.numShiftDecayRate.Location = new System.Drawing.Point(135, 127);
            this.numShiftDecayRate.Maximum = new decimal(new int[] {
            1000,
            0,
            0,
            0});
            this.numShiftDecayRate.Name = "numShiftDecayRate";
            this.numShiftDecayRate.Size = new System.Drawing.Size(59, 20);
            this.numShiftDecayRate.TabIndex = 14;
            this.numShiftDecayRate.TabStop = false;
            this.numShiftDecayRate.Value = new decimal(new int[] {
            150,
            0,
            0,
            0});
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(15, 129);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(114, 13);
            this.label4.TabIndex = 13;
            this.label4.Text = "Shift factor decay rate:";
            // 
            // grpBoxConfig
            // 
            this.grpBoxConfig.Controls.Add(this.numDrawFreq);
            this.grpBoxConfig.Controls.Add(this.label5);
            this.grpBoxConfig.Controls.Add(this.labelNeurons);
            this.grpBoxConfig.Controls.Add(this.numShiftDecayRate);
            this.grpBoxConfig.Controls.Add(this.numNeurons);
            this.grpBoxConfig.Controls.Add(this.label4);
            this.grpBoxConfig.Controls.Add(this.label1);
            this.grpBoxConfig.Controls.Add(this.numShiftFactor);
            this.grpBoxConfig.Controls.Add(this.numNeighborRadius);
            this.grpBoxConfig.Controls.Add(this.label3);
            this.grpBoxConfig.Controls.Add(this.label2);
            this.grpBoxConfig.Controls.Add(this.numRadiusDecay);
            this.grpBoxConfig.Location = new System.Drawing.Point(518, 12);
            this.grpBoxConfig.Name = "grpBoxConfig";
            this.grpBoxConfig.Size = new System.Drawing.Size(214, 192);
            this.grpBoxConfig.TabIndex = 15;
            this.grpBoxConfig.TabStop = false;
            this.grpBoxConfig.Text = "SOM configuration";
            // 
            // numDrawFreq
            // 
            this.numDrawFreq.Increment = new decimal(new int[] {
            10,
            0,
            0,
            0});
            this.numDrawFreq.Location = new System.Drawing.Point(135, 153);
            this.numDrawFreq.Maximum = new decimal(new int[] {
            1000,
            0,
            0,
            0});
            this.numDrawFreq.Minimum = new decimal(new int[] {
            1,
            0,
            0,
            0});
            this.numDrawFreq.Name = "numDrawFreq";
            this.numDrawFreq.Size = new System.Drawing.Size(59, 20);
            this.numDrawFreq.TabIndex = 16;
            this.numDrawFreq.TabStop = false;
            this.numDrawFreq.Value = new decimal(new int[] {
            1,
            0,
            0,
            0});
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(15, 155);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(88, 26);
            this.label5.TabIndex = 15;
            this.label5.Text = "Draw frequency: \r\n(in iterations)";
            // 
            // MainForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(740, 523);
            this.Controls.Add(this.grpBoxConfig);
            this.Controls.Add(this.lblIterationInfo);
            this.Controls.Add(this.labelIteration);
            this.Controls.Add(this.btnStop);
            this.Controls.Add(this.btnGenerate);
            this.Controls.Add(this.btnStartPause);
            this.Controls.Add(this.labelAuthor);
            this.Controls.Add(this.picBoxMap);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.MaximizeBox = false;
            this.Name = "MainForm";
            this.Text = "Self-Organizing Map";
            ((System.ComponentModel.ISupportInitialize)(this.picBoxMap)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.numNeurons)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.numNeighborRadius)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.numRadiusDecay)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.numShiftFactor)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.numShiftDecayRate)).EndInit();
            this.grpBoxConfig.ResumeLayout(false);
            this.grpBoxConfig.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.numDrawFreq)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.PictureBox picBoxMap;
        private System.Windows.Forms.Label labelAuthor;
        private System.Windows.Forms.Timer timer;
        private System.Windows.Forms.Button btnStartPause;
        private System.Windows.Forms.NumericUpDown numNeurons;
        private System.Windows.Forms.Label labelNeurons;
        private System.Windows.Forms.Button btnGenerate;
        private System.Windows.Forms.Button btnStop;
        private System.Windows.Forms.Label labelIteration;
        private System.Windows.Forms.Label lblIterationInfo;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.NumericUpDown numNeighborRadius;
        private System.Windows.Forms.NumericUpDown numRadiusDecay;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.NumericUpDown numShiftFactor;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.NumericUpDown numShiftDecayRate;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.GroupBox grpBoxConfig;
        private System.Windows.Forms.NumericUpDown numDrawFreq;
        private System.Windows.Forms.Label label5;
    }
}

