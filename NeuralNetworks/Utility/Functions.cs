using System;

namespace NeuralNetworks.Utility
{
    public static class Functions
    {
        public static double SigmoidBipolar(double aggregationResult)
        {
            return (1 - Math.Exp(-aggregationResult)) / (1 + Math.Exp(-aggregationResult));
        }

        public static double SigmoidUnipolar(double aggregationResult)
        {
            return 1 / (1 + Math.Exp(-aggregationResult));
        }

        public static double SigmoidBipolarDerivative(double activationResult)
        {
            return (1 - Math.Pow(activationResult, 2)) / 2;
        }

        public static double SigmoidUnipolarDerivative(double activationResult)
        {
            return activationResult * (1 - activationResult);
        }
    }
}
