using System;
using System.Collections.Generic;
using System.Linq;
using MathNet.Numerics.LinearAlgebra;
using NeuralNetworks.Utility;

namespace NeuralNetworks.Models
{
    public class HopfieldNetwork
    {
        private DataReader _dataReader;
        private Matrix<double> _weights;
        private Vector<double> _biases;
        private Vector<double> _lastOutputs;
        private Vector<double> _backendOutputs;
        private int _numberOfNeurons;

        public HopfieldNetwork()
        {
            _dataReader = new DataReader();
        }

        public void TeachWithHebbsRule(string datafilePath, char separator)
        {
            var randomizer = new Randomizer();
            var inputVectors = _dataReader.ReadHopfieldDataFromTextFile(datafilePath, separator);
            _numberOfNeurons = inputVectors.First().Data.Count;
            _biases = randomizer.RandomizeBiases(inputVectors.First().Data.Count);
            _weights = CreateWeightsMatrixWithHebbsRule(inputVectors);
        }

        public NeuralVector Test(NeuralVector testingVector)
        {
            ValidateVectorLength(testingVector);
            ValidateWeightsAndBiases();

            InitializeOutputs(testingVector.Data);

            var outputVector = CalculateAllOuputs();

            return new NeuralVector(outputVector);
        }

        private Matrix<double> CreateWeightsMatrixWithHebbsRule(List<NeuralVector> inputVectors)
        {
            var weightsArray = new double[_numberOfNeurons, _numberOfNeurons];

            for (int k = 0; k < _numberOfNeurons; k++)
            {
                for (int j = 0; j < _numberOfNeurons; j++)
                {
                    if (k != j)
                    {
                        var sum = inputVectors.Sum(inputVector => inputVector.Data[k] * inputVector.Data[j]);

                        weightsArray[k, j] = sum / _numberOfNeurons;
                    }
                }
            }

            return Matrix<double>.Build.DenseOfArray(weightsArray);
        }

        private void InitializeOutputs(Vector<double> testingVectorData)
        {
            _lastOutputs = testingVectorData;
            _backendOutputs = Vector<double>.Build.Dense(_numberOfNeurons);
        }

        private double CalculateOutputForNeuron(int neuronIndex)
        {
            if (!Enumerable.Range(0, _numberOfNeurons).Contains(neuronIndex))
            {
                throw new ArgumentException("Neuron index out of range!");
            }

            var sum = 0.0;

            for (int neighbour = 0; neighbour < _numberOfNeurons; neighbour++)
            {
                sum += _weights[neuronIndex, neighbour] * _lastOutputs[neighbour];
            }

            sum += _biases[neuronIndex];

            var output = ActivationFunction(sum, neuronIndex);
            _backendOutputs[neuronIndex] = output;

            return output;
        }

        private double ActivationFunction(double activationSum, int neuronIndex)
        {
            if (activationSum > 0)
            {
                return 1.0;
            }
            if (activationSum < 0)
            {
                return -1.0;
            }

            return _lastOutputs[neuronIndex];
        }

        private Vector<double> CalculateAllOuputs()
        {
            var outputs = new double[_numberOfNeurons];

            for (int neuron = 0; neuron < _numberOfNeurons; neuron++)
            {
                outputs[neuron] = CalculateOutputForNeuron(neuron);
            }

            _lastOutputs = _backendOutputs;

            return Vector<double>.Build.DenseOfArray(outputs);
        }

        private void ValidateVectorLength(NeuralVector vector)
        {
            if (vector.Data.Count != _numberOfNeurons)
            {
                throw new InvalidOperationException("Weights or biases dont exist, first teach the network.");
            }
        }

        private void ValidateWeightsAndBiases()
        {
            if (_biases == null || _weights == null)
            {
                throw new InvalidOperationException("Weights or biases dont exist, first teach the network.");
            }
        }
    }
}
