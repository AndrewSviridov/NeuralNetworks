using System;

namespace NeuralNetworks.EventsArgs
{
    public class ProgressEventArgs : EventArgs
    {
        public int Progress { get; private set; }

        public ProgressEventArgs(int progress)
        {
            Progress = progress;
        }
    }
}
