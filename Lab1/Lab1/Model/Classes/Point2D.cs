    public class Point2D
{
    
    private double _x;
    
    
    private double _y;
    
    /// <summary>
    /// Получает координату X точки.
    /// </summary>
    public double X
    {
        get { return _x; }
        private set
        {
            Validator.AssertOnPositiveValue(value);
            _x = value;
        }
    }
    
    /// <summary>
    /// Получает координату Y точки.
    /// </summary>
    public double Y
    {
        get { return _y; }
        private set
        {
            Validator.AssertOnPositiveValue(value);
            _y = value;
        }
    }

    /// <summary>
    /// Инициализирует новый экземпляр класса Point2D с указанными координатами.
    /// </summary>
    /// <param name="x">Координата X.</param>
    /// <param name="y">Координата Y.</param>
    public Point2D(double x, double y)
    {
        X = x;
        Y = y;
    }

    /// <summary>
    /// Перегруженный оператор сложения для точек, возвращает новую точку с координатами, равными сумме координат исходных точек.
    /// </summary>
    /// <param name="point1">Первая точка.</param>
    /// <param name="point2">Вторая точка.</param>
    /// <returns>Результат сложения двух точек.</returns>
    public static Point2D operator +(Point2D point1, Point2D point2)
    {
        return new Point2D(point1.X + point2.X, point1.Y + point2.Y);
    }

    /// <summary>
    /// Перегруженный оператор вычитания для точек, возвращает новую точку с координатами, равными разности координат исходных точек.
    /// </summary>
    /// <param name="point1">Первая точка.</param>
    /// <param name="point2">Вторая точка.</param>
    /// <returns>Результат вычитания двух точек.</returns>
    public static Point2D operator -(Point2D point1, Point2D point2)
    {
        return new Point2D(point1.X - point2.X, point1.Y - point2.Y);
    }
}
