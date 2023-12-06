using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _21.Getters_and_Setters
{
    internal class Movie
    {
        public string title;
        public string director;
        private string rating;//now can only be set by getters and setters,

        //costructor
        public Movie(string aTitle, string aDirector, string aRating)
        {
            title = aTitle;
            director = aDirector;
            rating = aRating;
        }

        public string Rating
        {
            get { return rating; }
            set 
            { 
                if(value == "G" || value == "PG-13" || value == "R" || value == "PG-18")
                {
                    rating = value;
                }
                else
                {
                    rating = "NR";
                }
            }
        }
                              
    }
}
