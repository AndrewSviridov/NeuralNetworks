using MathNet.Numerics.LinearAlgebra;

namespace NeuralNetworks.SingleLayerPerceptronHelpers
{
    public class PerceptronVector
    {
        public Vector<double> Data { get; set; }
        public int Class { get; set; }

        public PerceptronVector(Vector<double> inputData, int inputClass)
        {
            Data = inputData;
            Class = inputClass;
        }
    }
}
