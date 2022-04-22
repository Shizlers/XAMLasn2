using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LocalNote
{
    public class VideoGame
    {
        public string DocName { get; set; }
        public string Content { get; set; }

        public VideoGame()      //Constructor
        {
            this.DocName = "Doc";
            
        }

        public string Summary
        {
            get
            {
                return $"{this.DocName}"; 
            }
        }

        public VideoGame(string words)
        {
            this.DocName = "Doc";
           
        }

    }
}
