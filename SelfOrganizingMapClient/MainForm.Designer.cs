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
            ((System.ComponentModel.ISupportInitialize)(this.picBoxMap)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.numNeurons)).BeginInit();
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
            this.labelAuthor.Location = new System.Drawing.Point(518, 499);
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
            this.btnStartPause.Location = new System.Drawing.Point(521, 117);
            this.btnStartPause.Name = "btnStartPause";
            this.btnStartPause.Size = new System.Drawing.Size(75, 23);
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
            this.numNeurons.Location = new System.Drawing.Point(577, 26);
            this.numNeurons.Maximum = new decimal(new int[] {
            60,
            0,
            0,
            0});
            this.numNeurons.Minimum = new decimal(new int[] {
            10,
            0,
            0,
            0});
            this.numNeurons.Name = "numNeurons";
            this.numNeurons.Size = new System.Drawing.Size(97, 20);
            this.numNeurons.TabIndex = 0;
            this.numNeurons.TabStop = false;
            this.numNeurons.Value = new decimal(new int[] {
            30,
            0,
            0,
            0});
            // 
            // labelNeurons
            // 
            this.labelNeurons.AutoSize = true;
            this.labelNeurons.Location = new System.Drawing.Point(518, 28);
            this.labelNeurons.Name = "labelNeurons";
            this.labelNeurons.Size = new System.Drawing.Size(50, 13);
            this.labelNeurons.TabIndex = 3;
            this.labelNeurons.Text = "Neurons:";
            // 
            // btnGenerate
            // 
            this.btnGenerate.Location = new System.Drawing.Point(521, 88);
            this.btnGenerate.Name = "btnGenerate";
            this.btnGenerate.Size = new System.Drawing.Size(153, 23);
            this.btnGenerate.TabIndex = 0;
            this.btnGenerate.Text = "Generate";
            this.btnGenerate.UseVisualStyleBackColor = true;
            this.btnGenerate.Click += new System.EventHandler(this.buttonGenerate_Click);
            // 
            // btnStop
            // 
            this.btnStop.Enabled = false;
            this.btnStop.Location = new System.Drawing.Point(599, 117);
            this.btnStop.Name = "btnStop";
            this.btnStop.Size = new System.Drawing.Size(75, 23);
            this.btnStop.TabIndex = 2;
            this.btnStop.Text = "Stop";
            this.btnStop.UseVisualStyleBackColor = true;
            this.btnStop.Click += new System.EventHandler(this.buttonStop_Click);
            // 
            // labelIteration
            // 
            this.labelIteration.AutoSize = true;
            this.labelIteration.Location = new System.Drawing.Point(518, 54);
            this.labelIteration.Name = "labelIteration";
            this.labelIteration.Size = new System.Drawing.Size(48, 13);
            this.labelIteration.TabIndex = 5;
            this.labelIteration.Text = "Iteration:";
            // 
            // lblIterationInfo
            // 
            this.lblIterationInfo.AutoSize = true;
            this.lblIterationInfo.Location = new System.Drawing.Point(574, 54);
            this.lblIterationInfo.Name = "lblIterationInfo";
            this.lblIterationInfo.Size = new System.Drawing.Size(42, 13);
            this.lblIterationInfo.TabIndex = 6;
            this.lblIterationInfo.Text = "1/3000";
            // 
            // MainForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(686, 523);
            this.Controls.Add(this.lblIterationInfo);
            this.Controls.Add(this.labelIteration);
            this.Controls.Add(this.btnStop);
            this.Controls.Add(this.btnGenerate);
            this.Controls.Add(this.labelNeurons);
            this.Controls.Add(this.numNeurons);
            this.Controls.Add(this.btnStartPause);
            this.Controls.Add(this.labelAuthor);
            this.Controls.Add(this.picBoxMap);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.MaximizeBox = false;
            this.Name = "MainForm";
            this.Text = "Self-Organizing Map";
            ((System.ComponentModel.ISupportInitialize)(this.picBoxMap)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.numNeurons)).EndInit();
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
    }
}

