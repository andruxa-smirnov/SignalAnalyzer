﻿using Core.BinaryFskAnalysis;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Linq;
using System.Text;
using System.Windows.Forms;

namespace Gui
{
    public partial class Form1 : Form
    {
        private IList<AnalysisResultEventArgs> _analysisResults;

        public Form1()
        {
            InitializeComponent();

            mainDataGrid.AutoGenerateColumns = false;
            mainDataGrid.ColumnCount = 9;
            mainDataGrid.ColumnHeadersDefaultCellStyle.Alignment = DataGridViewContentAlignment.MiddleCenter;

            var columnNumber = 0;

            mainDataGrid.Columns[columnNumber].Name = "Baud rate";
            mainDataGrid.Columns[columnNumber].HeaderText = "Baud rate";
            mainDataGrid.Columns[columnNumber].DataPropertyName = "BaudRate";
            mainDataGrid.Columns[columnNumber].Frozen = false;
            mainDataGrid.Columns[columnNumber].DefaultCellStyle.Alignment = DataGridViewContentAlignment.MiddleCenter;
            mainDataGrid.Columns[columnNumber].ToolTipText = "Number of symbols (typically bits) per second";
            mainDataGrid.Columns[columnNumber].SortMode = DataGridViewColumnSortMode.NotSortable;
            columnNumber++;

            mainDataGrid.Columns[columnNumber].Name = "Boost (Hz)";
            mainDataGrid.Columns[columnNumber].HeaderText = "Boost (Hz)";
            mainDataGrid.Columns[columnNumber].DataPropertyName = "BoostFrequencyAmount";
            mainDataGrid.Columns[columnNumber].Frozen = false;
            mainDataGrid.Columns[columnNumber].DefaultCellStyle.Alignment = DataGridViewContentAlignment.MiddleCenter;
            mainDataGrid.Columns[columnNumber].ToolTipText = "Amount (in Hz) that the original space and mark frequencies were increased by";
            mainDataGrid.Columns[columnNumber].SortMode = DataGridViewColumnSortMode.NotSortable;
            columnNumber++;

            mainDataGrid.Columns[columnNumber].Name = "Avg diff (Hz)";
            mainDataGrid.Columns[columnNumber].HeaderText = "Avg diff (Hz)";
            mainDataGrid.Columns[columnNumber].DataPropertyName = "AverageFrequencyDifference";
            mainDataGrid.Columns[columnNumber].Frozen = false;
            mainDataGrid.Columns[columnNumber].DefaultCellStyle.Format = "0.0";
            mainDataGrid.Columns[columnNumber].DefaultCellStyle.Alignment = DataGridViewContentAlignment.MiddleCenter;
            mainDataGrid.Columns[columnNumber].ToolTipText = "Average difference (in Hz) of expected space or mark frequency and actual detected frequency";
            mainDataGrid.Columns[columnNumber].SortMode = DataGridViewColumnSortMode.NotSortable;
            columnNumber++;

            mainDataGrid.Columns[columnNumber].Name = "Min diff (Hz)";
            mainDataGrid.Columns[columnNumber].HeaderText = "Min diff (Hz)";
            mainDataGrid.Columns[columnNumber].DataPropertyName = "MinimumFrequencyDifference";
            mainDataGrid.Columns[columnNumber].Frozen = false;
            mainDataGrid.Columns[columnNumber].DefaultCellStyle.Format = "0.0";
            mainDataGrid.Columns[columnNumber].DefaultCellStyle.Alignment = DataGridViewContentAlignment.MiddleCenter;
            mainDataGrid.Columns[columnNumber].ToolTipText = "Minimum difference (in Hz) of expected space or mark frequency and actual detected frequency";
            mainDataGrid.Columns[columnNumber].SortMode = DataGridViewColumnSortMode.NotSortable;
            columnNumber++;

            mainDataGrid.Columns[columnNumber].Name = "Max diff (Hz)";
            mainDataGrid.Columns[columnNumber].HeaderText = "Max diff (Hz)";
            mainDataGrid.Columns[columnNumber].DataPropertyName = "MaximumFrequencyDifference";
            mainDataGrid.Columns[columnNumber].Frozen = false;
            mainDataGrid.Columns[columnNumber].DefaultCellStyle.Format = "0.0";
            mainDataGrid.Columns[columnNumber].DefaultCellStyle.Alignment = DataGridViewContentAlignment.MiddleCenter;
            mainDataGrid.Columns[columnNumber].ToolTipText = "Maximum difference (in Hz) of expected space or mark frequency and actual detected frequency";
            mainDataGrid.Columns[columnNumber].SortMode = DataGridViewColumnSortMode.NotSortable;
            columnNumber++;

            mainDataGrid.Columns[columnNumber].Name = "# > tolerance";
            mainDataGrid.Columns[columnNumber].HeaderText = "# > tolerance";
            mainDataGrid.Columns[columnNumber].DataPropertyName = "NumberOfMissedFrequencies";
            mainDataGrid.Columns[columnNumber].Frozen = false;
            mainDataGrid.Columns[columnNumber].DefaultCellStyle.Alignment = DataGridViewContentAlignment.MiddleCenter;
            mainDataGrid.Columns[columnNumber].ToolTipText = "Number of times that the detected frequency was outside of the supplied frequency deviation tolerance";
            mainDataGrid.Columns[columnNumber].SortMode = DataGridViewColumnSortMode.NotSortable;
            columnNumber++;

            mainDataGrid.Columns[columnNumber].Name = "# zero freq";
            mainDataGrid.Columns[columnNumber].HeaderText = "# zero freq";
            mainDataGrid.Columns[columnNumber].DataPropertyName = "NumberOfZeroFrequencies";
            mainDataGrid.Columns[columnNumber].Frozen = false;
            mainDataGrid.Columns[columnNumber].DefaultCellStyle.Alignment = DataGridViewContentAlignment.MiddleCenter;
            mainDataGrid.Columns[columnNumber].ToolTipText = "Number of times that the detected frequency was zero";
            mainDataGrid.Columns[columnNumber].SortMode = DataGridViewColumnSortMode.NotSortable;
            columnNumber++;

            mainDataGrid.Columns[columnNumber].Name = "Output";
            mainDataGrid.Columns[columnNumber].HeaderText = "Output";
            mainDataGrid.Columns[columnNumber].DataPropertyName = "ResultingString";
            mainDataGrid.Columns[columnNumber].Frozen = false;
            mainDataGrid.Columns[columnNumber].DefaultCellStyle.Alignment = DataGridViewContentAlignment.MiddleCenter;
            mainDataGrid.Columns[columnNumber].ToolTipText = "The string that resulted from decoding the encoded signal";
            mainDataGrid.Columns[columnNumber].SortMode = DataGridViewColumnSortMode.NotSortable;
            columnNumber++;

            mainDataGrid.Columns[columnNumber].Name = "Match?";
            mainDataGrid.Columns[columnNumber].HeaderText = "Match?";
            mainDataGrid.Columns[columnNumber].DataPropertyName = "Matched";
            mainDataGrid.Columns[columnNumber].Frozen = false;
            mainDataGrid.Columns[columnNumber].DefaultCellStyle.Alignment = DataGridViewContentAlignment.MiddleCenter;
            mainDataGrid.Columns[columnNumber].ToolTipText = "Whether or not the decoded signal matched the encoded signal";
            mainDataGrid.Columns[columnNumber].SortMode = DataGridViewColumnSortMode.NotSortable;
            columnNumber++;

            _analysisResults = new BindingList<AnalysisResultEventArgs>();
            mainDataGrid.DataSource = _analysisResults;

            backgroundWorker1.ProgressChanged += BackgroundWorker1_ProgressChanged;

            startButton.Select();

            toolStripStatusLabel1.Text = $"Build {System.Reflection.Assembly.GetExecutingAssembly().GetName().Version}";
            statusStrip1.Refresh();
        }

