using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Lab1.Model.Classes
{
     class Movie
    {
        private string _name;
        private int _timeInMinutes;
        private int _yearOfIssue;
        private string _genre;
        private double _rating;
        private string MovieName
        {
            get { return _name; }
            set
            {
                if (value.Length == 0) throw new ArgumentException();
                _name = value;
            }
        }
        private int TimeOfMovieInMinutes
        {
            get { return _timeInMinutes; }
            set
            {
                if (value == 0) throw new ArgumentException();
                _timeInMinutes = value;
            }
        }
        private int Movie_YearOfIssue
        {
            get { return _yearOfIssue; }
            set
            {
                if (value < 1900 && value > 2024) throw new ArgumentException();
                _yearOfIssue = value;
            }
        }
        private string MovieGenre
        {
            get { return _genre; }
            set
            {
                if (value.Length == 0) throw new ArgumentException();
                _genre = value;
            }
        }
        private double MovieRaiting
        {
            get { return _rating; }
            set
            {
                if (value < 0 && value > 10) throw new ArgumentException();
                _rating = value;
            }
        }
        public Movie()
        {
            MovieName = "Dune 2";
            TimeOfMovieInMinutes = 166;
            Movie_YearOfIssue = 2024;
            MovieGenre = "фантастика, боевик, драма, приключения";
            MovieRaiting  = 8.6;
        }
        public Movie(string name, int timeInMinutes, int yearOfIssue, string genre, double rating)
        {
            MovieName = name;
            TimeOfMovieInMinutes = timeInMinutes;
            Movie_YearOfIssue = _yearOfIssue;
            MovieGenre = genre;
            MovieRaiting = rating;

        }



    }
}
