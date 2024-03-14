using System;
using System.Collections.Generic;
using System.Linq;
using System.Security.Policy;
using System.Text;
using System.Threading.Tasks;

namespace Lab1.Model.Classes
{
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
                if (value > 23 && value < 0 ) throw new ArgumentException();
                _hours = value;
            }
        }
        public int Minutes
        {
            get { return _minutes; }
            set
            {
                if (value > 60 && value < 0) throw new ArgumentException();
                _minutes = value;
            }
        }
        public int Seconds
        {
            get { return _seconds; }
            set
            {
                if (value > 60 && value < 0) throw new ArgumentException();
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
}
