using Lab1.Model.Classes;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
internal class CollisionManager
{
    bool IsCollision(Rectangle rectangle1, Rectangle rectangle2)
    {
        if (Math.Abs(rectangle1.CenterOfRectangle.X - rectangle2.CenterOfRectangle.X) < Math.Abs(rectangle1.Wight - rectangle2.Wight))
        {
        return true;
        }
        if (Math.Abs(rectangle1.CenterOfRectangle.Y - rectangle2.CenterOfRectangle.Y) < Math.Abs(rectangle1.Lenght - rectangle2.Lenght))
        { 
        return true;
        }
        else
        {
        return false;
        }
    }
    bool IsCollision(Ring ring1, Ring ring2)
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
