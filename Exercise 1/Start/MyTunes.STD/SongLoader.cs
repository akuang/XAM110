using System;
using System.Collections.Generic;
using Newtonsoft.Json;
using System.IO;
using System.Threading.Tasks;
using System.Reflection;

namespace MyTunes.STD
{
	public class SongLoader
	{
		const string Filename = "songs.json";

        public SongLoader(IStreamLoader loader)
        {
            this.Loader = loader;
        }

        private IStreamLoader Loader { get; set; }

		public async Task<IEnumerable<Song>> Load()
		{
			using (var reader = new StreamReader(OpenData()))
            {
                var songs = JsonConvert.DeserializeObject<List<Song>>(await reader.ReadToEndAsync());
                foreach (var song in songs)
                {
                    song.Name = song.Name.Prepend("★");
                    song.Artist = song.Artist.Prepend("☆");
                }
                return songs;
            }
		}

		private Stream OpenData()
		{
			// TODO: add code to open file here.
			if (this.Loader != null)
            {
                Stream s = Loader.ReadFile(Filename);
                return s;
            }

            throw new Exception("Must set platform Loader before calling Load.");
        }
	}
}

