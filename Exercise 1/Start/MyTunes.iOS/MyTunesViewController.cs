using UIKit;
using System.Linq;
using MyTunes.PCL;

namespace MyTunes
{
	public class MyTunesViewController : UITableViewController
	{
		public override void ViewDidLayoutSubviews()
		{
			base.ViewDidLayoutSubviews();

			TableView.ContentInset = new UIEdgeInsets (20, 0, 0, 0);
		}

		public override async void ViewDidLoad()
		{
			base.ViewDidLoad();

            //TableView.Source = new ViewControllerSource<string>(TableView) {
            //	DataSource = new string[] { "One", "Two", "Three" },
            //};

            SongLoader songLoader = new SongLoader(new StreamLoaderIOS());
            var songList = await songLoader.Load();

            TableView.Source = new ViewControllerSource<Song>(TableView)
            {
                DataSource = songList.ToList(),
                TextProc = song => song.Name,
                DetailTextProc = song => $"{song.Artist} - {song.Album}" 
            };
        }
    }

}

