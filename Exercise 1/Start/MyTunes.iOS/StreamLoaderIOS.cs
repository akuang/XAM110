﻿using System;
using System.IO;
using MyTunes.PCL;

namespace MyTunes
{
    public class StreamLoaderIOS : IStreamLoader
    {
        public StreamLoaderIOS()
        {
        }

        public Stream ReadFile(string filename)
        {
            FileStream fs = File.OpenRead(filename);
            return fs;
        }
    }
}