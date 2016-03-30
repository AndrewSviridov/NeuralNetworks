using MathNet.Numerics.LinearAlgebra;
using System;
using System.Linq;

namespace NeuralNetworks
{
    public class BcmModel
    {
        public Matrix<float> CorrelationMatrix { get; private set; }
        private int _vectorCount;

        public void Train(Vector<float> vector)
        {
            if (!CheckVectorValues(vector))
            {
                throw new ArgumentException("Vector values must be equal to 1 or 0.");
            }

            VerifyVectorBeforeTraining(vector);
            
            for (int i = 0; i < vector.Count; i++)
            {
                for (int j = 0; j < vector.Count; j++)
                {
                    if ((int)vector[i] * (int)vector[j] == 1)
                    {
                        CorrelationMatrix[i,j] = 1;
                    }
                }
            }

            _vectorCount++;
        }

        public bool Test(Vector<float> vector, int threshold)
        {
            Vector<float> resultVector = (vector * CorrelationMatrix).Map(value => value >= threshold ? 1f : 0f);
            return resultVector.Equals(vector);
        }

        private void VerifyVectorBeforeTraining(Vector<float> vector)
        {
            switch (_vectorCount)
            {
                case 0:
                {
                    CorrelationMatrix = Matrix<float>.Build.DenseOfArray(new float[vector.Count, vector.Count]);
                    break;
                }
                case 1:
                {
                    if (vector.Count != CorrelationMatrix.ColumnCount)
                    {
                        throw new ArgumentException(
                            "The length of the vector is different than the dimension of the matrix. The correct vector length: " +
                            CorrelationMatrix.ColumnCount);
                    }
                    break;
                }
                default:
                {
                    throw new InvalidOperationException("You can train only two vectors for one BCM!");
                }
            }
        }

        private bool CheckVectorValues(Vector<float> vector)
        {
            return vector.All(value => (int) value == 1 || (int) value == 0);
        }
    }
}
