#region License
/*
 * This file is subject to the terms and conditions defined in
 * file 'LICENSE.txt', which is part of this source code package.
 */
#endregion

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
