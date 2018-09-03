using System;
using System.IO;

namespace MyTunes.PCL
{
    public interface IStreamLoader
    {
        Stream ReadFile(String filename);
    }
}
