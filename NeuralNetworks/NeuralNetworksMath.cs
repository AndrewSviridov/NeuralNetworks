using System;

namespace NeuralNetworks
{
    public static class NeuralNetworksMath
    {
        public static int[] MultiplyVectorByMatrix(int[] vector, int[,] matrix)
        {
            if (matrix.GetLength(1) != vector.Length)
            {
                throw new ArgumentException("The length of the vector is different than the horizontal dimension of the matrix. The correct vector length: " +
                            matrix.GetLength(1));
            }

            var resultVector = new int[vector.Length];

            for (int i = 0; i < matrix.GetLength(0); i++)
            {
                for (int j = 0; j < matrix.GetLength(1); j++)
                {
                    resultVector[i] += vector[j] * matrix[j, i];
                }
            }

            return resultVector;
        }


    }
}
