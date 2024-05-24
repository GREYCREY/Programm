    /// <summary>
    /// Класс, представляющий дисциплину.
    /// </summary>
    class Discipline
    {
        private string _name;
        private string _type;
        private int _numberOfVisits;
        /// <summary>
        /// Название дисциплины.
        /// </summary>
        /// <exception cref="ArgumentException">Выбрасывается, если значение пустое.</exception>
        private string Name
        {
            get { return _name; }
            set
            {
                if (value.Length == 0) throw new ArgumentException();
                _name = value;
            }
        }
        /// <summary>
        /// Тип дисциплины.
        /// </summary>
        /// <exception cref="ArgumentException">Выбрасывается, если значение пустое.</exception>
        private string Type
        {
            get { return _type; }
            set
            {
                if (value.Length == 0) throw new ArgumentException();
                _type = value;
            }
        }
        /// <summary>
        /// Количество посещений.
        /// </summary>
        /// <exception cref="ArgumentException">Выбрасывается, если значение не положительное.</exception>
        private int NumberOfVisits
        {
            get { return _numberOfVisits; }
            set
            {
                Validator.AssertOnPositiveValue(value);
                _numberOfVisits = value;
            }
        }
        /// <summary>
        /// Конструктор с параметрами.
        /// </summary>
        /// <param name="name">Название дисциплины.</param>
        /// <param name="type">Тип дисциплины.</param>
        /// <param name="numberOfVisits">Количество посещений.</param>
        public Discipline(string name, string type, int numberOfVisits)
        {
            Name = "Информационные технологии";
            Type = "Профильный";
            NumberOfVisits = 52;

        }
        
    }
        