        private void startButton_Click(object sender, EventArgs e)
        {
            startButton.Enabled = false;
            exportToCsvButton.Enabled = false;

            _analysisResults.Clear();

            numberOfBitsLabel.Enabled = false;
            numberOfBits.Enabled = false;
            audioLengthMillisecondsLabel.Enabled = false;
            audioLengthMilliseconds.Enabled = false;
            numberOfBits.Text = string.Empty;
            audioLengthMilliseconds.Text = string.Empty;

            backgroundWorker1.RunWorkerAsync();
        }

        private void backgroundWorker1_DoWork(object sender, System.ComponentModel.DoWorkEventArgs e)
        {
            TestRunnerArguments testRunnerArguments = null;
            try
            {
                testRunnerArguments = ProcessArguments(
                    new FormInput
                    {
                        SpaceFrequency = spaceFrequency.Text,
                        MarkFrequency = markFrequency.Text,
                        Tolerance = tolerance.Text,
                        BaudStart = baudStart.Text,
                        BaudIncrement = baudIncrement.Text,
                        BaudEnd = baudEnd.Text,
                        BoostStart = boostStart.Text,
                        BoostIncrement = boostIncrement.Text,
                        BoostEnd = boostEnd.Text
                    }
                );
            }
            catch (ArgumentException ex)
            {
                MessageBox.Show(ex.Message, "Input validation");
                return;
            }

            var testRunner = new TestRunner();
            testRunner.FskAnalyzer.AnalysisCompleted += AnalysisCompletedHandler;
            testRunner.SignalGenerationCompleted += SignalGenerationCompletedHandler;
            testRunner.Run(testRunnerArguments);
        }

