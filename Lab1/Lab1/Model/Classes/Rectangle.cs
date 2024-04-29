using System.CodeDom.Compiler;

    public class Rectangle
    {
        private double _lenght;
        private double _width;
        public Colors ColorOfRectangle { get; set; }
        public Point2D CenterOfRectangle;
        private static int _allRectanglesCount;
        readonly int _id;
        public int ID 
        {
        get { return _id; } 
        }
        public int AllRectanglesCount
        {
            get { return _allRectanglesCount; }
            set { _allRectanglesCount = value; }
        }
        public double Lenght
        {
            get { return _lenght; }
            set
            {
                Validator.AssertOnPositiveValue(value);
                _lenght = value;
            }
        }
        public double Wight
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
            Lenght = 4.7;
            Wight = 17.1;
            ColorOfRectangle = Colors.Yellow;
        CenterOfRectangle = new Point2D(0, 0);

        }
        public Rectangle(double lenght, double width, Colors color, double _x, double _y)
        {
            Lenght = lenght;
            Wight = width;
            ColorOfRectangle = color;
            CenterOfRectangle = new Point2D(_x +Lenght/2,_y + Wight/2);
            _allRectanglesCount++;
            _id = AllRectanglesCount;

        }

        public override string ToString()
        {
            return $"w:{Wight}, l:{Lenght}";
        }
    }

