using System;
using System.Collections.Generic;
using System.Drawing;
using System.IO;
using System.Linq;
using System.Windows.Forms;
using HopfieldNetworkClient.Properties;
using MathNet.Numerics.LinearAlgebra;
using NeuralNetworks.Models;
using NeuralNetworks.Utility;

namespace HopfieldNetworkClient
{
    public partial class MainForm : Form
    {
        private HopfieldNetwork _hopfieldNetwork;
        private double[] _clearedData = { -1.0, -1, -1, -1, -1, -1, -1, -1, -1, -1, -1, -1, -1, -1, -1 };

        public MainForm()
        {
            InitializeComponent();
            InitializeControls();
            _hopfieldNetwork = new HopfieldNetwork();
        }

        private void buttonSelect_Click(object sender, EventArgs e)
        {
            ChooseFolder();
            SetStatusStrip(Color.LightBlue, "");
        }

        private void buttonRefresh_Click(object sender, EventArgs e)
        {
            AddItemsToComboBox(comboBoxFiles, GetFileNamesFromFolder());
            SetStatusStrip(Color.LightBlue, "");
        }

        private void buttonTeach_Click(object sender, EventArgs e)
        {
            if (comboBoxFiles.SelectedItem == null)
            {
                SetStatusStrip(Color.Red, Resources.statusStripInfo_SelectDataError);
                return;
            }

            try
            {
                var datafilePath = $"{folderBrowser.SelectedPath}\\{comboBoxFiles.SelectedItem}";
                var separator = ' ';
                _hopfieldNetwork.TeachWithHebbsRule(datafilePath, separator);
            }
            catch (Exception ex)
            {
                SetStatusStrip(Color.Red, ex.Message);
                return;
            }

            SetStatusStrip(Color.Green, "Teaching done");
            buttonTest.Enabled = true;
        }

        private void chBox_CheckedChanged(object sender, EventArgs e)
        {
            var chBox = sender as CheckBox;

            if (chBox != null)
            {
                chBox.CheckState = chBox.Checked ? CheckState.Indeterminate : CheckState.Unchecked;
            }

            FillTextBoxByData(textBoxPatternVector, GetVectorFromPattern());
        }

        private void buttonClear_Click(object sender, EventArgs e)
        {
            FillTextBoxByData(textBoxPatternVector, _clearedData);
            var checkBoxes = GetPatternCheckBoxes();

            foreach (var checkBox in checkBoxes)
            {
                checkBox.CheckState = CheckState.Unchecked;
            }
        }

        private void buttonTest_Click(object sender, EventArgs e)
        {
            var testingVector = Vector<double>.Build.DenseOfArray(GetVectorFromPattern());
            NeuralVector outputVector;

            try
            {
                outputVector = _hopfieldNetwork.Test(new NeuralVector(testingVector));
            }
            catch (Exception exception)
            {
                SetStatusStrip(Color.Red, exception.Message);
                return;
            }

            FillTextBoxByData(textBoxOutputVector, outputVector.Data);
            FillPatternByOutput(outputVector);

            SetStatusStrip(Color.LightBlue, "");
        }

        private void InitializeControls()
        {
            folderBrowser.SelectedPath = Application.StartupPath;
            SetDataPathAndFileComboBox();
            FillTextBoxByData(textBoxPatternVector, _clearedData);
            ActiveControl = buttonSelect;
            buttonTest.Enabled = false;
        }

        private void ChooseFolder()
        {
            if (folderBrowser.ShowDialog() == DialogResult.OK)
            {
                SetDataPathAndFileComboBox();
            }
        }

        private void SetDataPathAndFileComboBox()
        {
            textBoxFolder.Text = folderBrowser.SelectedPath;
            AddItemsToComboBox(comboBoxFiles, GetFileNamesFromFolder());
        }

        private void AddItemsToComboBox(ComboBox comboBox, object[] itemsToAdd)
        {
            comboBox.Items.Clear();
            comboBox.Items.AddRange(itemsToAdd);
        }

        private object[] GetFileNamesFromFolder()
        {
            var dirInfo = new DirectoryInfo(textBoxFolder.Text);
            var filesInfo = dirInfo.GetFiles("*.txt");
            var filesNames = new object[filesInfo.Length];

            for (int fileIndex = 0; fileIndex < filesInfo.Length; fileIndex++)
            {
                filesNames[fileIndex] = filesInfo[fileIndex].Name;
            }

            return filesNames;
        }

        private void FillTextBoxByData(TextBox textBox, IEnumerable<double> data)
        {
            textBox.Text = string.Join(", ", data);
        }

        private void SetStatusStrip(Color statusColor, string statusText)
        {
            statusStrip.BackColor = statusColor;
            statusStripInfo.Text = statusText;
        }

        private double[] GetVectorFromPattern()
        {
            var vector = new List<double>();
            var checkBoxes = GetPatternCheckBoxes();

            foreach (var checkBox in checkBoxes)
            {
                if (checkBox.CheckState == CheckState.Indeterminate)
                {
                    vector.Add(1.0);
                }
                else
                {
                    vector.Add(-1.0);
                }
            }

            return vector.ToArray();
        }

        private List<CheckBox> GetPatternCheckBoxes()
        {
            return groupBoxPattern.Controls.OfType<CheckBox>().OrderBy(chBox => chBox.Name).ToList();
        }

        private void FillPatternByOutput(NeuralVector outputVector)
        {
            var checkBoxes = GetPatternCheckBoxes();

            checkBoxes.ForEach(checkBox => checkBox.CheckedChanged -= chBox_CheckedChanged);

            for (int index = 0; index < checkBoxes.Count; index++)
            {
                if (outputVector.Data[index] == 1.0)
                {
                    checkBoxes[index].CheckState = CheckState.Indeterminate;
                }
                else
                {
                    checkBoxes[index].CheckState = CheckState.Unchecked;
                }
            }

            checkBoxes.ForEach(checkBox => checkBox.CheckedChanged += chBox_CheckedChanged);
        }
    }
}
