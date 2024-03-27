    class Rectangle
    {
        private int _lenght;
        private int _width;
        public Colors ColorOfRectangle { get; set; }
        public int Lenght
        {
            get { return _lenght; }
            set
            {
                Validator.AssertOnPositiveValue(value);
                _lenght = value;
            }
        }
        public int Wight
        {
            get { return _width; }
            set
            {
                Validator.AssertOnPositiveValue(value);
                _width = value;
            }
        }


        public Rectangle()
        {
            Lenght = 4;
            Wight = 17;
            ColorOfRectangle = Colors.Yellow;

        }
        public Rectangle(int lenght, int width, Colors color)
        {
            Lenght = lenght;
            Wight = width;
            ColorOfRectangle = color;

        }

        public override string ToString()
        {
            return $"w:{Wight}, l:{Lenght}";
        }
    }

