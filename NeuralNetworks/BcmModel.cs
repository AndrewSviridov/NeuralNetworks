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
            ValidateVector(vector);
            
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

        private void ValidateVector(IReadOnlyCollection<int> vector)
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
                            "The length of the vector is different than the dimension of the matrix. The correct length: " +
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
    }
}
