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
            this.pictureBox = new System.Windows.Forms.PictureBox();
            this.labelAuthor = new System.Windows.Forms.Label();
            this.timer = new System.Windows.Forms.Timer(this.components);
            this.buttonStartPause = new System.Windows.Forms.Button();
            this.numericNeurons = new System.Windows.Forms.NumericUpDown();
            this.labelNeurons = new System.Windows.Forms.Label();
            this.buttonGenerate = new System.Windows.Forms.Button();
            this.buttonStop = new System.Windows.Forms.Button();
            this.labelIteration = new System.Windows.Forms.Label();
            this.labelIterationInfo = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.numericNeurons)).BeginInit();
            this.SuspendLayout();
            // 
            // pictureBox
            // 
            this.pictureBox.BackColor = System.Drawing.Color.White;
            this.pictureBox.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.pictureBox.Location = new System.Drawing.Point(12, 12);
            this.pictureBox.Name = "pictureBox";
            this.pictureBox.Size = new System.Drawing.Size(500, 500);
            this.pictureBox.TabIndex = 0;
            this.pictureBox.TabStop = false;
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
            // buttonStartPause
            // 
            this.buttonStartPause.Enabled = false;
            this.buttonStartPause.Location = new System.Drawing.Point(521, 117);
            this.buttonStartPause.Name = "buttonStartPause";
            this.buttonStartPause.Size = new System.Drawing.Size(75, 23);
            this.buttonStartPause.TabIndex = 1;
            this.buttonStartPause.Text = "Start";
            this.buttonStartPause.UseVisualStyleBackColor = true;
            this.buttonStartPause.Click += new System.EventHandler(this.buttonStartPause_Click);
            // 
            // numericNeurons
            // 
            this.numericNeurons.Increment = new decimal(new int[] {
            10,
            0,
            0,
            0});
            this.numericNeurons.Location = new System.Drawing.Point(577, 26);
            this.numericNeurons.Maximum = new decimal(new int[] {
            60,
            0,
            0,
            0});
            this.numericNeurons.Minimum = new decimal(new int[] {
            10,
            0,
            0,
            0});
            this.numericNeurons.Name = "numericNeurons";
            this.numericNeurons.Size = new System.Drawing.Size(97, 20);
            this.numericNeurons.TabIndex = 0;
            this.numericNeurons.TabStop = false;
            this.numericNeurons.Value = new decimal(new int[] {
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
            // buttonGenerate
            // 
            this.buttonGenerate.Location = new System.Drawing.Point(521, 88);
            this.buttonGenerate.Name = "buttonGenerate";
            this.buttonGenerate.Size = new System.Drawing.Size(153, 23);
            this.buttonGenerate.TabIndex = 0;
            this.buttonGenerate.Text = "Generate";
            this.buttonGenerate.UseVisualStyleBackColor = true;
            this.buttonGenerate.Click += new System.EventHandler(this.buttonGenerate_Click);
            // 
            // buttonStop
            // 
            this.buttonStop.Enabled = false;
            this.buttonStop.Location = new System.Drawing.Point(599, 117);
            this.buttonStop.Name = "buttonStop";
            this.buttonStop.Size = new System.Drawing.Size(75, 23);
            this.buttonStop.TabIndex = 2;
            this.buttonStop.Text = "Stop";
            this.buttonStop.UseVisualStyleBackColor = true;
            this.buttonStop.Click += new System.EventHandler(this.buttonStop_Click);
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
            // labelIterationInfo
            // 
            this.labelIterationInfo.AutoSize = true;
            this.labelIterationInfo.Location = new System.Drawing.Point(574, 54);
            this.labelIterationInfo.Name = "labelIterationInfo";
            this.labelIterationInfo.Size = new System.Drawing.Size(42, 13);
            this.labelIterationInfo.TabIndex = 6;
            this.labelIterationInfo.Text = "1/3000";
            // 
            // MainForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(686, 523);
            this.Controls.Add(this.labelIterationInfo);
            this.Controls.Add(this.labelIteration);
            this.Controls.Add(this.buttonStop);
            this.Controls.Add(this.buttonGenerate);
            this.Controls.Add(this.labelNeurons);
            this.Controls.Add(this.numericNeurons);
            this.Controls.Add(this.buttonStartPause);
            this.Controls.Add(this.labelAuthor);
            this.Controls.Add(this.pictureBox);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.MaximizeBox = false;
            this.Name = "MainForm";
            this.Text = "Self-Organizing Map";
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.numericNeurons)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.PictureBox pictureBox;
        private System.Windows.Forms.Label labelAuthor;
        private System.Windows.Forms.Timer timer;
        private System.Windows.Forms.Button buttonStartPause;
        private System.Windows.Forms.NumericUpDown numericNeurons;
        private System.Windows.Forms.Label labelNeurons;
        private System.Windows.Forms.Button buttonGenerate;
        private System.Windows.Forms.Button buttonStop;
        private System.Windows.Forms.Label labelIteration;
        private System.Windows.Forms.Label labelIterationInfo;
    }
}

