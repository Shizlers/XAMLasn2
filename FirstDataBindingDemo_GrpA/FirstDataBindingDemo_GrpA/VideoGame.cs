using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LocalNote
{
    public class VideoGame
    {
        public string GameName { get; set; }
       

        public VideoGame()      //Constructor
        {
            this.GameName = "Starcraft";
            
        }

        public string Summary
        {
            get
            {
                return $"{this.GameName}"; 
            }
        }

        public VideoGame(string words)
        {
            this.GameName = "Starcraft";
           
        }

    }
}
