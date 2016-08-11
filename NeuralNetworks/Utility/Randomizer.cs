using System;
using System.Collections.Generic;
using MathNet.Numerics.LinearAlgebra;
using NeuralNetworks.Utility;

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

        public Vector<double> RandomizeBiases(int vectorSize)
        {
            var biases = new double[vectorSize];

            for (int index = 0; index < vectorSize; index++)
            {
                biases[index] = RandomizeBias();
            }

            return Vector<double>.Build.DenseOfArray(biases);
        }

        public NeuralVector SelectRandomVector(List<NeuralVector> neuralVectors)
        {
            var randSelect = _rand.Next(neuralVectors.Count);

            return neuralVectors[randSelect];
        }
    }
}
