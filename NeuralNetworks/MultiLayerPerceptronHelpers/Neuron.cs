using MathNet.Numerics.LinearAlgebra;
using NeuralNetworks.Utility;

namespace NeuralNetworks.MultiLayerPerceptronHelpers
{
    internal class Neuron
    {
        public Vector<double> Weights { get; set; }
        public double Bias { get; private set; }
        public double BiasWeight { get; set; }
        public double RoFactor { get; set; }

        private readonly Delegates.ActivationFunction _activationFunction;

        public Neuron(Vector<double> initialWeights, double bias, double initialBiasWeight, Delegates.ActivationFunction activationFunction)
        {
            Weights = initialWeights;
            Bias = bias;
            BiasWeight = initialBiasWeight;
            _activationFunction = activationFunction;
        }

        public double CalculateOutput(Vector<double> inputDataVector)
        {
            return _activationFunction(AggregateFunction(inputDataVector));
        }

        private double AggregateFunction(Vector<double> inputDataVector)
        {
            return inputDataVector * Weights + Bias * BiasWeight;
        }
    }
}
