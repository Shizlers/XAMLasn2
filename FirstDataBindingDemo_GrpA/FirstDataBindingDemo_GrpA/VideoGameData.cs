using System;
using System.Collections.Generic;
using System.Collections.ObjectModel;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LocalNote
{
    public class VideoGameData
    {
        //private VideoGame aGame = new VideoGame();
        //public VideoGame AGame { get { return this.aGame; } }

        private ObservableCollection<VideoGame> games = new ObservableCollection<VideoGame>();
        public ObservableCollection<VideoGame> Games { get { return this.games; } }
        public VideoGameData()
        {
            this.games.Add(new VideoGame()
            {
                DocName = "Doc 0",
		Content = "This is content for doc 0"
                
            });

            games.Add(new VideoGame()
            {
                DocName = "Doc 1",
		Content = "This is content for doc 1"
            });

            this.games.Add(new VideoGame()
            {
                DocName = "Doc 2",
		Content = "This is content for doc 2"
            });

            this.games.Add(new VideoGame()
            {
                DocName = "Doc 3",
		Content = "This is content for doc 3"
            });
        }
        public void addGame()
        {
            this.games.Add(new VideoGame()
            {
                DocName = "Doc 4",
		Content = "This is content for doc 4"
                
            });
        }
    }
}
