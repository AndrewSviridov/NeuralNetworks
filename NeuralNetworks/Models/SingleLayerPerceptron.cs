using MathNet.Numerics.LinearAlgebra;
using NeuralNetworks.SingleLayerPerceptronHelpers;
using NeuralNetworks.Utility;

namespace NeuralNetworks.Models
{
    public class SingleLayerPerceptron
    {
        private Pocket _pocket;
        private DataReader _dataReader;

        public SingleLayerPerceptron()
        {
            _dataReader = new DataReader();
            _pocket = new Pocket();
        }

        public Pocket Teach(string datafilePath, char separator, char decimalPoint, int iterations, double learningRate = 1.0)
        {
            int age = 0;
            var perceptronVectors = _dataReader.ReadPerceptronDataFromTextFile(datafilePath, separator, decimalPoint);
            var randomizer = new Randomizer();
            var weights = randomizer.RandomizeWeights(perceptronVectors[0].Data.Count);
            var bias = randomizer.RandomizeBias();

            SaveWeightsBiasAndAgeInPocket(
                new NeuralVector(Vector<double>.Build.Dense(perceptronVectors[0].Data.Count), 0), weights, bias, age);

            while (iterations > 0)
            {
                var perceptronVector = randomizer.SelectRandomVector(perceptronVectors);

                var calculationResult = CalculatePerceptronFunction(perceptronVector, weights, bias);

                if (CalculationsAreCompatibile(calculationResult, perceptronVector))
                {
                    age++;

                    if(ActualAgeIsGreaterThanPocketAge(age, _pocket.Age))
                    {
                        SaveWeightsBiasAndAgeInPocket(perceptronVector, weights, bias, age);
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

        public double Test(string datafilePath, char separator, char decimalPoint, Vector<double> weights, double bias)
        {
            var perceptronTestVectors = _dataReader.ReadPerceptronDataFromTextFile(datafilePath, separator, decimalPoint);
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

        private double CalculatePerceptronFunction(NeuralVector perceptronVector, Vector<double> weights, double bias)
        {
            return perceptronVector.Data * weights + bias;
        }

        private bool CalculationsAreCompatibile(double calculationResult, NeuralVector perceptronVector)
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

        private void SaveWeightsBiasAndAgeInPocket(NeuralVector winner, Vector<double> weights, double bias, int age)
        {
            _pocket.Winner = winner;
            _pocket.Weights = weights;
            _pocket.Bias = bias;
            _pocket.Age = age;
        }

        private void AdjustWeights(ref Vector<double> weights, NeuralVector perceptronVector, double learningRate)
        {
            weights += learningRate * perceptronVector.Class * perceptronVector.Data;
        }

        private void AdjustBias(ref double bias, NeuralVector perceptronVector)
        {
            bias += perceptronVector.Class;
        }

        private int ClassifyClass(double calculationResult)
        {
            return calculationResult >= 0 ? 1 : -1;
        }

        private bool ClassIsCorrectlyClassified(NeuralVector perceptronVector, int classifiedClass)
        {
            return perceptronVector.Class == classifiedClass;
        }
    }
}
