using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Lab1.Model.Classes
{
    class Discipline
    {
        private string _name;
        private string _type;
        private int _numberOfVisits;
        private string NameOfDiscipline
        {
            get { return _name; }
            set
            {
                if (value.Length == 0) throw new ArgumentException();
                _name = value;
            }
        }
        private string TypeOfDiscipline
        {
            get { return _type; }
            set
            {
                if (value.Length == 0) throw new ArgumentException();
                _type = value;
            }
        }
        private int NumberOfVisitsToTheDiscipline
        {
            get { return _numberOfVisits; }
            set
            {
                if (value < 0) throw new ArgumentException();
                _numberOfVisits = value;
            }
        }
        public Discipline(string name, string type, int numberOfVisits)
        {
            NameOfDiscipline = "Информационные технологии";
            TypeOfDiscipline = "Профильный";
            NumberOfVisitsToTheDiscipline = 52;

        }
        public Discipline(string name, string type, int numberOfVisits)
        {
            NameOfDiscipline = name;
            TypeOfDiscipline = type;
            NumberOfVisitsToTheDiscipline = numberOfVisits;

        }

    }
        
}