        private void BackgroundWorker1_ProgressChanged(object sender, ProgressChangedEventArgs e)
        {
            if (e.UserState is AnalysisResultEventArgs)
            {
                var analysisResult = (AnalysisResultEventArgs)e.UserState;
                _analysisResults.Add(analysisResult);

                if (analysisResult.Matched == true)
                {
                    mainDataGrid.Rows[mainDataGrid.RowCount - 1].Cells[mainDataGrid.ColumnCount - 1].Style.BackColor = System.Drawing.Color.Green;
                }
                else
                {
                    mainDataGrid.Rows[mainDataGrid.RowCount - 1].Cells[mainDataGrid.ColumnCount - 1].Style.BackColor = System.Drawing.Color.Red;
                }

                mainDataGrid.FirstDisplayedScrollingRowIndex = mainDataGrid.RowCount - 1;
            }
            else
            {
                var signalGenerationResult = (SignalGenerationResultEventArgs)e.UserState;
                numberOfBits.Text = signalGenerationResult.NumberOfBits.ToString();
                audioLengthMilliseconds.Text = (signalGenerationResult.AudioLengthInMilliseconds / 1000.0).ToString();
                numberOfBitsLabel.Enabled = true;
                numberOfBits.Enabled = true;
                audioLengthMillisecondsLabel.Enabled = true;
                audioLengthMilliseconds.Enabled = true;
            }
        }

        private void backgroundWorker1_RunWorkerCompleted(object sender, RunWorkerCompletedEventArgs e)
        {
            if (mainDataGrid.RowCount > 0)
            {
                mainDataGrid.FirstDisplayedScrollingRowIndex = 0;
                exportToCsvButton.Enabled = true;
            }

            startButton.Enabled = true;
        }

        private void AnalysisCompletedHandler(object sender, AnalysisResultEventArgs e)
        {
            backgroundWorker1.ReportProgress(0, e);
        }

        private void SignalGenerationCompletedHandler(object sender, SignalGenerationResultEventArgs e)
        {
            backgroundWorker1.ReportProgress(0, e);
        }

        private void exportToCsvButton_Click(object sender, EventArgs e)
        {
            SaveCsvFile();
        }

        private void SaveCsvFile()
        {
            var csvStringBuilder = new StringBuilder();

            var headers = mainDataGrid.Columns.Cast<DataGridViewColumn>();
            csvStringBuilder.AppendLine(string.Join(",", headers.Select(column => "\"" + column.HeaderText + "\"").ToArray()));

            foreach (DataGridViewRow row in mainDataGrid.Rows)
            {
                var cells = row.Cells.Cast<DataGridViewCell>();
                csvStringBuilder.AppendLine(string.Join(",", cells.Select(cell => "\"" + cell.Value.ToString().Replace("\"", "") + "\"").ToArray()));
            }

            var saveFileDialog = new SaveFileDialog();
            saveFileDialog.Filter = "CSV|*.csv";
            saveFileDialog.Title = "Save CSV file";
            saveFileDialog.InitialDirectory = Environment.GetFolderPath(Environment.SpecialFolder.Desktop);
            saveFileDialog.ShowDialog();

            if (!string.IsNullOrEmpty(saveFileDialog.FileName))
            {
                var fileStream = (System.IO.FileStream)saveFileDialog.OpenFile();
                fileStream.Write(Encoding.ASCII.GetBytes(csvStringBuilder.ToString()), 0, csvStringBuilder.ToString().Count());
                fileStream.Close();
            }
        }

