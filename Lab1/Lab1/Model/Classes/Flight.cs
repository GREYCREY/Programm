    /// <summary>
    /// Класс, представляющий рейс.
    /// </summary>
    class Flight
    {
        private string _departurePoint;
        private string _destination;
        private int _flightTimeInMinutes;
    
        /// <summary>
        /// Пункт отправления.
        /// </summary>
        /// <exception cref="ArgumentException">Выбрасывается, если значение пустое.</exception>
        public string DeparturePoint
        {
            get { return _departurePoint; }
            set
            {
                if (value.Length == 0) throw new ArgumentException();
                _departurePoint = value;
            }
        }
        /// <summary>
        /// Пункт назначения.
        /// </summary>
        /// <exception cref="ArgumentException">Выбрасывается, если значение пустое.</exception>
        public string Destination
        {
            get { return _destination; }
            set
            {
                if (value.Length == 0) throw new ArgumentException();
                _destination = value;
            }
        }

        /// <summary>
        /// Время полета в минутах.
        /// </summary>
        /// <exception cref="ArgumentException">Выбрасывается, если значение не положительное.</exception>
        public int Time
        {
            get { return _flightTimeInMinutes; }
            set
            {
                Validator.AssertOnPositiveValue(value);
                _flightTimeInMinutes = value;
            }
        }

        /// <summary>
        /// Конструктор по умолчанию.
        /// </summary>
        public Flight()
        {
            DeparturePoint = "Maiami";
            Destination = "Washington";
            Time = 190;

        }

        /// <summary>
        /// Конструктор с параметрами.
        /// </summary>
        /// <param name="departurePoint">Пункт отправления.</param>
        /// <param name="destination">Пункт назначения.</param>
        /// <param name="flightTimeInMinutes">Время полета в минутах.</param>
        public Flight(string departurePoint, string destination, int flightTimeInMinutes)
        {
            DeparturePoint = departurePoint;
            Destination = destination;
            Time = flightTimeInMinutes;

        }
    }

