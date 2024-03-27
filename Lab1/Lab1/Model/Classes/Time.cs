using System.ComponentModel.DataAnnotations;

class Time
    {
        private int _hours;
        private int _minutes;
        private int _seconds;
        public int  Hours 
        {
            get { return _hours; }
            set
            {
                Validator.AssertOnPositiveValue(value);
                if (value > 23 ) throw new ArgumentException();
                _hours = value;
            }
        }
        public int Minutes
        {
            get { return _minutes; }
            set
            {
                Validator.AssertOnPositiveValue(value);
                if (value > 60 ) throw new ArgumentException();
                _minutes = value;
            }
        }
        public int Seconds
        {
            get { return _seconds; }
            set
            {
                if (value > 60) throw new ArgumentException();

                Validator.AssertOnPositiveValue(value);
                _seconds = value;
            }
        }
        public Time()
        {
            Hours = 4;
            Minutes = 2;
            Seconds = 38;

        }
        public Time(int hours, int minutes, int seconds)
        {
            Hours = hours;
            Minutes = minutes;
            Seconds = seconds;

        }

    }

