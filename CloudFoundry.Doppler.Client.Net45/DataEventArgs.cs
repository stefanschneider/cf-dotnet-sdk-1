namespace CloudFoundry.Doppler.Client
{
    using System;

    internal class DataEventArgs : EventArgs
    {
        public Envelope Data
        {
            get;
            set;
        }
    }
}