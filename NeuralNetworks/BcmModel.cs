using System;
using System.Collections.Generic;

namespace NeuralNetworks
{
    public class BcmModel
    {
        public int[,] CorrelationMatrix { get; private set; }
        private int _vectorCount;

        public void Train(int[] vector)
        {
            VerifyVectorBeforeTraining(vector);
            
            for (int i = 0; i < vector.Length; i++)
            {
                for (int j = 0; j < vector.Length; j++)
                {
                    if (vector[i] * vector[j] == 1)
                    {
                        CorrelationMatrix[i,j] = 1;
                    }
                }
            }

            _vectorCount++;
        }

        public bool Test(int[] vector, int threshold)
        {
            int[] resultVector = NeuralNetworksMath.MultiplyVectorByMatrix(vector, CorrelationMatrix);
            resultVector = DivideVectorByThreshold(resultVector, threshold);
            return VerifyVectors(vector, resultVector);
        }

        private void VerifyVectorBeforeTraining(IReadOnlyCollection<int> vector)
        {
            switch (_vectorCount)
            {
                case 0:
                {
                    CorrelationMatrix = new int[vector.Count, vector.Count];
                    break;
                }
                case 1:
                {
                    if (vector.Count != CorrelationMatrix.GetLength(0))
                    {
                        throw new ArgumentException(
                            "The length of the vector is different than the dimension of the matrix. The correct vector length: " +
                            CorrelationMatrix.GetLength(0));
                    }
                    break;
                }
                default:
                {
                    throw new InvalidOperationException("You can train only two vectors for one BCM!");
                }
            }
        }

        private int[] DivideVectorByThreshold(int[] vector, int threshold)
        {
            for (int i = 0; i < vector.Length; i++)
            {
                vector[i] /= threshold;
            }

            return vector;
        }

        private bool VerifyVectors(int[] questionVector, int[] resultVector)
        {
            if (questionVector.Length != resultVector.Length)
            {
                throw new ArgumentException("Vectors must have same length.");
            }

            for (int i = 0; i < questionVector.Length; i++)
            {
                if (questionVector[i] != resultVector[i])
                {
                    return false;
                }
            }

            return true;
        }
    }
}
