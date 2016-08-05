using MathNet.Numerics.LinearAlgebra;

namespace NeuralNetworks.SingleLayerPerceptronHelpers
{
    public class Pocket
    {
        public Vector<double> Weights { get; set; }
        public double Bias { get; set; }
        public int Age { get; set; }
    }
}
