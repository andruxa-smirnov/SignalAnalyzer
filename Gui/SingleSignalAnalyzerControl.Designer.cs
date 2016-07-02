﻿namespace Gui
{
    partial class SingleSignalAnalyzerControl
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

        #region Component Designer generated code

        /// <summary> 
        /// Required method for Designer support - do not modify 
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.components = new System.ComponentModel.Container();
            this.testString = new System.Windows.Forms.TextBox();
            this.testStringLabel = new System.Windows.Forms.Label();
            this.playAudio = new System.Windows.Forms.CheckBox();
            this.writeWavFiles = new System.Windows.Forms.CheckBox();
            this.baudRate = new System.Windows.Forms.TextBox();
            this.baudRateLabel = new System.Windows.Forms.Label();
            this.audioLengthMicrosecondsLabel = new System.Windows.Forms.Label();
            this.audioLengthMicroseconds = new System.Windows.Forms.TextBox();
            this.numberOfBitsLabel = new System.Windows.Forms.Label();
            this.numberOfBits = new System.Windows.Forms.TextBox();
            this.toleranceLabel = new System.Windows.Forms.Label();
            this.tolerance = new System.Windows.Forms.TextBox();
            this.boost = new System.Windows.Forms.TextBox();
            this.boostLabel = new System.Windows.Forms.Label();
            this.markFrequencyLabel = new System.Windows.Forms.Label();
            this.spaceFrequencyLabel = new System.Windows.Forms.Label();
            this.spaceFrequency = new System.Windows.Forms.TextBox();
            this.markFrequency = new System.Windows.Forms.TextBox();
            this.startButton = new System.Windows.Forms.Button();
            this.backgroundWorker1 = new System.ComponentModel.BackgroundWorker();
            this.toolTip1 = new System.Windows.Forms.ToolTip(this.components);
            this.resultString = new System.Windows.Forms.TextBox();
            this.resultStringLabel = new System.Windows.Forms.Label();
            this.matchLabel = new System.Windows.Forms.Label();
            this.scopePictureBox = new System.Windows.Forms.PictureBox();
            ((System.ComponentModel.ISupportInitialize)(this.scopePictureBox)).BeginInit();
            this.SuspendLayout();
            // 
            // testString
            // 
            this.testString.Location = new System.Drawing.Point(168, 476);
            this.testString.Name = "testString";
            this.testString.Size = new System.Drawing.Size(197, 20);
            this.testString.TabIndex = 123;
            this.testString.Text = "A";
            this.testString.Enter += new System.EventHandler(this.testString_Enter);
            this.testString.KeyUp += new System.Windows.Forms.KeyEventHandler(this.textboxKeyUp);
            // 
            // testStringLabel
            // 
            this.testStringLabel.AutoSize = true;
            this.testStringLabel.Location = new System.Drawing.Point(100, 479);
            this.testStringLabel.Name = "testStringLabel";
            this.testStringLabel.Size = new System.Drawing.Size(56, 13);
            this.testStringLabel.TabIndex = 135;
            this.testStringLabel.Text = "Test string";
            // 
            // playAudio
            // 
            this.playAudio.AutoSize = true;
            this.playAudio.Location = new System.Drawing.Point(230, 509);
            this.playAudio.Name = "playAudio";
            this.playAudio.Size = new System.Drawing.Size(75, 17);
            this.playAudio.TabIndex = 125;
            this.playAudio.Text = "Play audio";
            this.playAudio.UseVisualStyleBackColor = true;
            // 
            // writeWavFiles
            // 
            this.writeWavFiles.AutoSize = true;
            this.writeWavFiles.Location = new System.Drawing.Point(103, 509);
            this.writeWavFiles.Name = "writeWavFiles";
            this.writeWavFiles.Size = new System.Drawing.Size(95, 17);
            this.writeWavFiles.TabIndex = 124;
            this.writeWavFiles.Text = "Write WAV file";
            this.writeWavFiles.UseVisualStyleBackColor = true;
            // 
            // baudRate
            // 
            this.baudRate.Location = new System.Drawing.Point(168, 439);
            this.baudRate.Name = "baudRate";
            this.baudRate.Size = new System.Drawing.Size(100, 20);
            this.baudRate.TabIndex = 121;
            this.baudRate.Text = "500";
            this.baudRate.Enter += new System.EventHandler(this.baudRate_Enter);
            this.baudRate.KeyUp += new System.Windows.Forms.KeyEventHandler(this.textboxKeyUp);
            // 
            // baudRateLabel
            // 
            this.baudRateLabel.AutoSize = true;
            this.baudRateLabel.Location = new System.Drawing.Point(100, 442);
            this.baudRateLabel.Name = "baudRateLabel";
            this.baudRateLabel.Size = new System.Drawing.Size(53, 13);
            this.baudRateLabel.TabIndex = 134;
            this.baudRateLabel.Text = "Baud rate";
            // 
            // audioLengthMicrosecondsLabel
            // 
            this.audioLengthMicrosecondsLabel.AutoSize = true;
            this.audioLengthMicrosecondsLabel.Enabled = false;
            this.audioLengthMicrosecondsLabel.Location = new System.Drawing.Point(679, 455);
            this.audioLengthMicrosecondsLabel.Name = "audioLengthMicrosecondsLabel";
            this.audioLengthMicrosecondsLabel.Size = new System.Drawing.Size(93, 13);
            this.audioLengthMicrosecondsLabel.TabIndex = 133;
            this.audioLengthMicrosecondsLabel.Text = "Symbol length (us)";
            // 
            // audioLengthMicroseconds
            // 
            this.audioLengthMicroseconds.Enabled = false;
            this.audioLengthMicroseconds.Location = new System.Drawing.Point(676, 471);
            this.audioLengthMicroseconds.Name = "audioLengthMicroseconds";
            this.audioLengthMicroseconds.ReadOnly = true;
            this.audioLengthMicroseconds.Size = new System.Drawing.Size(100, 20);
            this.audioLengthMicroseconds.TabIndex = 132;
            this.audioLengthMicroseconds.TabStop = false;
            this.audioLengthMicroseconds.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // numberOfBitsLabel
            // 
            this.numberOfBitsLabel.AutoSize = true;
            this.numberOfBitsLabel.Enabled = false;
            this.numberOfBitsLabel.Location = new System.Drawing.Point(687, 401);
            this.numberOfBitsLabel.Name = "numberOfBitsLabel";
            this.numberOfBitsLabel.Size = new System.Drawing.Size(75, 13);
            this.numberOfBitsLabel.TabIndex = 131;
            this.numberOfBitsLabel.Text = "Number of bits";
            // 
            // numberOfBits
            // 
            this.numberOfBits.Enabled = false;
            this.numberOfBits.Location = new System.Drawing.Point(676, 417);
            this.numberOfBits.Name = "numberOfBits";
            this.numberOfBits.ReadOnly = true;
            this.numberOfBits.Size = new System.Drawing.Size(100, 20);
            this.numberOfBits.TabIndex = 130;
            this.numberOfBits.TabStop = false;
            this.numberOfBits.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // toleranceLabel
            // 
            this.toleranceLabel.AutoSize = true;
            this.toleranceLabel.Location = new System.Drawing.Point(487, 404);
            this.toleranceLabel.Name = "toleranceLabel";
            this.toleranceLabel.Size = new System.Drawing.Size(55, 13);
            this.toleranceLabel.TabIndex = 129;
            this.toleranceLabel.Text = "Tolerance";
            // 
            // tolerance
            // 
            this.tolerance.Location = new System.Drawing.Point(546, 401);
            this.tolerance.Name = "tolerance";
            this.tolerance.Size = new System.Drawing.Size(100, 20);
            this.tolerance.TabIndex = 120;
            this.tolerance.Text = "20";
            this.tolerance.Enter += new System.EventHandler(this.tolerance_Enter);
            this.tolerance.KeyUp += new System.Windows.Forms.KeyEventHandler(this.textboxKeyUp);
            // 
            // boost
            // 
            this.boost.Location = new System.Drawing.Point(349, 439);
            this.boost.Name = "boost";
            this.boost.Size = new System.Drawing.Size(100, 20);
            this.boost.TabIndex = 122;
            this.boost.Enter += new System.EventHandler(this.boost_Enter);
            this.boost.KeyUp += new System.Windows.Forms.KeyEventHandler(this.textboxKeyUp);
            // 
            // boostLabel
            // 
            this.boostLabel.AutoSize = true;
            this.boostLabel.Location = new System.Drawing.Point(288, 442);
            this.boostLabel.Name = "boostLabel";
            this.boostLabel.Size = new System.Drawing.Size(34, 13);
            this.boostLabel.TabIndex = 126;
            this.boostLabel.Text = "Boost";
            // 
            // markFrequencyLabel
            // 
            this.markFrequencyLabel.AutoSize = true;
            this.markFrequencyLabel.Location = new System.Drawing.Point(288, 404);
            this.markFrequencyLabel.Name = "markFrequencyLabel";
            this.markFrequencyLabel.Size = new System.Drawing.Size(55, 13);
            this.markFrequencyLabel.TabIndex = 127;
            this.markFrequencyLabel.Text = "Mark freq.";
            // 
            // spaceFrequencyLabel
            // 
            this.spaceFrequencyLabel.AutoSize = true;
            this.spaceFrequencyLabel.Location = new System.Drawing.Point(100, 404);
            this.spaceFrequencyLabel.Name = "spaceFrequencyLabel";
            this.spaceFrequencyLabel.Size = new System.Drawing.Size(62, 13);
            this.spaceFrequencyLabel.TabIndex = 128;
            this.spaceFrequencyLabel.Text = "Space freq.";
            // 
            // spaceFrequency
            // 
            this.spaceFrequency.Location = new System.Drawing.Point(168, 401);
            this.spaceFrequency.Name = "spaceFrequency";
            this.spaceFrequency.Size = new System.Drawing.Size(100, 20);
            this.spaceFrequency.TabIndex = 118;
            this.spaceFrequency.Text = "1000";
            this.spaceFrequency.Enter += new System.EventHandler(this.spaceFrequency_Enter);
            this.spaceFrequency.KeyUp += new System.Windows.Forms.KeyEventHandler(this.textboxKeyUp);
            // 
            // markFrequency
            // 
            this.markFrequency.Location = new System.Drawing.Point(349, 401);
            this.markFrequency.Name = "markFrequency";
            this.markFrequency.Size = new System.Drawing.Size(100, 20);
            this.markFrequency.TabIndex = 119;
            this.markFrequency.Text = "3000";
            this.markFrequency.Enter += new System.EventHandler(this.markFrequency_Enter);
            this.markFrequency.KeyUp += new System.Windows.Forms.KeyEventHandler(this.textboxKeyUp);
            // 
            // startButton
            // 
            this.startButton.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(192)))), ((int)(((byte)(192)))), ((int)(((byte)(255)))));
            this.startButton.Location = new System.Drawing.Point(671, 511);
            this.startButton.Name = "startButton";
            this.startButton.Size = new System.Drawing.Size(111, 51);
            this.startButton.TabIndex = 136;
            this.startButton.Text = "Analyze";
            this.startButton.UseVisualStyleBackColor = false;
            this.startButton.Click += new System.EventHandler(this.startButton_Click);
            // 
            // backgroundWorker1
            // 
            this.backgroundWorker1.WorkerReportsProgress = true;
            this.backgroundWorker1.WorkerSupportsCancellation = true;
            this.backgroundWorker1.DoWork += new System.ComponentModel.DoWorkEventHandler(this.backgroundWorker1_DoWork);
            this.backgroundWorker1.RunWorkerCompleted += new System.ComponentModel.RunWorkerCompletedEventHandler(this.backgroundWorker1_RunWorkerCompleted);
            // 
            // resultString
            // 
            this.resultString.BackColor = System.Drawing.SystemColors.Control;
            this.resultString.Enabled = false;
            this.resultString.Location = new System.Drawing.Point(449, 476);
            this.resultString.Name = "resultString";
            this.resultString.ReadOnly = true;
            this.resultString.Size = new System.Drawing.Size(197, 20);
            this.resultString.TabIndex = 137;
            this.resultString.TabStop = false;
            // 
            // resultStringLabel
            // 
            this.resultStringLabel.AutoSize = true;
            this.resultStringLabel.Enabled = false;
            this.resultStringLabel.Location = new System.Drawing.Point(381, 479);
            this.resultStringLabel.Name = "resultStringLabel";
            this.resultStringLabel.Size = new System.Drawing.Size(65, 13);
            this.resultStringLabel.TabIndex = 138;
            this.resultStringLabel.Text = "Result string";
            // 
            // matchLabel
            // 
            this.matchLabel.AutoSize = true;
            this.matchLabel.Enabled = false;
            this.matchLabel.Location = new System.Drawing.Point(449, 509);
            this.matchLabel.Name = "matchLabel";
            this.matchLabel.Size = new System.Drawing.Size(62, 13);
            this.matchLabel.TabIndex = 139;
            this.matchLabel.Text = "Match label";
            // 
            // scopePictureBox
            // 
            this.scopePictureBox.BackColor = System.Drawing.SystemColors.WindowText;
            this.scopePictureBox.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.scopePictureBox.Location = new System.Drawing.Point(29, 28);
            this.scopePictureBox.Name = "scopePictureBox";
            this.scopePictureBox.Size = new System.Drawing.Size(882, 346);
            this.scopePictureBox.TabIndex = 140;
            this.scopePictureBox.TabStop = false;
            // 
            // SingleSignalAnalyzerControl
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.Controls.Add(this.scopePictureBox);
            this.Controls.Add(this.matchLabel);
            this.Controls.Add(this.resultString);
            this.Controls.Add(this.resultStringLabel);
            this.Controls.Add(this.startButton);
            this.Controls.Add(this.testString);
            this.Controls.Add(this.testStringLabel);
            this.Controls.Add(this.playAudio);
            this.Controls.Add(this.writeWavFiles);
            this.Controls.Add(this.baudRate);
            this.Controls.Add(this.baudRateLabel);
            this.Controls.Add(this.audioLengthMicrosecondsLabel);
            this.Controls.Add(this.audioLengthMicroseconds);
            this.Controls.Add(this.numberOfBitsLabel);
            this.Controls.Add(this.numberOfBits);
            this.Controls.Add(this.toleranceLabel);
            this.Controls.Add(this.tolerance);
            this.Controls.Add(this.boost);
            this.Controls.Add(this.boostLabel);
            this.Controls.Add(this.markFrequencyLabel);
            this.Controls.Add(this.spaceFrequencyLabel);
            this.Controls.Add(this.spaceFrequency);
            this.Controls.Add(this.markFrequency);
            this.Name = "SingleSignalAnalyzerControl";
            this.Size = new System.Drawing.Size(943, 587);
            ((System.ComponentModel.ISupportInitialize)(this.scopePictureBox)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.TextBox testString;
        private System.Windows.Forms.Label testStringLabel;
        private System.Windows.Forms.CheckBox playAudio;
        private System.Windows.Forms.CheckBox writeWavFiles;
        private System.Windows.Forms.TextBox baudRate;
        private System.Windows.Forms.Label baudRateLabel;
        private System.Windows.Forms.Label audioLengthMicrosecondsLabel;
        private System.Windows.Forms.TextBox audioLengthMicroseconds;
        private System.Windows.Forms.Label numberOfBitsLabel;
        private System.Windows.Forms.TextBox numberOfBits;
        private System.Windows.Forms.Label toleranceLabel;
        private System.Windows.Forms.TextBox tolerance;
        private System.Windows.Forms.TextBox boost;
        private System.Windows.Forms.Label boostLabel;
        private System.Windows.Forms.Label markFrequencyLabel;
        private System.Windows.Forms.Label spaceFrequencyLabel;
        private System.Windows.Forms.TextBox spaceFrequency;
        private System.Windows.Forms.TextBox markFrequency;
        private System.Windows.Forms.Button startButton;
        private System.ComponentModel.BackgroundWorker backgroundWorker1;
        private System.Windows.Forms.ToolTip toolTip1;
        private System.Windows.Forms.TextBox resultString;
        private System.Windows.Forms.Label resultStringLabel;
        private System.Windows.Forms.Label matchLabel;
        private System.Windows.Forms.PictureBox scopePictureBox;
    }
}
