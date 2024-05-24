using System.ComponentModel.DataAnnotations;

class Time
    {
        private int _hours;
        private int _minutes;
        private int _seconds;
        /// <summary>
        /// Возвращает или устанавливает часы.
        /// </summary>
        public int  Hours 
        {
            get { return _hours; }
            set
            {
               
                Validator.AssertValueInRange(value, 0, 23);
                _hours = value;
            }
        }
        /// <summary>
        /// Возвращает или устанавливает минуты.
        /// </summary>
        public int Minutes
        {
            get { return _minutes; }
            set
            {
                
                Validator.AssertValueInRange(value, 0, 60);
                _minutes = value;
            }
        }
        /// <summary>
        /// Возвращает или устанавливает секунды.
        /// </summary>
        public int Seconds
        {
            get { return _seconds; }
            set
            {
                Validator.AssertValueInRange(value,0 , 60);
                _seconds = value;
            }
        }
        /// <summary>
        /// Инициализирует новый объект Time с значениями по умолчанию.
        /// </summary>
        public Time()
        {
            Hours = 4;
            Minutes = 2;
            Seconds = 38;

        }
        /// <summary>
        /// Инициализирует новый объект Time с указанными часами, минутами и секундами.
        /// </summary>
        /// <param name="hours">Часы.</param>
        /// <param name="minutes">Минуты.</param>
        /// <param name="seconds">Секунды.</param>
        public Time(int hours, int minutes, int seconds)
        {
            Hours = hours;
            Minutes = minutes;
            Seconds = seconds;

        }

    }

