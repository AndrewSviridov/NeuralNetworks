using System;
using System.Drawing;
using System.Windows.Forms;
using NeuralNetworks.Models;
using SelfOrganizingMapClient.Helpers;
using SelfOrganizingMapClient.Properties;
using SelfOrganizingMapClient.Shapes;

namespace SelfOrganizingMapClient
{
    public partial class MainForm : Form
    {
        private Drawer _drawer;
        private Randomizer _randomizer;
        private Triangle _triangle;
        private SelfOrganizingMap _som;
        private SimulationState _simulationState;
        private int _neuronsCount;
        private int _areaSize;
        private int _pointsDiameter = 4;
        private int _lineWidth = 1;

        private int _mapRadius;
        private int _iteration = 1;
        private int _maxIterations;
        private double _timeConst;
        private const double _startLearningRate = 1.0;

        private int _neighborRadius;

        public MainForm()
        {
            InitializeComponent();
            InitializeControls();
        }

        private void buttonGenerate_Click(object sender, EventArgs e)
        {
            _simulationState = SimulationState.New;
            btnStartPause.Enabled = true;
            btnStop.Enabled = false;

            ReadControlsValues();
            UpdateIterationInfo();

            _drawer.ClearArea();
            _drawer.DrawTriangle(_triangle, Color.Black);
            InitializeSom();
            RefreshArea();
        }

        private void buttonStartPause_Click(object sender, EventArgs e)
        {
            switch (_simulationState)
            {
                case SimulationState.New:
                    btnStartPause.Text = Resources.buttonText_Pause;
                    btnGenerate.Enabled = false;
                    btnStop.Enabled = true;
                    numNeurons.Enabled = false;

                    timer.Enabled = true;
                    timer.Start();

                    _simulationState = SimulationState.Started;
                    break;
                case SimulationState.Started:
                    btnStartPause.Text = Resources.buttonText_Resume;

                    timer.Stop();

                    _simulationState = SimulationState.Paused;
                    break;
                case SimulationState.Paused:
                    btnStartPause.Text = Resources.buttonText_Pause;

                    timer.Start();

                    _simulationState = SimulationState.Started;
                    break;
            }
        }

        private void buttonStop_Click(object sender, EventArgs e)
        {
            timer.Stop();
            timer.Enabled = false;

            btnStartPause.Text = Resources.buttonText_Start;
            btnStartPause.Enabled = false;
            btnGenerate.Enabled = true;
            numNeurons.Enabled = true;
        }

        private void timer_Tick(object sender, EventArgs e)
        {
            var coordRange = new CoordRange(_triangle.Left.X, _triangle.Right.X, _triangle.Up.Y, _triangle.Right.Y);

            if (_iteration <= _maxIterations)
            {
                _drawer.ClearArea();

                var point = _randomizer.RandomizePointInTriangle(coordRange, _areaSize);
                var node = Translator.TranslatePointToNode(point);

                var radius = CalculateRadius();
                var learningRate = CalculateLearningRate();
                
                ChangeNeighborRadius();

                var nodes = _som.ModifyNodes(node, radius, learningRate, _neighborRadius);
                var points = Translator.TranslateNodesToPoints(nodes);

                _drawer.DrawTriangle(_triangle, Color.Black);
                _drawer.DrawPoints(points, _pointsDiameter, Color.Green, PointType.Filled);
                _drawer.DrawLines(points, _lineWidth, Color.Blue);
                _drawer.DrawPoint(point, _pointsDiameter, Color.Red, PointType.Filled);

                RefreshArea();
                UpdateIterationInfo();

                _iteration++;
            }
            else
            {
                btnGenerate.Enabled = true;
                btnStartPause.Enabled = false;
                btnStop.Enabled = false;
                timer.Stop();
            }
        }


        private void InitializeControls()
        {
            _areaSize = picBoxMap.Width;
            _mapRadius = _areaSize / 2;

            ReadControlsValues();
            UpdateIterationInfo();

            picBoxMap.Image = new Bitmap(picBoxMap.Width, picBoxMap.Height);
            _drawer = new Drawer(picBoxMap.Image);
            _randomizer = new Randomizer();
            _triangle = InitializeTriangle(picBoxMap.Width);

            _drawer.DrawTriangle(_triangle, Color.Black);
        }

        private void ReadControlsValues()
        {
            _neuronsCount = Convert.ToInt32(numNeurons.Value);
            _maxIterations = _neuronsCount * 100;
            _timeConst = _maxIterations / Math.Log(_mapRadius);

            _neighborRadius = _neuronsCount / 10;
        }

        private void InitializeSom()
        {
            ReadControlsValues();
            var startedRange = new CoordRange(200, 300, 250, 350);
            var nodes = _randomizer.RandomizeStartedNodesInTriangle(_neuronsCount, startedRange, _areaSize);
            var points = Translator.TranslateNodesToPoints(nodes);

            _drawer.DrawPoints(points, _pointsDiameter, Color.Green, PointType.Filled);
            _drawer.DrawLines(points, _lineWidth, Color.Blue);

            _som = new SelfOrganizingMap(nodes);
        }

        private double CalculateRadius()
        {
            return _mapRadius * Math.Exp(-_iteration / _timeConst);
        }

        private double CalculateLearningRate()
        {
            return _startLearningRate * Math.Exp(-(double)_iteration / _maxIterations);
        }

        private void ChangeNeighborRadius()
        {
            if (_iteration % 1000 == 0)
            {
                _neighborRadius--;
            }
        }

        private void UpdateIterationInfo()
        {
            lblIterationInfo.Text = $"{_iteration}/{_maxIterations}";
        }

        private Triangle InitializeTriangle(int squareSize)
        {
            return new Triangle(new Point(squareSize / 2, squareSize / 10),
                new Point(squareSize / 10, squareSize - squareSize / 10),
                new Point(squareSize - squareSize / 10, squareSize - squareSize / 10));
        }

        private void RefreshArea()
        {
            picBoxMap.Refresh();
        }

        private enum SimulationState
        {
            New,
            Started,
            Paused
        }
    }
}
