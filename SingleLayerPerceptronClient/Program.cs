#region License
/*
 * This file is subject to the terms and conditions defined in
 * file 'LICENSE.txt', which is part of this source code package.
 */
#endregion

using System;
using NeuralNetworks.Models;

namespace SingleLayerPerceptronClient
{
    class Program
    {
        static void Main(string[] args)
        {
            var slp = new SingleLayerPerceptron();
            
            Console.WriteLine("Accuracy in A: {0}", ExecuteAlgorithmForSpecifiedData(slp, "Data/iris_2vs3_A_tr.txt", "Data/iris_2vs3_A_te.txt"));
            Console.WriteLine("Accuracy in B: {0}", ExecuteAlgorithmForSpecifiedData(slp, "Data/iris_2vs3_B_tr.txt", "Data/iris_2vs3_B_te.txt"));
            Console.WriteLine("Accuracy in C: {0}", ExecuteAlgorithmForSpecifiedData(slp, "Data/iris_2vs3_C_tr.txt", "Data/iris_2vs3_C_te.txt"));
            Console.WriteLine("Accuracy in D: {0}", ExecuteAlgorithmForSpecifiedData(slp, "Data/iris_2vs3_D_tr.txt", "Data/iris_2vs3_D_te.txt"));
            Console.WriteLine("Accuracy in E: {0}", ExecuteAlgorithmForSpecifiedData(slp, "Data/iris_2vs3_E_tr.txt", "Data/iris_2vs3_E_te.txt"));
            Console.WriteLine("Accuracy in AND: {0}", ExecuteAlgorithmForSpecifiedData(slp, "Data/iris_and.txt", "Data/iris_and.txt"));

            Console.ReadKey();
        }

        private static double ExecuteAlgorithmForSpecifiedData(SingleLayerPerceptron singleLayerPerceptron, string treningDataPath, string testDataPath)
        {
            char separator = '\t';
            char decimalPoint = '.';
            var winner = singleLayerPerceptron.Teach(treningDataPath, separator, decimalPoint, 1000, 0.2);

            return singleLayerPerceptron.Test(testDataPath, separator, decimalPoint, winner.Weights, winner.Bias);
        }
    }
}
