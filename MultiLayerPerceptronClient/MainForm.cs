using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Drawing;
using System.IO;
using System.Linq;
using System.Windows.Forms;
using MultiLayerPerceptronClient.Properties;
using NeuralNetworks.EventsArgs;
using NeuralNetworks.Models;
using NeuralNetworks.Utility;

namespace MultiLayerPerceptronClient
{
    public partial class MainForm : Form
    {
        private List<NumericUpDown> _numLayersList;
        private MultiLayerPerceptron _mlp;
        private CreateButtonState _createButtonState;
        private TeachButtonState _teachButtonState;
        private string _datafilePath;
        private int _iterations;
        private double _learningRate;

        private const char _separator = '\t';
        private const char _decimalPoint = '.';

        private enum CreateButtonState
        {
            Create,
            Back
        }
        private enum TeachButtonState
        {
            Teach,
            Abort
        }

        public MainForm()
        {
            InitializeComponent();
            InitializeControls();
        }

        private void InitializeControls()
        {
            _numLayersList = grpBoxLayers.Controls
                .OfType<NumericUpDown>()
                .OrderBy(num => num.Name)
                .ToList();
            folderBrowser.SelectedPath = Application.StartupPath;
            SetDataPathAndFileComboBoxes();
            _createButtonState = CreateButtonState.Create;
            _teachButtonState = TeachButtonState.Teach;
        }

        private void SetDataPathAndFileComboBoxes()
        {
            txtBoxFolder.Text = folderBrowser.SelectedPath;
            AddItemsToComboBox(cmbBoxTeachingFiles, GetFileNamesFromFolder());
            AddItemsToComboBox(cmbBoxTestingFiles, GetFileNamesFromFolder());
        }

        private object[] GetFileNamesFromFolder()
        {
            var dirInfo = new DirectoryInfo(txtBoxFolder.Text);
            var filesInfo = dirInfo.GetFiles("*.txt");
            var filesNames = new object[filesInfo.Length];

            for (int fileIndex = 0; fileIndex < filesInfo.Length; fileIndex++)
            {
                filesNames[fileIndex] = filesInfo[fileIndex].Name;
            }

            return filesNames;
        }

        private void AddItemsToComboBox(ComboBox comboBox, object[] itemsToAdd)
        {
            comboBox.Items.Clear();
            comboBox.Items.AddRange(itemsToAdd);
        }

        private void numLayers_ValueChanged(object sender, EventArgs e)
        {
            var controlsToSet = Convert.ToInt32(numLayers.Value);

            if (AddedNewLayer(controlsToSet))
            {
                EnableLayersNumericControls(controlsToSet);
            }
            else
            {
                DisableLayersNumericControls(controlsToSet);
            }
        }

        private void DisableLayersNumericControls(int controlsToSet)
        {
            var enabledNumsCount = _numLayersList.Count(numControl => numControl.Enabled);
            const int listOffset = 1;

            for (int index = enabledNumsCount - listOffset; index > controlsToSet - listOffset; index--)
            {
                _numLayersList[index].Enabled = false;
                _numLayersList[index].Maximum = 1;
                _numLayersList[index].Minimum = 0;
                _numLayersList[index].Value = 0;
            }

            _numLayersList[controlsToSet - 1].Maximum = 1;
        }

        private void EnableLayersNumericControls(int controlsToSet)
        {
            for (int index = 0; index < controlsToSet; index++)
            {
                _numLayersList[index].Enabled = true;
                _numLayersList[index].Maximum = 100;
                _numLayersList[index].Minimum = 1;
            }

            _numLayersList[controlsToSet - 1].Maximum = 1;
        }

        private bool AddedNewLayer(int numLayersValue)
        {
            var enabledNumsCount = _numLayersList.Count(numControl => numControl.Enabled);

            return numLayersValue > enabledNumsCount;
        }

