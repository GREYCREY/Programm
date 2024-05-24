using Lab1.Model.Classes;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
/// <summary>
/// Класс, управляющий пересечениями объектов.
/// </summary>
internal class CollisionManager
{
    /// <summary>
    /// Проверяет столкновение двух прямоугольников.
    /// </summary>
    /// <param name="rectangle1">Первый прямоугольник.</param>
    /// <param name="rectangle2">Второй прямоугольник.</param>
    /// <returns>Возвращает true, если прямоугольники сталкиваются; в противном случае false.</returns>
    public static bool IsCollision(Rectangle rectangle1, Rectangle rectangle2)
    {
        Point2D region = new Point2D
             (Math.Abs(rectangle2.CenterOfRectangle.X - rectangle1.CenterOfRectangle.X),
             Math.Abs(rectangle2.CenterOfRectangle.Y - rectangle1.CenterOfRectangle.Y));
        Point2D rectangle1mid = new Point2D(rectangle1.Wight / 2, rectangle1.Lenght / 2);
        Point2D rectangle2mid = new Point2D(rectangle2.Wight / 2, rectangle2.Lenght / 2);
        Point2D minRegion = rectangle1mid + rectangle2mid;
        return region.X < minRegion.X && region.Y < minRegion.Y;

    }
    /// <summary>
    /// Проверяет столкновение двух колец.
    /// </summary>
    /// <param name="ring1">Первое кольцо.</param>
    /// <param name="ring2">Второе кольцо.</param>
    /// <returns>Возвращает true, если кольца сталкиваются; в противном случае false.</returns>
    public static bool IsCollision(Ring ring1, Ring ring2)
    {
        if(Math.Abs(Math.Pow(ring1.CenterOfRing.X,2) - Math.Pow(ring2.CenterOfRing.X, 2)) + 
           Math.Abs(Math.Pow(ring1.CenterOfRing.Y, 2) - Math.Pow(ring2.CenterOfRing.Y, 2)) < (ring1.InnerRadius + ring2.InnerRadius))
        {
            return true;
        }
        else
        {
            return false;
        }
    }
    
    
}
