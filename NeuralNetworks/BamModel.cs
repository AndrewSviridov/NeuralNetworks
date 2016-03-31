using MathNet.Numerics.LinearAlgebra;
using System;

namespace NeuralNetworks
{
    public class BamModel
    {
        public Matrix<float> WeightsMatrix { get; private set; }
        private bool _isFirstTraining;


        public void Train(Vector<float> image, Vector<float> name)
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
    }
}
