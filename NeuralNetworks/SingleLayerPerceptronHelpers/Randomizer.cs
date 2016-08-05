using System;
using System.Collections.Generic;
using MathNet.Numerics.LinearAlgebra;

namespace NeuralNetworks.SingleLayerPerceptronHelpers
{
    public class Randomizer
    {
        private readonly Random _rand;

        public Randomizer()
        {
            _rand = new Random();
        }

        public Vector<double> RandomizeWeights(int vectorSize)
        {
            var weights = new double[vectorSize];

            for (int index = 0; index < vectorSize; index++)
            {
                weights[index] = _rand.NextDouble() * 0.4 - 0.2;   // from -0.2 to 0.2
            }

            return Vector<double>.Build.DenseOfArray(weights);
        }

        public double RandomizeBias()
        {
            return _rand.NextDouble() * 0.4 - 0.2;
        }

        public PerceptronVector SelectRandomVector(List<PerceptronVector> irisesList)
        {
            var randSelect = _rand.Next(irisesList.Count);

            return irisesList[randSelect];
        }
    }
}
