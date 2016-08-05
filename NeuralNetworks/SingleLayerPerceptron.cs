using MathNet.Numerics.LinearAlgebra;
using NeuralNetworks.SingleLayerPerceptronHelpers;

namespace NeuralNetworks
{
    public class SingleLayerPerceptron
    {
        private Pocket _pocket;
        private PerceptronVectorReader _perceptronVectorReader;

        public SingleLayerPerceptron()
        {
            _perceptronVectorReader = new PerceptronVectorReader();
            _pocket = new Pocket();
        }

        public Pocket Train(int iterations, string datafilePath, double learningRate = 1.0)
        {
            int age = 0;
            var perceptronVectors = _perceptronVectorReader.ReadFromTextFile(datafilePath);
            var randomizer = new Randomizer();
            var weights = randomizer.RandomizeWeights(perceptronVectors[0].Data.Count);
            var bias = randomizer.RandomizeBias();

            SaveWeightsBiasAndAgeInPocket(weights, bias, age);

            while (iterations > 0)
            {
                var perceptronVector = randomizer.SelectRandomVector(perceptronVectors);

                var calculationResult = CalculatePerceptronFunction(perceptronVector, weights, bias);

                if (CalculationsAreCompatibile(calculationResult, perceptronVector))
                {
                    age++;

                    if(ActualAgeIsGreaterThanPocketAge(age, _pocket.Age))
                    {
                        SaveWeightsBiasAndAgeInPocket(weights, bias, age);
                    }
                }
                else
                {
                    AdjustWeights(ref weights, perceptronVector, learningRate);
                    AdjustBias(ref bias, perceptronVector);
                    age = 0;
                }

                iterations--;
            }

            return _pocket;
        }

        private double CalculatePerceptronFunction(PerceptronVector perceptronVector, Vector<double> weights, double bias)
        {
            return perceptronVector.Data * weights + bias;
        }

        private bool CalculationsAreCompatibile(double calculationResult, PerceptronVector perceptronVector)
        {
            if (calculationResult >= 0 && perceptronVector.Class == 1)
            {
                return true;
            }

            return calculationResult < 0 && perceptronVector.Class == -1;
        }

        private bool ActualAgeIsGreaterThanPocketAge(int actualAge, int ageInPocket)
        {
            return actualAge > ageInPocket;
        }

        private void SaveWeightsBiasAndAgeInPocket(Vector<double> weights, double bias, int age)
        {
            _pocket.Weights = weights;
            _pocket.Bias = bias;
            _pocket.Age = age;
        }

        private void AdjustWeights(ref Vector<double> weights, PerceptronVector perceptronVector, double learningRate)
        {
            weights += learningRate * perceptronVector.Class * perceptronVector.Data;
        }

        private void AdjustBias(ref double bias, PerceptronVector perceptronVector)
        {
            bias += perceptronVector.Class;
        }

        public double Test(string datafilePath, Vector<double> weights, double bias)
        {
            var perceptronTestVectors = _perceptronVectorReader.ReadFromTextFile(datafilePath);
            int correctlyClassifiedClasses = 0;

            foreach (var perceptronTestVector in perceptronTestVectors)
            {
                var calculationResult = CalculatePerceptronFunction(perceptronTestVector, weights, bias);
                var classifiedClass = ClassifyClass(calculationResult);

                if (ClassIsCorrectlyClassified(perceptronTestVector, classifiedClass))
                {
                    correctlyClassifiedClasses++;
                }
            }

            return (double)correctlyClassifiedClasses / perceptronTestVectors.Count * 100;  // Accuracy in percents
        }

        private int ClassifyClass(double calculationResult)
        {
            return calculationResult >= 0 ? 1 : -1;
        }

        private bool ClassIsCorrectlyClassified(PerceptronVector perceptronVector, int classifiedClass)
        {
            return perceptronVector.Class == classifiedClass;
        }
    }
}
