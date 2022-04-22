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
                GameName = "Quake II"
                
            });

            games.Add(new VideoGame()
            {
                GameName = "Doc 1"
            });

            this.games.Add(new VideoGame()
            {
                GameName = "Doc 2"
            });

            this.games.Add(new VideoGame()
            {
                GameName = "Doc3"
            });
        }
        public void addGame()
        {
            this.games.Add(new VideoGame()
            {
                GameName = "Doc4"
                
            });
        }
    }
}
