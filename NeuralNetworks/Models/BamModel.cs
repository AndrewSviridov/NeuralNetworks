using System;
using MathNet.Numerics.LinearAlgebra;

namespace NeuralNetworks.Models
{
    public class BamModel
    {
        public Matrix<float> WeightsMatrix { get; private set; }
        private bool _isFirstTraining;


        public void Teach(Vector<float> image, Vector<float> name)
        {
            VerifyVectorsBeforeTraining(image, name);

            for (int i = 0; i < image.Count; i++)
            {
                for (int j = 0; j < name.Count; j++)
                {
                    if ((int)image[i] == (int)name[j])
                    {
                        WeightsMatrix[i, j] += 1f;
                    }
                    else
                    {
                        WeightsMatrix[i, j] += -1f;
                    }
                }
            }
        }

        public Matrix<float> RecoverName(Matrix<float> imagesMatrix)
        {
            if (imagesMatrix.ColumnCount != WeightsMatrix.RowCount)
            {
                throw new ArgumentException(
                    "The number of columns of the given matrix must be equal to the number of rows of the weight's matrix.");
            }

            Matrix<float> namesMatrix =
                Matrix<float>.Build.DenseOfArray(new float[imagesMatrix.RowCount, WeightsMatrix.ColumnCount]);
            Matrix<float> previousNamesMatrix;
            Matrix<float> previousImagesMatrix;

            do
            {
                previousNamesMatrix = namesMatrix;
                previousImagesMatrix = imagesMatrix;
                namesMatrix = (imagesMatrix * WeightsMatrix).Map(NormalizeMatrix);
                imagesMatrix = (WeightsMatrix * namesMatrix.Map(NormalizeMatrix).Transpose()).Map(NormalizeMatrix).Transpose();
            } while (!namesMatrix.Equals(previousNamesMatrix) && !imagesMatrix.Equals(previousImagesMatrix));

            return namesMatrix;
        }

        public Matrix<float> RecoverImage(Matrix<float> namesMatrix)
        {
            Matrix<float> transposedNamesMatrix = namesMatrix.Transpose();

            if (namesMatrix.Transpose().RowCount != WeightsMatrix.ColumnCount)
            {
                throw new ArgumentException(
                    "The number of rows(after Transpose) of the given matrix must be equal to the number of columns of the weight's matrix.");
            }

            var imagesMatrix = Matrix<float>.Build.DenseOfArray(new float[WeightsMatrix.RowCount, namesMatrix.ColumnCount]);
            Matrix<float> previousImagesMatrix;
            Matrix<float> previousTransposedNamesMatrix;

            do
            {
                previousImagesMatrix = imagesMatrix;
                previousTransposedNamesMatrix = transposedNamesMatrix;
                imagesMatrix = (WeightsMatrix * transposedNamesMatrix).Map(NormalizeMatrix);
                transposedNamesMatrix = (imagesMatrix.Transpose() * WeightsMatrix).Map(NormalizeMatrix).Transpose();
            } while (!imagesMatrix.Equals(previousImagesMatrix) && !transposedNamesMatrix.Equals(previousTransposedNamesMatrix));

            return imagesMatrix.Transpose();
        }

        private void VerifyVectorsBeforeTraining(Vector<float> image, Vector<float> name)
        {
            if (!_isFirstTraining)
            {
                WeightsMatrix = Matrix<float>.Build.DenseOfArray(new float[image.Count, name.Count]);
                _isFirstTraining = true;
            }
            else
            {
                if (WeightsMatrix.RowCount != image.Count)
                {
                    throw new ArgumentException("Image vector has a different length than the matrix's number of rows.");
                }
                if (WeightsMatrix.ColumnCount != name.Count)
                {
                    throw new ArgumentException("Name vector has a different length than the matrix's number of columns.");
                }
            }
        }

        private float NormalizeMatrix(float value)
        {
            return value > 0f ? 1f : 0f;
        }
    }
}
