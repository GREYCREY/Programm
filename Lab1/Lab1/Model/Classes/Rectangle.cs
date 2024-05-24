using System.CodeDom.Compiler;
    ///<summary>
    ///<para>Класс представляет собой прямоугольник.</para>
    ///<para>Позволяет хранить и управлять характеристиками прямоугольника.</para>
    ///<para>Прямоугольник может быть создан с помощью конструктора по умолчанию или с указанием параметров.</para>
    ///</summary>
    public class Rectangle
    {
        ///<summary>
        ///<para>Длина прямоугольника.</para>
        ///</summary>
        
        private double _lenght;
        
        ///<summary>
        ///<para>Ширина прямоугольника.</para>
        ///</summary>
        
        private double _width;
        
        ///<summary>
        ///<para>Цвет прямоугольника.</para>
        ///</summary>
        public Colors ColorOfRectangle { get; set; }
        
        ///<summary>
        ///<para>Центр прямоугольника.</para>
        ///</summary>
        
        public Point2D CenterOfRectangle;
        
        ///<summary>
        ///<para>Счетчик всех созданных прямоугольников.</para>
        ///</summary>
        
        private static int _allRectanglesCount;
        
        ///<summary>
        ///<para>Уникальный идентификатор прямоугольника.</para>
        ///</summary>
        
        readonly int _id;
        
        ///<summary>
        ///<para>Возвращает уникальный идентификатор прямоугольника.</para>
        ///</summary>
        
        public int ID 
        {
        get { return _id; } 
        }
        
        ///<summary>
        ///<para>Возвращает количество всех созданных прямоугольников.</para>
        ///</summary>
        public int AllRectanglesCount
        {
            get { return _allRectanglesCount; }
            set { _allRectanglesCount = value; }
        }
        
        ///<summary>
        ///<para>Получает или устанавливает длину прямоугольника.</para>
        ///</summary>
        public double Lenght
        {
            get { return _lenght; }
            set
            {
                Validator.AssertOnPositiveValue(value);
                _lenght = value;
            }
        }

        ///<summary>
        ///<para>Получает или устанавливает ширину прямоугольника.</para>
        ///</summary>
        public double Wight
        {
            get { return _width; }
            set
            {
                Validator.AssertOnPositiveValue(value);
                _width = value;
            }
        }

        ///<summary>
        ///<para>Инициализирует новый экземпляр класса Rectangle с предустановленными значениями.</para>
        ///</summary>
        public Rectangle()
        {
            Lenght = 4.7;
            Wight = 17.1;
            ColorOfRectangle = Colors.Yellow;
        CenterOfRectangle = new Point2D(0, 0);

        }

        ///<summary>
        ///<para>Инициализирует новый экземпляр класса Rectangle с указанными параметрами.</para>
        ///</summary>
        ///<param name="lenght">Длина прямоугольника.</param>
        ///<param name="width">Ширина прямоугольника.</param>
        ///<param name="color">Цвет прямоугольника.</param>
        ///<param name="_x">Координата X центра прямоугольника.</param>
        ///<param name="_y">Координата Y центра прямоугольника.</param>
        public Rectangle(double lenght, double width, Colors color, double _x, double _y)
        {
            Lenght = lenght;
            Wight = width;
            ColorOfRectangle = color;
            CenterOfRectangle = new Point2D(_x +Lenght/2,_y + Wight/2);
            _allRectanglesCount++;
            _id = AllRectanglesCount;
        }
        
        ///<summary>
        ///<para>Возвращает строковое представление прямоугольника.</para>
        ///</summary>

        public override string ToString()
        {
            return $"w:{Wight}, l:{Lenght}";
        }
    }

