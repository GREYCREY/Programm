    class Movie
    {
        private string _name;
        private int _timeInMinutes;
        private int _yearOfIssue;
        public Genre GenreOfMovie { get; set; }
        private int _rating;
        public string Name
        {
            get { return _name; }
            set
            {
                if (value.Length == 0) throw new ArgumentException();
                _name = value;
            }
        }
        public int TimeInMinutes
        {
            get { return _timeInMinutes; }
            set
            {
                Validator.AssertOnPositiveValue(value);
                _timeInMinutes = value;
            }
        }
        public int YearOfIssue
        {
            get { return _yearOfIssue; }
            set
            {
                if (value < 1900 || value > 2024) throw new ArgumentException();
                _yearOfIssue = value;
            }
        }

        public int Raiting
        {
            get { return _rating; }
            set
            {

                if (value > 10) throw new ArgumentException("Raiting can not be more than 10.");
                Validator.AssertOnPositiveValue(value);
                _rating = value;
            }
        }
        public Movie()
        {
            Name = "Dune 2";
            TimeInMinutes = 166;
            YearOfIssue = 2024;

            Raiting = 8;
        }
        public Movie(string name, int timeInMinutes, int yearOfIssue, Genre genre, int rating)
        {
            Name = name;
            TimeInMinutes = timeInMinutes;
            YearOfIssue = yearOfIssue;
            GenreOfMovie = genre;

            Raiting = rating;

        }



    }

