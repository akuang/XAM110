﻿using Android.App;
using Android.OS;
using MyTunes.Shared;
using System.Linq;

namespace MyTunes
{
	[Activity(Label = "@string/app_name", MainLauncher = true, Icon = "@drawable/icon")]
	public class MainActivity : ListActivity
	{
		protected override async void OnCreate(Bundle bundle)
		{
			base.OnCreate(bundle);
            //ListAdapter = new ListAdapter<string>() {
            //	DataSource = new[] { "One", "Two", "Three" }
            //};

            SongLoader songLoader = new SongLoader();
            var songList = await songLoader.Load();

            ListAdapter = new ListAdapter<Song>()
            {
                DataSource = songList.ToList(),
                TextProc = song => song.Name,
                DetailTextProc = song => $"{song.Artist} - {song.Album}"
            };
		}
	}
}
