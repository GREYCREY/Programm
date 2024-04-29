    public class Point2D
{
    private double _x;
    private double _y;
    public double X
    {
        get { return _x; }
        private set
        {
            Validator.AssertOnPositiveValue(value);
            _x = value;
        }
    }
    public double Y
    {
        get { return _y; }
        private set
        {
            Validator.AssertOnPositiveValue(value);
            _y = value;
        }
    }
    public Point2D(double x, double y)
    {
        X = x;
        Y = y;
    }
    public static Point2D operator +(Point2D point1, Point2D point2)
    {
        return new Point2D(point1.X + point2.X, point1.Y + point2.Y);
    }
    public static Point2D operator -(Point2D point1, Point2D point2)
    {
        return new Point2D(point1.X - point2.X, point1.Y - point2.Y);
    }
}
