using System.Collections.Generic;
using System.IO;
using MathNet.Numerics.LinearAlgebra;

namespace NeuralNetworks.SingleLayerPerceptronHelpers
{
    public class PerceptronVectorReader
    {
        public List<PerceptronVector> ReadFromTextFile(string datafilePath, char separator = '\t', char decimalPoint = '.')
        {
            var perceptronVectors = new List<PerceptronVector>();

            using (var streamReader = new StreamReader(datafilePath))
            {
                string line;

                while((line = streamReader.ReadLine()) != null)
                {
                    if(line.Length != 0)
                    {
                        var data = line.Split(separator);
                        var convertedData = ConvertArrayFromStringToDouble(data, decimalPoint);
                        var perceptronVector = SplitInputDataToPerceptronVector(convertedData);
                        perceptronVectors.Add(perceptronVector);
                    }
                }
            }

            return perceptronVectors;
        }

        private double[] ConvertArrayFromStringToDouble(string[] data, char decimalPoint)
        {
            var convertedData = new double[data.GetLength(0)];

            for (int index = 0; index < data.GetLength(0); index++)
            {
                convertedData[index] = double.Parse(data[index].Replace(decimalPoint, ','));
            }

            return convertedData;
        }

        private PerceptronVector SplitInputDataToPerceptronVector(double[] inputData)
        {
            var vectorData = new double[inputData.GetLength(0) - 1];

            for(int index = 0; index < inputData.GetLength(0) - 1; index++)
            {
                vectorData[index] = inputData[index];
            }

            var perceptronInputData = Vector<double>.Build.DenseOfArray(vectorData);

            return new PerceptronVector(perceptronInputData, (int)inputData[inputData.GetLength(0) - 1]);
        }
    }
}
