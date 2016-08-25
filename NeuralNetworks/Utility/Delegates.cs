namespace NeuralNetworks.Utility
{
    public static class Delegates
    {
        public delegate double ActivationFunction(double aggregationResult);

        public delegate double DerivativeFunction(double activationResult);
    }
}
