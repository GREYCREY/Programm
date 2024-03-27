    class Discipline
    {
        private string _name;
        private string _type;
        private int _numberOfVisits;
        private string Name
        {
            get { return _name; }
            set
            {
                if (value.Length == 0) throw new ArgumentException();
                _name = value;
            }
        }
        private string Type
        {
            get { return _type; }
            set
            {
                if (value.Length == 0) throw new ArgumentException();
                _type = value;
            }
        }
        private int NumberOfVisits
        {
            get { return _numberOfVisits; }
            set
            {
                Validator.AssertOnPositiveValue(value);
                _numberOfVisits = value;
            }
        }
        public Discipline(string name, string type, int numberOfVisits)
        {
            Name = "Информационные технологии";
            Type = "Профильный";
            NumberOfVisits = 52;

        }
        
    }
        

