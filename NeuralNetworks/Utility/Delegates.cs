#region License
/*
 * This file is subject to the terms and conditions defined in
 * file 'LICENSE.txt', which is part of this source code package.
 */
#endregion

using NeuralNetworks.EventsArgs;

namespace NeuralNetworks.Utility
{
    public static class Delegates
    {
        public delegate double ActivationFunction(double aggregationResult);

        public delegate double DerivativeFunction(double activationResult);

        public delegate void TeachingProgressChangedEventHandler(object sender, ProgressEventArgs e);
    }
}