        private TestRunnerArguments ProcessArguments(FormInput request)
        {
            if (string.IsNullOrWhiteSpace(request.SpaceFrequency))
            {
                throw new ArgumentException("Space frequency cannot be empty");
            }

            if (string.IsNullOrWhiteSpace(request.MarkFrequency))
            {
                throw new ArgumentException("Mark frequency cannot be empty");
            }

            if (string.IsNullOrWhiteSpace(request.Tolerance))
            {
                throw new ArgumentException("Tolerance cannot be empty");
            }

            if (string.IsNullOrWhiteSpace(request.BaudStart))
            {
                throw new ArgumentException("Baud start cannot be empty");
            }

            int spaceFrequencyParsed = int.Parse(request.SpaceFrequency);
            int markFrequencyParsed = int.Parse(request.MarkFrequency);
            int toleranceParsed = int.Parse(request.Tolerance);

            int baudStartParsed = int.Parse(request.BaudStart);
            int? baudIncrementParsed = null;
            int? baudEndParsed = null;

            double? boostStartParsed = null;
            double? boostIncrementParsed = null;
            double? boostEndParsed = null;

            if (! string.IsNullOrEmpty(request.BaudIncrement))
            {
                baudIncrementParsed = int.Parse(request.BaudIncrement);
            }

            if (! string.IsNullOrEmpty(request.BaudEnd))
            {
                baudEndParsed = int.Parse(request.BaudEnd);
            }

            if (! string.IsNullOrEmpty(request.BoostStart))
            {
                boostStartParsed = int.Parse(request.BoostStart);
            }

            if (! string.IsNullOrEmpty(request.BoostIncrement))
            {
                boostIncrementParsed = int.Parse(request.BoostIncrement);
            }

            if (! string.IsNullOrEmpty(request.BoostEnd))
            {
                boostEndParsed = int.Parse(request.BoostEnd);
            }

            if ((baudIncrementParsed != null || baudEndParsed != null) && (baudIncrementParsed == null || baudEndParsed == null))
            {
                throw new ArgumentException("You must specify both baud increment and baud end if either are specified");
            }

            if ((boostStartParsed != null || boostIncrementParsed != null || boostEndParsed != null) &&
                (boostStartParsed == null || boostIncrementParsed == null || boostEndParsed == null))
            {
                throw new ArgumentException(
                    "You must specify boost start, boost increment, and boost end if any boost parameters are specified"
                );
            }

            baudIncrementParsed = baudIncrementParsed != null ? baudIncrementParsed : 1;
            baudEndParsed = baudEndParsed != null ? baudEndParsed : baudStartParsed;

            boostStartParsed = boostStartParsed != null ? boostStartParsed : 0;
            boostIncrementParsed = boostIncrementParsed != null ? boostIncrementParsed : 1;
            boostEndParsed = boostEndParsed != null ? boostEndParsed : boostStartParsed;

            return new TestRunnerArguments
            {
                SpaceFrequency = spaceFrequencyParsed,
                MarkFrequency = markFrequencyParsed,
                Tolerance = toleranceParsed,
                BaudStart = baudStartParsed,
                BaudIncrement = baudIncrementParsed.Value,
                BaudEnd = baudEndParsed.Value,
                BoostStart = boostStartParsed.Value,
                BoostIncrement = boostIncrementParsed.Value,
                BoostEnd = boostEndParsed.Value
            };
        }

        private void mainDataGrid_CellContentClick(object sender, DataGridViewCellEventArgs e) {}
        private void form1BindingSource_CurrentChanged(object sender, EventArgs e) {}
        private void Form1_Load(object sender, EventArgs e) {}

        private class FormInput
        {
            public string SpaceFrequency { get; set; }
            public string MarkFrequency { get; set; }
            public string Tolerance { get; set; }

            public string BaudStart { get; set; }
            public string BaudIncrement { get; set; }
            public string BaudEnd { get; set; }

            public string BoostStart { get; set; }
            public string BoostIncrement { get; set; }
            public string BoostEnd { get; set; }
        }
    }
}
