using MathNet.Numerics.LinearAlgebra;

namespace NeuralNetworks.Utility
{
    public class NeuralVector
    {
        public Vector<double> Data { get; set; }
        public int Class { get; set; }

        public NeuralVector(Vector<double> inputData)
        {
            Data = inputData;
            Class = default(int);
        }

        public NeuralVector(Vector<double> inputData, int inputClass)
        {
            Data = inputData;
            Class = inputClass;
        }


    }
}
