using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Lab1.Model.Classes
{
     class Rectangle
    {
        private double _lenght;
        private double _width;
        
        private double ReactangleLenght
        {
            get { return _lenght; }
            set
            {
                if (value < 0) throw new ArgumentException();
                _lenght = value;
            }
        }
        private double ReactangWight
        {
            get { return _width; }
            set
            {
                if (value < 0) throw new ArgumentException();
                _width = value;
            }
        }
        private string ColorOfReactangle { get; set; }
        public Rectangle()
        {
            ReactangleLenght = 12;
            ReactangWight = 5;
            ColorOfReactangle = ColorOfReactangle;

        }
        public Rectangle(double lenght, double width)
        {
            ReactangleLenght = lenght;
            ReactangWight = width;
            ColorOfReactangle = ColorOfReactangle;

        }
    }
}
