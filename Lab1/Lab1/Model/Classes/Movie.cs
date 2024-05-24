    
    /// <summary>
    /// Класс, представляющий фильм.
    /// </summary>
    class Movie
    {
        private string _name;
        private int _timeInMinutes;
        private int _yearOfIssue;
        public Genre GenreOfMovie { get; set; }
        private double _rating;

        /// <summary>
        /// Название фильма.
        /// </summary>
        /// <exception cref="ArgumentException">Выбрасывается, если значение пустое.</exception>
        public string Name
        {
            get { return _name; }
            set
            {
                if (value.Length == 0) throw new ArgumentException();
                _name = value;
            }
        }

        /// <summary>
        /// Длительность фильма в минутах.
        /// </summary>
        /// <exception cref="ArgumentException">Выбрасывается, если значение не положительное.</exception>
        public int TimeInMinutes
        {
            get { return _timeInMinutes; }
            set
            {
                Validator.AssertOnPositiveValue(value);
                _timeInMinutes = value;
            }
        }

        /// <summary>
        /// Год выпуска фильма.
        /// </summary>
        /// <exception cref="ArgumentException">Выбрасывается, если значение выходит за допустимые пределы (1900-2024).</exception>
        public int YearOfIssue
        {
            get { return _yearOfIssue; }
            set
            {
                Validator.AssertValueInRange(value, 1900, 2024);
                _yearOfIssue = value;
            }
        }

        /// <summary>
        /// Рейтинг фильма.
        /// </summary>
        /// <exception cref="ArgumentException">Выбрасывается, если значение больше 10.</exception>
        public double Raiting
        {
            get { return _rating; }
            set
            {

                if (value > 10) throw new ArgumentException("Raiting can not be more than 10.");
                
                _rating = value;
            }
        }
        /// <summary>
        /// Конструктор по умолчанию.
        /// </summary>
        public Movie()
        {
            Name = "Dune 2";
            TimeInMinutes = 166;
            YearOfIssue = 2024;

            Raiting = 8;
        }
        /// <summary>
        /// Конструктор с параметрами.
        /// </summary>
        /// <param name="name">Название фильма.</param>
        /// <param name="timeInMinutes">Длительность фильма в минутах.</param>
        /// <param name="yearOfIssue">Год выпуска фильма.</param>
        /// <param name="genre">Жанр фильма.</param>
        /// <param name="rating">Рейтинг фильма.</param>
        public Movie(string name, int timeInMinutes, int yearOfIssue, Genre genre, double rating)
        {
            Name = name;
            TimeInMinutes = timeInMinutes;
            YearOfIssue = yearOfIssue;
            GenreOfMovie = genre;

            Raiting = rating;

        }
    }

