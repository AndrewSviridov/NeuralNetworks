using System.Collections.Generic;
using System.Linq;
using MathNet.Numerics.LinearAlgebra;
using NeuralNetworks.MultiLayerPerceptronHelpers;
using NeuralNetworks.Utility;

namespace NeuralNetworks.Models
{
    public class MultiLayerPerceptron
    {
        private Randomizer _randomizer;
        private List<Layer> _layers;
        private DataReader _dataReader;
        private bool _abortTeaching;

        private Delegates.DerivativeFunction _derivativeFunction;

        public MultiLayerPerceptron(int numberOfLayers, List<int> inputsPerLayer, List<int> neuronsPerLayer, Delegates.ActivationFunction activationFunction)
        {
            _randomizer = new Randomizer();
            _layers = new List<Layer>();
            _dataReader = new DataReader();

            for (int index = 0; index < numberOfLayers; index++)
            {
                _layers.Add(new Layer(neuronsPerLayer[index], inputsPerLayer[index], activationFunction, _randomizer));
            }

            SetDerivativeFunctionType(activationFunction);
        }

        private void SetDerivativeFunctionType(Delegates.ActivationFunction activationFunction)
        {
            if (activationFunction == Functions.SigmoidBipolar)
            {
                _derivativeFunction = Functions.SigmoidBipolarDerivative;
            }
            else
            {
                _derivativeFunction = Functions.SigmoidUnipolarDerivative;
            }
        }

        public void Teach(string datafilePath, char separator, char decimalPoint, int iterations, int learningRate)
        {
            _abortTeaching = false;
            var outputs = new List<Vector<double>>();

            var inputVectors = _dataReader.ReadPerceptronDataFromTextFile(datafilePath, separator, decimalPoint);

            for (int iteration = 0; iteration < iterations; iteration++)
            {
                var selectedVector = _randomizer.SelectRandomVector(inputVectors);
                var expectedClass = selectedVector.Class;

                outputs.Clear();
                outputs.Add(selectedVector.Data);

                CalculateOutputs(outputs);

                DoErrorsBackwardPropagation(outputs, learningRate, expectedClass);

                if (_abortTeaching)
                {
                    return;
                }
            }
        }

        private void DoErrorsBackwardPropagation(List<Vector<double>> outputs, int learningRate, int expectedClass)
        {
            PropagateLastLayer(outputs, expectedClass);
            PropagateHiddenLayers(outputs);
            AdjustWeights(outputs, learningRate);
        }

        private void AdjustWeights(List<Vector<double>> outputs, int learningRate)
        {
            var offset = 1;

            for (int layerId = _layers.Count - offset; layerId >= 0; layerId--)
            {
                var lastNeuronId = _layers[layerId].Neurons.Count - offset;

                for (int neuronId = lastNeuronId; neuronId >= 0; neuronId--)
                {
                    var neuron = _layers[layerId].Neurons[neuronId];

                    neuron.Weights += learningRate * neuron.RoFactor * outputs[layerId];
                    neuron.BiasWeight += learningRate * neuron.RoFactor * neuron.Bias;
                }
            }
        }

        private void PropagateHiddenLayers(List<Vector<double>> outputs)
        {
            const int layersOffset = 2; // One for last layer and one because its indexed from 0.
            const int neuronsOffset = 1;  // Indexed from 0.

            var lastLayerId = _layers.Count - layersOffset;

            for (int layerId = lastLayerId; layerId >= 0; layerId--)
            {
                var lastNeuronId = _layers[layerId].Neurons.Count - neuronsOffset;

                for (int neuronId = lastNeuronId; neuronId >= 0; neuronId--)
                {
                    const int nextLayerOffset = 1;
                    double partOfRoFactor = 0.0;
                    var derivative = CalculateDerivative(outputs[layerId][neuronId]);

                    foreach (var connectedNeuron in _layers[layerId + nextLayerOffset].Neurons)
                    {
                        partOfRoFactor += connectedNeuron.Weights[neuronId] * connectedNeuron.RoFactor;
                    }

                    _layers[layerId].Neurons[neuronId].RoFactor = partOfRoFactor * derivative;
                }
            }
        }

        private void PropagateLastLayer(List<Vector<double>> outputs, int expectedClass)
        {
            foreach (var neuron in _layers.Last().Neurons)
            {
                var lastOutput = outputs.Last().Last();
                var derivative = CalculateDerivative(lastOutput);
                var roFactor = (expectedClass - lastOutput) * derivative;
                neuron.RoFactor = roFactor;
            }
        }

        private double CalculateDerivative(double output)
        {
            return _derivativeFunction(output);
        }

        private void CalculateOutputs(List<Vector<double>> allOutputs)
        {
            var prevOutputId = 0;

            foreach (var layer in _layers)
            {
                var layerOutputs = new List<double>();

                foreach (var neuron in layer.Neurons)
                {
                    var inputData = allOutputs[prevOutputId];
                    layerOutputs.Add(neuron.CalculateOutput(inputData));
                }

                allOutputs.Add(Vector<double>.Build.DenseOfEnumerable(layerOutputs));
                prevOutputId++;
            }
        }

        public void AbortTeaching()
        {
            _abortTeaching = true;
        }
    }
}