        private void btnCreateBack_Click(object sender, EventArgs e)
        {
            if (_createButtonState == CreateButtonState.Create)
            {
                try
                {
                    ValidateSelectedActivationFunc();
                    InitializeMlp();
                }
                catch (Exception exception)
                {
                    SetStatusStrip(Color.Red, exception.Message);
                    return;
                }

                grpBoxTeach.Enabled = true;
                SwitchConfigGrpBoxControls(false);
                btnCreateBack.Text = Resources.MainForm_btnCreateBack_Click_Back_to_configuration;

                SetStatusStrip(Color.Green, Resources.MainForm_statusStripInfo_Network_created);
                _createButtonState = CreateButtonState.Back;
            }
            else
            {
                SwitchConfigGrpBoxControls(true);
                grpBoxTeach.Enabled = false;
                grpBoxTest.Enabled = false;
                btnCreateBack.Text = Resources.MainForm_btnCreateBack_Click_Create_a_network;

                SetStatusStrip(Color.LightBlue, "");
                _createButtonState = CreateButtonState.Create;
            }
        }

        private void SwitchConfigGrpBoxControls(bool enabledState)
        {
            grpBoxLayers.Enabled = enabledState;
            numInputs.Enabled = enabledState;
            numLayers.Enabled = enabledState;
            cmbBoxActivationFunc.Enabled = enabledState;
            lblNumNeurons.Enabled = enabledState;
            lblNumInputs.Enabled = enabledState;
            lblActivationFunc.Enabled = enabledState;
        }

        private void InitializeMlp()
        {
            var numberOfLayers = Convert.ToInt32(numLayers.Value);
            var enabledNumLayers = _numLayersList.Where(numControl => numControl.Enabled).ToList();
            var inputsPerLayer = ReadInputsPerLayer(enabledNumLayers);
            var neuronsPerLayer = ReadNeuronsPerLayer(enabledNumLayers);
            var activationFunction = GetActivationFunctionType();
            _mlp = new MultiLayerPerceptron(numberOfLayers, inputsPerLayer, neuronsPerLayer, activationFunction);
        }

        private Delegates.ActivationFunction GetActivationFunctionType()
        {
            if (cmbBoxActivationFunc.SelectedIndex == 0)
            {
                return Functions.SigmoidBipolar;
            }

            return Functions.SigmoidUnipolar;
        }

        private void ValidateSelectedActivationFunc()
        {
            if (cmbBoxActivationFunc.SelectedItem == null)
            {
                throw new InvalidOperationException("You must select Activation function.");
            }
        }

        private List<int> ReadNeuronsPerLayer(List<NumericUpDown> enabledNumLayers)
        {
            var neuronsPerLayer = new List<int>();

            neuronsPerLayer.AddRange(enabledNumLayers.Select(numEnabledLayer => Convert.ToInt32(numEnabledLayer.Value)));

            return neuronsPerLayer;
        }

        private List<int> ReadInputsPerLayer(List<NumericUpDown> enabledNumLayers)
        {
            var inputsPerLayer = new List<int>();
            var numHiddenLayers =
                enabledNumLayers
                .Where(numControl => numControl.Maximum != 1)
                .ToList();

            var biasInput = 1;
            var firstInput = Convert.ToInt32(numInputs.Value) + biasInput;

            inputsPerLayer.Add(firstInput);
            inputsPerLayer.AddRange(numHiddenLayers.Select(numHiddenLayer => Convert.ToInt32(numHiddenLayer.Value)));

            return inputsPerLayer;
        }

        private void SetStatusStrip(Color statusColor, string statusText)
        {
            statusStrip.BackColor = statusColor;
            statusStripInfo.Text = statusText;
        }

        private void btnSelect_Click(object sender, EventArgs e)
        {
            ChooseFolder();
            SetStatusStrip(Color.LightBlue, "");
        }

        private void ChooseFolder()
        {
            if (folderBrowser.ShowDialog() == DialogResult.OK)
            {
                SetDataPathAndFileComboBoxes();
            }
        }

        private void btnRefresh_Click(object sender, EventArgs e)
        {
            AddItemsToComboBox(cmbBoxTeachingFiles, GetFileNamesFromFolder());
            AddItemsToComboBox(cmbBoxTestingFiles, GetFileNamesFromFolder());
            SetStatusStrip(Color.LightBlue, "");
        }

