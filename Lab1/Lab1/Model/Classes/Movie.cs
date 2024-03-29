    class Movie
    {
        private string _name;
        private int _timeInMinutes;
        private int _yearOfIssue;
        public Genre GenreOfMovie { get; set; }
        private double _rating;
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
                Validator.AssertValueInRange(value, 1900, 2024);
                _yearOfIssue = value;
            }
        }

        public double Raiting
        {
            get { return _rating; }
            set
            {

                if (value > 10) throw new ArgumentException("Raiting can not be more than 10.");
                //Validator.AssertOnPositiveValue(value);
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
        public Movie(string name, int timeInMinutes, int yearOfIssue, Genre genre, double rating)
        {
            Name = name;
            TimeInMinutes = timeInMinutes;
            YearOfIssue = yearOfIssue;
            GenreOfMovie = genre;

            Raiting = rating;

        }



    }

