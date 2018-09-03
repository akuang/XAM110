using System;
using System.IO;

namespace MyTunes.STD
{
    public interface IStreamLoader
    {
        Stream ReadFile(String filename);
    }
}