        private void btnTeachAbort_Click(object sender, EventArgs e)
        {
            if (_teachButtonState == TeachButtonState.Teach)
            {
                SetStatusStrip(Color.LightBlue, "");

                if (cmbBoxTeachingFiles.SelectedItem == null)
                {
                    SetStatusStrip(Color.Red, Resources.MainForm_statusStripInfo_Select_data_file_to_learn);
                    return;
                }

                _datafilePath = $"{folderBrowser.SelectedPath}\\{cmbBoxTeachingFiles.SelectedItem}";
                _iterations = Convert.ToInt32(numIterations.Value);
                _learningRate = Convert.ToDouble(numLearningRate.Value);

                SwitchTeachingGrpBoxControls(false);

                bgWorker.RunWorkerAsync();

                

                btnTeachAbort.Text = Resources.MainForm_btnTeachAbort_Click_Abort_teaching;
                _teachButtonState = TeachButtonState.Abort;
            }
            else
            {
                _mlp.AbortTeaching();
                bgWorker.CancelAsync();
            }
        }

        private void SwitchTeachingGrpBoxControls(bool enabledState)
        {
            btnSelect.Enabled = enabledState;
            btnRefresh.Enabled = enabledState;
            btnResetWeights.Enabled = enabledState;
            cmbBoxTeachingFiles.Enabled = enabledState;
            numIterations.Enabled = enabledState;
            numLearningRate.Enabled = enabledState;
            grpBoxTest.Enabled = enabledState;
        }

        private void bgWorker_DoWork(object sender, DoWorkEventArgs e)
        {
            _mlp.TeachingProgressChanged += OnTeachingProgressChanged;

            try
            {
                _mlp.Teach(_datafilePath, _separator, _decimalPoint, _iterations, _learningRate);
            }
            catch (Exception ex)
            {
                statusStrip.Invoke(new Action(() => SetStatusStrip(Color.Red, ex.Message)));
                SetTeachingButtonInBgWorker();
                Invoke(new Action(() => SwitchTeachingGrpBoxControls(true)));
                return;
            }

            if (bgWorker.CancellationPending)
            {
                statusStrip.Invoke(new Action(() => SetStatusStrip(Color.Orange, Resources.MainForm_statusStripInfo_Teaching_aborted)));
            }
            else
            {
                statusStrip.Invoke(new Action(() => SetStatusStrip(Color.Green, Resources.MainForm_statusStripInfo_Teaching_done)));
            }

            Invoke(new Action (() => SwitchTeachingGrpBoxControls(true)));
            SetTeachingButtonInBgWorker();
            _mlp.TeachingProgressChanged -= OnTeachingProgressChanged;
        }

        private void SetTeachingButtonInBgWorker()
        {
            btnTeachAbort.Invoke(new Action(() => btnTeachAbort.Text = Resources.MainForm_btnTeachAbort_Click_Teach));
            _teachButtonState = TeachButtonState.Teach;
        }

        public void OnTeachingProgressChanged(object sender, ProgressEventArgs e)
        {
            progBarTeaching.Invoke(new Action(() => progBarTeaching.Value = e.Progress));
        }

        private void btnResetWeights_Click(object sender, EventArgs e)
        {
            try
            {
                _mlp.ResetWeights();
            }
            catch (Exception exception)
            {
                SetStatusStrip(Color.Red, exception.Message);
                return;
            }

            SetStatusStrip(Color.Green, Resources.MainForm_statusStripInfo_Weights_were_reset);
        }

        private void btnTest_Click(object sender, EventArgs e)
        {
            ClearResultTextBoxes();
            SetStatusStrip(Color.LightBlue, "");

            if (cmbBoxTestingFiles.SelectedItem == null)
            {
                SetStatusStrip(Color.Red, Resources.MainForm_statusStripInfo_Select_data_file_to_test);
            }

            _datafilePath = $"{folderBrowser.SelectedPath}\\{cmbBoxTestingFiles.SelectedItem}";
            List<Tuple<double, double>> results;

            try
            {
                results = _mlp.Test(_datafilePath, _separator, _decimalPoint);
            }
            catch (Exception exception)
            {
                SetStatusStrip(Color.Red, exception.Message);
                return;
            }

            SetResultsGroupBox(results);
            SetStatusStrip(Color.Green, Resources.MainForm_statusStripInfo_Testing_done_check_results);
        }

        private void SetResultsGroupBox(List<Tuple<double, double>> results)
        {
            foreach (var result in results)
            {
                txtBoxExpected.Text += result.Item1 + Environment.NewLine;
                txtBoxCalculated.Text += result.Item2 + Environment.NewLine;
            }
        }

        private void ClearResultTextBoxes()
        {
            txtBoxExpected.Clear();
            txtBoxCalculated.Clear();
        }
    }
}
