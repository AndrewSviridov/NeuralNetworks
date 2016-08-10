using System.Collections.Generic;
using System.Linq;
using MathNet.Numerics.LinearAlgebra;
using NeuralNetworks.Utility;

namespace NeuralNetworks.Models
{
    public class HopfieldNetwork
    {
        private DataReader _dataReader;
        private int _numberOfNeurons;

        public HopfieldNetwork()
        {
            _dataReader = new DataReader();
        }

        public Matrix<double> Teach(string datafilePath, char separator)
        {
            var inputVectors = _dataReader.ReadHopfieldDataFromTextFile(datafilePath, separator);
            _numberOfNeurons = CalculateNumberOfNeurons(inputVectors);
            var weightsMatrix = CreateWeightsMatrix(inputVectors);

            return weightsMatrix;
        }

        public NeuralVector Test(NeuralVector testingVector)
        {


            return testingVector;
        }
        
        private int CalculateNumberOfNeurons(List<NeuralVector> neuralVectors)
        {
            return neuralVectors.Count * neuralVectors[0].Data.Count;
        }

        private Matrix<double> CreateWeightsMatrix(List<NeuralVector> inputVectors)
        {
            var vectorSize = inputVectors[0].Data.Count;
            var weightsArray = new double[vectorSize, vectorSize];

            for (int k = 0; k < vectorSize; k++)
            {
                for (int j = 0; j < vectorSize; j++)
                {
                    if (k != j)
                    {
                        var sum = inputVectors.Sum(inputVector => inputVector.Data[k] * inputVector.Data[j]);

                        weightsArray[k, j] = sum / vectorSize;
                    }
                }
            }

            return Matrix<double>.Build.DenseOfArray(weightsArray);
        }

        private void FillMatrixDiagonalByZeros(Matrix<double> matrix)
        {
            for (int index = 0; index < matrix.ColumnCount; index++)
            {
                matrix[index, index] = 0.0;
            }
        }

        private void CalculateOuputs()
        {
            //TODO:
        }
    }
}
