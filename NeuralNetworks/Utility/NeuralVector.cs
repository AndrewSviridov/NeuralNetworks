#region License
/*
 * This file is subject to the terms and conditions defined in
 * file 'LICENSE.txt', which is part of this source code package.
 */
#endregion

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
