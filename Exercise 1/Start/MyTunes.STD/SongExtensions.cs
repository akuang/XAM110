using System;

namespace MyTunes.STD
{
    public static class SongExtensions
    {
        public static string Prepend(this string songName, string symbol)
        {
            return songName = $"{symbol} {songName}"; // ★☆
        }
    }
}