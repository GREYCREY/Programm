
    public class СreatingRectangle
    {
        public static Rectangle[] Randomize(int size, int width, int height)
        {
            Rectangle[] rectangles = new Rectangle[size];
            Random ran = new Random();
            for (int i = 0; i < size; i++)
            {
                rectangles[i] = new Rectangle();
                rectangles[i].Wight = ran.Next(10, 200);
                rectangles[i].Lenght = ran.Next(10, 200);
                rectangles[i].CenterOfRectangle = new Point2D(ran.Next(0, width), ran.Next(0, height));
            }
            return rectangles;
        }
    }
