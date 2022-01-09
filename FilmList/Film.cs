using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Collections.ObjectModel;
using System.ComponentModel;

namespace FilmList
{
    class Film : INotifyPropertyChanged
    {
        public event PropertyChangedEventHandler PropertyChanged;

        public static ObservableCollection<Film> films = new ObservableCollection<Film>();

        private string name;

        public string Name
        {
            get { return name; } 
            set { name = value; PropertyChanged?.Invoke(this, new PropertyChangedEventArgs("Name")); }
        }

        private string genre;

        public string Genre 
        {
            get { return genre; }
            set { genre = value; PropertyChanged?.Invoke(this, new PropertyChangedEventArgs("Genre")); }
        }

        private DateTime releaseDate;

        public DateTime ReleaseDate
        {
            get { return releaseDate; }
            set { releaseDate = value; PropertyChanged?.Invoke(this, new PropertyChangedEventArgs("ReleaseDate")); }
        }

        private int rating;

        public int Rating
        {
            get { return rating; }   
            set { rating = value; PropertyChanged?.Invoke(this, new PropertyChangedEventArgs("Rating")); } 
        }

        private string actors;

        public string Actors
        {
            get { return actors; }
            set { actors = value; PropertyChanged?.Invoke(this, new PropertyChangedEventArgs("Actors")); }
        }

        private bool watched;

        public bool Watched
        {
            get { return watched; }
            set { watched = value; PropertyChanged?.Invoke(this, new PropertyChangedEventArgs("Watched")); }
        }

        private string comment;

        public string Comment
        {
            get { return comment; }
            set { comment = value; PropertyChanged?.Invoke(this, new PropertyChangedEventArgs("Comment")); }
        }
    }
}
