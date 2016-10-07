#region License
/*
 * This file is subject to the terms and conditions defined in
 * file 'LICENSE.txt', which is part of this source code package.
 */
#endregion

using System;
using System.Collections.Generic;
using System.Diagnostics;
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
        private readonly Color _pointsColor = Color.Green;
        private readonly Color _linesColor = Color.LightSeaGreen;
        private Drawer _drawer;
        private Randomizer _randomizer;
        private Triangle _triangle;
        private SelfOrganizingMap _som;
        private SimulationState _simulationState;
        private int _neuronsCount;
        private int _areaSize;
        private int _pointsDiameter = 4;
        private int _lineWidth = 1;


        private int _iteration;
        private int _neighborRadius;
        private int _radiusDecayRate;
        private double _shiftFactor;
        private int _shiftFactorDecayRate;
        private int _drawFrequency;

        private enum SimulationState
        {
            New,
            Started,
            Paused
        }

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
                    grpBoxConfig.Enabled = false;

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
            grpBoxConfig.Enabled = true;
        }

        private void timer_Tick(object sender, EventArgs e)
        {
            var coordRange = new CoordRange(_triangle.Left.X, _triangle.Right.X, _triangle.Up.Y, _triangle.Right.Y);

            if (_shiftFactor >= 0.02)
            {
                _drawer.ClearArea();

                var point = _randomizer.RandomizePointInTriangle(coordRange, _areaSize);
                var node = Translator.TranslatePointToNode(point);

                var nodes = _som.StartModifyNodes(node, _neighborRadius, _shiftFactor);
                var points = Translator.TranslateNodesToPoints(nodes);

                DrawWithFrequency(points, point);

                _iteration++;
                UpdateIterationInfo();

                CalculateRadius();
                CalculateShiftFactor();
            }
            else
            {
                btnGenerate.Enabled = true;
                btnStartPause.Enabled = false;
                btnStop.Enabled = false;
                grpBoxConfig.Enabled = true;
                timer.Stop();
            }
        }


        private void InitializeControls()
        {
            _areaSize = picBoxMap.Width;

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
            _iteration = 0;
            _drawFrequency = Convert.ToInt32(numDrawFreq.Value);
            _neuronsCount = Convert.ToInt32(numNeurons.Value);
            _neighborRadius = Convert.ToInt32(numNeighborRadius.Value);
            _radiusDecayRate = Convert.ToInt32(numRadiusDecay.Value);
            _shiftFactor = Convert.ToDouble(numShiftFactor.Value);
            _shiftFactorDecayRate = Convert.ToInt32(numShiftDecayRate.Value);
        }

        private void InitializeSom()
        {
            var startedRange = new CoordRange(200, 300, 250, 350);
            var nodes = _randomizer.RandomizeStartedNodesInTriangle(_neuronsCount, startedRange, _areaSize);
            var points = Translator.TranslateNodesToPoints(nodes);

            _drawer.DrawPoints(points, _pointsDiameter, _pointsColor, PointType.Filled);
            _drawer.DrawLines(points, _lineWidth, _linesColor);

            _som = new SelfOrganizingMap(nodes);
        }

        private void CalculateRadius()
        {
            if (_iteration % _radiusDecayRate == 0)
            {
                if (_neighborRadius != 0)
                {
                    _neighborRadius--;
                }
            }
        }

        private void CalculateShiftFactor()
        {
            if (_iteration % _shiftFactorDecayRate == 0)
            {
                 _shiftFactor *= 0.95;
            }
        }

        private void UpdateIterationInfo()
        {
            lblIterationInfo.Text = $"{_iteration}";
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

        private void DrawWithFrequency(List<Point> points, Point point)
        {
            if (_iteration % _drawFrequency == 0)
            {
                _drawer.DrawTriangle(_triangle, Color.Black);
                _drawer.DrawPoints(points, _pointsDiameter, _pointsColor, PointType.Filled);
                _drawer.DrawLines(points, _lineWidth, _linesColor);
                _drawer.DrawPoint(point, _pointsDiameter, Color.Red, PointType.Filled);
                RefreshArea();
            }
        }
    }
}
