    class Flight
    {
        private string _departurePoint;
        private string _destination;
        private int _flightTimeInMinutes;
        public string DeparturePoint
        {
            get { return _departurePoint; }
            set
            {
                if (value.Length == 0) throw new ArgumentException();
                _departurePoint = value;
            }
        }
        public string Destination
        {
            get { return _destination; }
            set
            {
                if (value.Length == 0) throw new ArgumentException();
                _destination = value;
            }
        }
        public int Time
        {
            get { return _flightTimeInMinutes; }
            set
            {
                Validator.AssertOnPositiveValue(value);
                _flightTimeInMinutes = value;
            }
        }
        public Flight()
        {
            DeparturePoint = "Maiami";
            Destination = "Washington";
            Time = 190;

        }
        public Flight(string departurePoint, string destination, int flightTimeInMinutes)
        {
            DeparturePoint = departurePoint;
            Destination = destination;
            Time = flightTimeInMinutes;

        }
    }

