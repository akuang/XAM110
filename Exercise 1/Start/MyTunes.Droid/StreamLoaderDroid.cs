using System;
using System.IO;
using MyTunes.STD;

namespace MyTunes
{
    public class StreamLoaderDroid : IStreamLoader
    {
        public StreamLoaderDroid()
        {
        }

        public Stream ReadFile(string filename)
        {
            Stream s = Android.App.Application.Context.Assets.Open(filename);
            return s;
        }
    }
}
