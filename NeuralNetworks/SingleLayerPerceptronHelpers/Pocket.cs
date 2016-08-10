using MathNet.Numerics.LinearAlgebra;
using NeuralNetworks.Utility;

namespace NeuralNetworks.SingleLayerPerceptronHelpers
{
    public class Pocket
    {
        public NeuralVector Winner { get; set; }

        public Vector<double> Weights { get; set; }

        public double Bias { get; set; }

        public int Age { get; set; }
    }
}
