using System.Collections.Generic;
using NeuralNetworks.Utility;

namespace NeuralNetworks.MultiLayerPerceptronHelpers
{
    internal class Layer
    {
        public List<Neuron> Neurons { get; set; }

        public Layer(int numberOfNeurons, int numberOfInputs, Delegates.ActivationFunction activationFunction, Randomizer randomizer)
        {
            Neurons = new List<Neuron>();

            for (int index = 0; index < numberOfNeurons; index++)
            {
                const double bias = 1.0;
                var initialWeights = randomizer.RandomizeWeights(numberOfInputs);
                var initialBiasWeight = randomizer.RandomizeBias();

                Neurons.Add(new Neuron(initialWeights, bias, initialBiasWeight, activationFunction));
            }
        }
    }
}
