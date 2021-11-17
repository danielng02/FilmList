using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FilmList
{
    class Film
    {
        private string name;

        public string Name
        {
            get { return name; } 
            set { name = value; }
        }

        private string genre;

        public string Genre 
        {
            get { return genre; }
            set { genre = value; }
        }

        private DateTime releaseDate;

        public DateTime ReleaseDate
        {
            get { return releaseDate; }
            set { releaseDate = value; }
        }

        private string rating;

        public string Rating
        {
            get { return rating; }   
            set { rating = value; } 
        }
    }
}
