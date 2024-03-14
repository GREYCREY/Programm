using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Xml.Linq;

namespace Lab1.Model.Classes
{
     class Flight
    {
        private string _departurePoint;
        private string _destination;
        private int _flightTimeInMinutes;
        private string DeparturePoint
        {
            get { return _departurePoint; }
            set
            {
                if (value.Length == 0) throw new ArgumentException();
                _departurePoint = value;
            }
        }
        private string Destination
        {
            get { return _destination; }
            set
            {
                if (value.Length == 0) throw new ArgumentException();
                _destination = value;
            }
        }
        private int FlightTime
        {
            get { return _flightTimeInMinutes; }
            set
            {
                if (value < 0) throw new ArgumentException();
                _flightTimeInMinutes = value;
            }
        }
        public Flight()
        {
            DeparturePoint = "Maiami";
            Destination = "Washington";
            FlightTime = 190;

        }
        public Flight(string departurePoint, string destination, int flightTimeInMinutes)
        {
            DeparturePoint = departurePoint;
            Destination = destination;
            FlightTime = flightTimeInMinutes;

        }
    }
    
}
