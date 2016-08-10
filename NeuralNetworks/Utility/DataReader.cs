using System.Collections.Generic;
using System.IO;
using MathNet.Numerics.LinearAlgebra;

namespace NeuralNetworks.Utility
{
    public class DataReader
    {
        public List<NeuralVector> ReadPerceptronDataFromTextFile(string datafilePath, char separator, char decimalPoint)
        {
            var perceptronVectors = new List<NeuralVector>();
            var dataType = Enums.DataType.Class;

            using (var streamReader = new StreamReader(datafilePath))
            {
                string line;

                while((line = streamReader.ReadLine()) != null)
                {
                    if(line.Length != 0)
                    {
                        var data = line.Split(separator);
                        var replacedData = ReplaceDecimalPointInData(data, decimalPoint);
                        var convertedData = ConvertArrayFromStringToDouble(replacedData);
                        var perceptronVector = SplitInputDataToInputVector(convertedData, dataType);
                        perceptronVectors.Add(perceptronVector);
                    }
                }
            }

            return perceptronVectors;
        }

        public List<NeuralVector> ReadHopfieldDataFromTextFile(string datafilePath, char separator)
        {
            var perceptronVectors = new List<NeuralVector>();
            var dataType = Enums.DataType.Unclass;

            using (var streamReader = new StreamReader(datafilePath))
            {
                string line;

                while ((line = streamReader.ReadLine()) != null)
                {
                    if (line.Length != 0)
                    {
                        var data = line.Split(separator);
                        var convertedData = ConvertArrayFromStringToDouble(data);
                        var perceptronVector = SplitInputDataToInputVector(convertedData, dataType);
                        perceptronVectors.Add(perceptronVector);
                    }
                }
            }

            return perceptronVectors;
        }

        private string[] ReplaceDecimalPointInData(string[] data, char decimalPoint)
        {
            var replacedData = new string[data.GetLength(0)];

            for (int index = 0; index < data.GetLength(0); index++)
            {
                replacedData[index] = data[index].Replace(decimalPoint, ',');
            }

            return replacedData;
        }

        private double[] ConvertArrayFromStringToDouble(string[] data)
        {
            var convertedData = new double[data.GetLength(0)];

            for (int index = 0; index < data.GetLength(0); index++)
            {
                convertedData[index] = double.Parse(data[index]);
            }

            return convertedData;
        }

        private NeuralVector SplitInputDataToInputVector(double[] inputData, Enums.DataType inputDataType)
        {
            int inputSize = inputDataType == Enums.DataType.Class ? inputData.GetLength(0) - 1 : inputData.GetLength(0);

            var vectorData = new double[inputSize];

            for(int index = 0; index < inputSize; index++)
            {
                vectorData[index] = inputData[index];
            }

            var neuralInputData = Vector<double>.Build.DenseOfArray(vectorData);

            return inputDataType == Enums.DataType.Unclass
                ? new NeuralVector(neuralInputData)
                : new NeuralVector(neuralInputData, (int)inputData[inputData.GetLength(0) - 1]);
        }
    }
}
