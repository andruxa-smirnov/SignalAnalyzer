﻿namespace Gui
{
    partial class Form1
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
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle1 = new System.Windows.Forms.DataGridViewCellStyle();
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Form1));
            this.backgroundWorker1 = new System.ComponentModel.BackgroundWorker();
            this.markFrequency = new System.Windows.Forms.TextBox();
            this.spaceFrequency = new System.Windows.Forms.TextBox();
            this.spaceFrequencyLabel = new System.Windows.Forms.Label();
            this.markFrequencyLabel = new System.Windows.Forms.Label();
            this.boostStartLabel = new System.Windows.Forms.Label();
            this.boostStart = new System.Windows.Forms.TextBox();
            this.boostIncrementLabel = new System.Windows.Forms.Label();
            this.boostIncrement = new System.Windows.Forms.TextBox();
            this.boostEndLabel = new System.Windows.Forms.Label();
            this.boostEnd = new System.Windows.Forms.TextBox();
            this.startButton = new System.Windows.Forms.Button();
            this.mainDataGrid = new System.Windows.Forms.DataGridView();
            this.exportToCsvButton = new System.Windows.Forms.Button();
            this.toleranceLabel = new System.Windows.Forms.Label();
            this.tolerance = new System.Windows.Forms.TextBox();
            this.numberOfBitsLabel = new System.Windows.Forms.Label();
            this.numberOfBits = new System.Windows.Forms.TextBox();
            this.audioLengthMicrosecondsLabel = new System.Windows.Forms.Label();
            this.audioLengthMicroseconds = new System.Windows.Forms.TextBox();
            this.statusStrip1 = new System.Windows.Forms.StatusStrip();
            this.toolStripStatusLabel1 = new System.Windows.Forms.ToolStripStatusLabel();
            this.toolStripStatusLabel2 = new System.Windows.Forms.ToolStripStatusLabel();
            this.baudStartLabel = new System.Windows.Forms.Label();
            this.baudStart = new System.Windows.Forms.TextBox();
            this.baudIncrement = new System.Windows.Forms.TextBox();
            this.baudEnd = new System.Windows.Forms.TextBox();
            this.baudIncrementLabel = new System.Windows.Forms.Label();
            this.baudEndLabel = new System.Windows.Forms.Label();
            this.toolTip1 = new System.Windows.Forms.ToolTip(this.components);
            this.writeWavFiles = new System.Windows.Forms.CheckBox();
            this.playAudio = new System.Windows.Forms.CheckBox();
            this.testString = new System.Windows.Forms.TextBox();
            this.testStringLabel = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.mainDataGrid)).BeginInit();
            this.statusStrip1.SuspendLayout();
            this.SuspendLayout();
            // 
            // backgroundWorker1
            // 
            this.backgroundWorker1.WorkerReportsProgress = true;
            this.backgroundWorker1.DoWork += new System.ComponentModel.DoWorkEventHandler(this.backgroundWorker1_DoWork);
            this.backgroundWorker1.RunWorkerCompleted += new System.ComponentModel.RunWorkerCompletedEventHandler(this.backgroundWorker1_RunWorkerCompleted);
            // 
            // markFrequency
            // 
            this.markFrequency.Location = new System.Drawing.Point(283, 383);
            this.markFrequency.Name = "markFrequency";
            this.markFrequency.Size = new System.Drawing.Size(100, 20);
            this.markFrequency.TabIndex = 2;
            this.markFrequency.Text = "1270";
            this.markFrequency.Enter += new System.EventHandler(this.markFrequency_Enter);
            this.markFrequency.KeyUp += new System.Windows.Forms.KeyEventHandler(this.textboxKeyUp);
            // 
            // spaceFrequency
            // 
            this.spaceFrequency.Location = new System.Drawing.Point(80, 383);
            this.spaceFrequency.Name = "spaceFrequency";
            this.spaceFrequency.Size = new System.Drawing.Size(100, 20);
            this.spaceFrequency.TabIndex = 1;
            this.spaceFrequency.Text = "1070";
            this.spaceFrequency.Enter += new System.EventHandler(this.spaceFrequency_Enter);
            this.spaceFrequency.KeyUp += new System.Windows.Forms.KeyEventHandler(this.textboxKeyUp);
            // 
            // spaceFrequencyLabel
            // 
            this.spaceFrequencyLabel.AutoSize = true;
            this.spaceFrequencyLabel.Location = new System.Drawing.Point(12, 386);
            this.spaceFrequencyLabel.Name = "spaceFrequencyLabel";
            this.spaceFrequencyLabel.Size = new System.Drawing.Size(62, 13);
            this.spaceFrequencyLabel.TabIndex = 99;
            this.spaceFrequencyLabel.Text = "Space freq.";
            // 
            // markFrequencyLabel
            // 
            this.markFrequencyLabel.AutoSize = true;
            this.markFrequencyLabel.Location = new System.Drawing.Point(222, 386);
            this.markFrequencyLabel.Name = "markFrequencyLabel";
            this.markFrequencyLabel.Size = new System.Drawing.Size(55, 13);
            this.markFrequencyLabel.TabIndex = 99;
            this.markFrequencyLabel.Text = "Mark freq.";
            // 
            // boostStartLabel
            // 
            this.boostStartLabel.AutoSize = true;
            this.boostStartLabel.Location = new System.Drawing.Point(12, 461);
            this.boostStartLabel.Name = "boostStartLabel";
            this.boostStartLabel.Size = new System.Drawing.Size(57, 13);
            this.boostStartLabel.TabIndex = 99;
            this.boostStartLabel.Text = "Boost start";
            // 
            // boostStart
            // 
            this.boostStart.Location = new System.Drawing.Point(80, 458);
            this.boostStart.Name = "boostStart";
            this.boostStart.Size = new System.Drawing.Size(100, 20);
            this.boostStart.TabIndex = 7;
            this.boostStart.Enter += new System.EventHandler(this.boostStart_Enter);
            this.boostStart.KeyUp += new System.Windows.Forms.KeyEventHandler(this.textboxKeyUp);
            // 
            // boostIncrementLabel
            // 
            this.boostIncrementLabel.AutoSize = true;
            this.boostIncrementLabel.Location = new System.Drawing.Point(222, 461);
            this.boostIncrementLabel.Name = "boostIncrementLabel";
            this.boostIncrementLabel.Size = new System.Drawing.Size(54, 13);
            this.boostIncrementLabel.TabIndex = 99;
            this.boostIncrementLabel.Text = "Boost inc.";
            // 
            // boostIncrement
            // 
            this.boostIncrement.Location = new System.Drawing.Point(283, 458);
            this.boostIncrement.Name = "boostIncrement";
            this.boostIncrement.Size = new System.Drawing.Size(100, 20);
            this.boostIncrement.TabIndex = 8;
            this.boostIncrement.Enter += new System.EventHandler(this.boostIncrement_Enter);
            this.boostIncrement.KeyUp += new System.Windows.Forms.KeyEventHandler(this.textboxKeyUp);
            // 
            // boostEndLabel
            // 
            this.boostEndLabel.AutoSize = true;
            this.boostEndLabel.Location = new System.Drawing.Point(421, 461);
            this.boostEndLabel.Name = "boostEndLabel";
            this.boostEndLabel.Size = new System.Drawing.Size(55, 13);
            this.boostEndLabel.TabIndex = 99;
            this.boostEndLabel.Text = "Boost end";
            // 
            // boostEnd
            // 
            this.boostEnd.Location = new System.Drawing.Point(480, 458);
            this.boostEnd.Name = "boostEnd";
            this.boostEnd.Size = new System.Drawing.Size(100, 20);
            this.boostEnd.TabIndex = 9;
            this.boostEnd.Enter += new System.EventHandler(this.boostEnd_Enter);
            this.boostEnd.KeyUp += new System.Windows.Forms.KeyEventHandler(this.textboxKeyUp);
            // 
            // startButton
            // 
            this.startButton.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(192)))), ((int)(((byte)(192)))), ((int)(((byte)(255)))));
            this.startButton.Location = new System.Drawing.Point(821, 380);
            this.startButton.Name = "startButton";
            this.startButton.Size = new System.Drawing.Size(111, 51);
            this.startButton.TabIndex = 10;
            this.startButton.Text = "Analyze";
            this.startButton.UseVisualStyleBackColor = false;
            this.startButton.Click += new System.EventHandler(this.startButton_Click);
            // 
            // mainDataGrid
            // 
            this.mainDataGrid.AllowUserToAddRows = false;
            this.mainDataGrid.AllowUserToDeleteRows = false;
            dataGridViewCellStyle1.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleCenter;
            dataGridViewCellStyle1.BackColor = System.Drawing.SystemColors.Control;
            dataGridViewCellStyle1.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle1.ForeColor = System.Drawing.SystemColors.WindowText;
            dataGridViewCellStyle1.SelectionBackColor = System.Drawing.SystemColors.Highlight;
            dataGridViewCellStyle1.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle1.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.mainDataGrid.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle1;
            this.mainDataGrid.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.mainDataGrid.EditMode = System.Windows.Forms.DataGridViewEditMode.EditProgrammatically;
            this.mainDataGrid.Location = new System.Drawing.Point(12, 12);
            this.mainDataGrid.Name = "mainDataGrid";
            this.mainDataGrid.ReadOnly = true;
            this.mainDataGrid.RowHeadersVisible = false;
            this.mainDataGrid.ScrollBars = System.Windows.Forms.ScrollBars.Vertical;
            this.mainDataGrid.Size = new System.Drawing.Size(920, 350);
            this.mainDataGrid.TabIndex = 100;
            this.mainDataGrid.TabStop = false;
            this.mainDataGrid.CellContentClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.mainDataGrid_CellContentClick);
            // 
            // exportToCsvButton
            // 
            this.exportToCsvButton.Enabled = false;
            this.exportToCsvButton.Location = new System.Drawing.Point(821, 445);
            this.exportToCsvButton.Name = "exportToCsvButton";
            this.exportToCsvButton.Size = new System.Drawing.Size(111, 33);
            this.exportToCsvButton.TabIndex = 11;
            this.exportToCsvButton.Text = "Export to CSV";
            this.exportToCsvButton.UseVisualStyleBackColor = true;
            this.exportToCsvButton.Click += new System.EventHandler(this.exportToCsvButton_Click);
            // 
            // toleranceLabel
            // 
            this.toleranceLabel.AutoSize = true;
            this.toleranceLabel.Location = new System.Drawing.Point(421, 386);
            this.toleranceLabel.Name = "toleranceLabel";
            this.toleranceLabel.Size = new System.Drawing.Size(55, 13);
            this.toleranceLabel.TabIndex = 103;
            this.toleranceLabel.Text = "Tolerance";
            // 
            // tolerance
            // 
            this.tolerance.Location = new System.Drawing.Point(480, 383);
            this.tolerance.Name = "tolerance";
            this.tolerance.Size = new System.Drawing.Size(100, 20);
            this.tolerance.TabIndex = 3;
            this.tolerance.Text = "100";
            this.tolerance.Enter += new System.EventHandler(this.tolerance_Enter);
            this.tolerance.KeyUp += new System.Windows.Forms.KeyEventHandler(this.textboxKeyUp);
            // 
            // numberOfBitsLabel
            // 
            this.numberOfBitsLabel.AutoSize = true;
            this.numberOfBitsLabel.Enabled = false;
            this.numberOfBitsLabel.Location = new System.Drawing.Point(659, 383);
            this.numberOfBitsLabel.Name = "numberOfBitsLabel";
            this.numberOfBitsLabel.Size = new System.Drawing.Size(75, 13);
            this.numberOfBitsLabel.TabIndex = 105;
            this.numberOfBitsLabel.Text = "Number of bits";
            // 
            // numberOfBits
            // 
            this.numberOfBits.Enabled = false;
            this.numberOfBits.Location = new System.Drawing.Point(648, 399);
            this.numberOfBits.Name = "numberOfBits";
            this.numberOfBits.ReadOnly = true;
            this.numberOfBits.Size = new System.Drawing.Size(100, 20);
            this.numberOfBits.TabIndex = 104;
            this.numberOfBits.TabStop = false;
            this.numberOfBits.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // audioLengthMicrosecondsLabel
            // 
            this.audioLengthMicrosecondsLabel.AutoSize = true;
            this.audioLengthMicrosecondsLabel.Enabled = false;
            this.audioLengthMicrosecondsLabel.Location = new System.Drawing.Point(639, 437);
            this.audioLengthMicrosecondsLabel.Name = "audioLengthMicrosecondsLabel";
            this.audioLengthMicrosecondsLabel.Size = new System.Drawing.Size(116, 13);
            this.audioLengthMicrosecondsLabel.TabIndex = 107;
            this.audioLengthMicrosecondsLabel.Text = "Last interval length (us)";
            // 
            // audioLengthMicroseconds
            // 
            this.audioLengthMicroseconds.Enabled = false;
            this.audioLengthMicroseconds.Location = new System.Drawing.Point(648, 453);
            this.audioLengthMicroseconds.Name = "audioLengthMicroseconds";
            this.audioLengthMicroseconds.ReadOnly = true;
            this.audioLengthMicroseconds.Size = new System.Drawing.Size(100, 20);
            this.audioLengthMicroseconds.TabIndex = 106;
            this.audioLengthMicroseconds.TabStop = false;
            this.audioLengthMicroseconds.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // statusStrip1
            // 
            this.statusStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.toolStripStatusLabel1,
            this.toolStripStatusLabel2});
            this.statusStrip1.Location = new System.Drawing.Point(0, 560);
            this.statusStrip1.Name = "statusStrip1";
            this.statusStrip1.Size = new System.Drawing.Size(943, 22);
            this.statusStrip1.TabIndex = 108;
            this.statusStrip1.Text = "statusStrip1";
            // 
            // toolStripStatusLabel1
            // 
            this.toolStripStatusLabel1.Name = "toolStripStatusLabel1";
            this.toolStripStatusLabel1.Size = new System.Drawing.Size(118, 17);
            this.toolStripStatusLabel1.Text = "toolStripStatusLabel1";
            // 
            // toolStripStatusLabel2
            // 
            this.toolStripStatusLabel2.Name = "toolStripStatusLabel2";
            this.toolStripStatusLabel2.Size = new System.Drawing.Size(287, 17);
            this.toolStripStatusLabel2.Text = "http://www.GitHub.com/dandandrea/SignalAnalyzer";
            this.toolStripStatusLabel2.VisitedLinkColor = System.Drawing.Color.Blue;
            // 
            // baudStartLabel
            // 
            this.baudStartLabel.AutoSize = true;
            this.baudStartLabel.Location = new System.Drawing.Point(12, 424);
            this.baudStartLabel.Name = "baudStartLabel";
            this.baudStartLabel.Size = new System.Drawing.Size(55, 13);
            this.baudStartLabel.TabIndex = 110;
            this.baudStartLabel.Text = "Baud start";
            // 
            // baudStart
            // 
            this.baudStart.Location = new System.Drawing.Point(80, 421);
            this.baudStart.Name = "baudStart";
            this.baudStart.Size = new System.Drawing.Size(100, 20);
            this.baudStart.TabIndex = 4;
            this.baudStart.Text = "50";
            this.baudStart.Enter += new System.EventHandler(this.baudStart_Enter);
            this.baudStart.KeyUp += new System.Windows.Forms.KeyEventHandler(this.textboxKeyUp);
            // 
            // baudIncrement
            // 
            this.baudIncrement.Location = new System.Drawing.Point(283, 421);
            this.baudIncrement.Name = "baudIncrement";
            this.baudIncrement.Size = new System.Drawing.Size(100, 20);
            this.baudIncrement.TabIndex = 5;
            this.baudIncrement.Enter += new System.EventHandler(this.baudIncrement_Enter);
            this.baudIncrement.KeyUp += new System.Windows.Forms.KeyEventHandler(this.textboxKeyUp);
            // 
            // baudEnd
            // 
            this.baudEnd.Location = new System.Drawing.Point(480, 421);
            this.baudEnd.Name = "baudEnd";
            this.baudEnd.Size = new System.Drawing.Size(100, 20);
            this.baudEnd.TabIndex = 6;
            this.baudEnd.Enter += new System.EventHandler(this.baudEnd_Enter);
            this.baudEnd.KeyUp += new System.Windows.Forms.KeyEventHandler(this.textboxKeyUp);
            // 
            // baudIncrementLabel
            // 
            this.baudIncrementLabel.AutoSize = true;
            this.baudIncrementLabel.Location = new System.Drawing.Point(222, 424);
            this.baudIncrementLabel.Name = "baudIncrementLabel";
            this.baudIncrementLabel.Size = new System.Drawing.Size(52, 13);
            this.baudIncrementLabel.TabIndex = 114;
            this.baudIncrementLabel.Text = "Baud inc.";
            // 
            // baudEndLabel
            // 
            this.baudEndLabel.AutoSize = true;
            this.baudEndLabel.Location = new System.Drawing.Point(421, 424);
            this.baudEndLabel.Name = "baudEndLabel";
            this.baudEndLabel.Size = new System.Drawing.Size(53, 13);
            this.baudEndLabel.TabIndex = 115;
            this.baudEndLabel.Text = "Baud end";
            // 
            // writeWavFiles
            // 
            this.writeWavFiles.AutoSize = true;
            this.writeWavFiles.Location = new System.Drawing.Point(15, 527);
            this.writeWavFiles.Name = "writeWavFiles";
            this.writeWavFiles.Size = new System.Drawing.Size(106, 17);
            this.writeWavFiles.TabIndex = 13;
            this.writeWavFiles.Text = "Write WAV file(s)";
            this.writeWavFiles.UseVisualStyleBackColor = true;
            // 
            // playAudio
            // 
            this.playAudio.AutoSize = true;
            this.playAudio.Location = new System.Drawing.Point(142, 527);
            this.playAudio.Name = "playAudio";
            this.playAudio.Size = new System.Drawing.Size(75, 17);
            this.playAudio.TabIndex = 14;
            this.playAudio.Text = "Play audio";
            this.playAudio.UseVisualStyleBackColor = true;
            // 
            // testString
            // 
            this.testString.Location = new System.Drawing.Point(80, 494);
            this.testString.Name = "testString";
            this.testString.Size = new System.Drawing.Size(303, 20);
            this.testString.TabIndex = 12;
            this.testString.Text = "ABCDEFGHIJK";
            this.testString.Enter += new System.EventHandler(this.testString_Enter);
            this.testString.KeyUp += new System.Windows.Forms.KeyEventHandler(this.textboxKeyUp);
            // 
            // testStringLabel
            // 
            this.testStringLabel.AutoSize = true;
            this.testStringLabel.Location = new System.Drawing.Point(12, 497);
            this.testStringLabel.Name = "testStringLabel";
            this.testStringLabel.Size = new System.Drawing.Size(56, 13);
            this.testStringLabel.TabIndex = 117;
            this.testStringLabel.Text = "Test string";
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(943, 582);
            this.Controls.Add(this.testString);
            this.Controls.Add(this.testStringLabel);
            this.Controls.Add(this.playAudio);
            this.Controls.Add(this.writeWavFiles);
            this.Controls.Add(this.baudEndLabel);
            this.Controls.Add(this.baudIncrementLabel);
            this.Controls.Add(this.baudEnd);
            this.Controls.Add(this.baudIncrement);
            this.Controls.Add(this.baudStart);
            this.Controls.Add(this.baudStartLabel);
            this.Controls.Add(this.statusStrip1);
            this.Controls.Add(this.audioLengthMicrosecondsLabel);
            this.Controls.Add(this.audioLengthMicroseconds);
            this.Controls.Add(this.numberOfBitsLabel);
            this.Controls.Add(this.numberOfBits);
            this.Controls.Add(this.toleranceLabel);
            this.Controls.Add(this.tolerance);
            this.Controls.Add(this.exportToCsvButton);
            this.Controls.Add(this.startButton);
            this.Controls.Add(this.boostEnd);
            this.Controls.Add(this.boostEndLabel);
            this.Controls.Add(this.boostIncrement);
            this.Controls.Add(this.boostIncrementLabel);
            this.Controls.Add(this.boostStart);
            this.Controls.Add(this.boostStartLabel);
            this.Controls.Add(this.markFrequencyLabel);
            this.Controls.Add(this.spaceFrequencyLabel);
            this.Controls.Add(this.spaceFrequency);
            this.Controls.Add(this.markFrequency);
            this.Controls.Add(this.mainDataGrid);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.MaximizeBox = false;
            this.Name = "Form1";
            this.Text = "Signal Analyzer";
            ((System.ComponentModel.ISupportInitialize)(this.mainDataGrid)).EndInit();
            this.statusStrip1.ResumeLayout(false);
            this.statusStrip1.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.ComponentModel.BackgroundWorker backgroundWorker1;
        private System.Windows.Forms.TextBox markFrequency;
        private System.Windows.Forms.TextBox spaceFrequency;
        private System.Windows.Forms.Label spaceFrequencyLabel;
        private System.Windows.Forms.Label markFrequencyLabel;
        private System.Windows.Forms.Label boostStartLabel;
        private System.Windows.Forms.TextBox boostStart;
        private System.Windows.Forms.Label boostIncrementLabel;
        private System.Windows.Forms.TextBox boostIncrement;
        private System.Windows.Forms.Label boostEndLabel;
        private System.Windows.Forms.TextBox boostEnd;
        private System.Windows.Forms.Button startButton;
        private System.Windows.Forms.DataGridView mainDataGrid;
        private System.Windows.Forms.Button exportToCsvButton;
        private System.Windows.Forms.Label toleranceLabel;
        private System.Windows.Forms.TextBox tolerance;
        private System.Windows.Forms.Label numberOfBitsLabel;
        private System.Windows.Forms.TextBox numberOfBits;
        private System.Windows.Forms.Label audioLengthMicrosecondsLabel;
        private System.Windows.Forms.TextBox audioLengthMicroseconds;
        private System.Windows.Forms.StatusStrip statusStrip1;
        private System.Windows.Forms.ToolStripStatusLabel toolStripStatusLabel1;
        private System.Windows.Forms.Label baudStartLabel;
        private System.Windows.Forms.TextBox baudStart;
        private System.Windows.Forms.TextBox baudIncrement;
        private System.Windows.Forms.TextBox baudEnd;
        private System.Windows.Forms.Label baudIncrementLabel;
        private System.Windows.Forms.Label baudEndLabel;
        private System.Windows.Forms.ToolTip toolTip1;
        private System.Windows.Forms.ToolStripStatusLabel toolStripStatusLabel2;
        private System.Windows.Forms.CheckBox writeWavFiles;
        private System.Windows.Forms.CheckBox playAudio;
        private System.Windows.Forms.TextBox testString;
        private System.Windows.Forms.Label testStringLabel;
    }
}

