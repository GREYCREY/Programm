using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Lab1.Model.Classes
{
    internal class Ring
    {
        private double _outerRadius;
        private double _innerRadius;
        public Point2D CenterOfRing;
        private double AreaOfRing;
        
        public double OuterRadius
        {
            get { return _outerRadius; }
            set
            {
                Validator.AssertValueInRange(value,0, _innerRadius);
                _outerRadius = value;
            }
        }
        public double InnerRadius
        {
            get { return _innerRadius; }
            set
            {
                Validator.AssertValueInRange(value, _outerRadius, 100);
                _innerRadius = value;
            }
        }
        public Ring(double outerRadius, double innerRadius, Point2D center)
        {
            OuterRadius = outerRadius;
            InnerRadius = innerRadius;
            CenterOfRing = center;
            AreaOfRing = Math.PI * Math.Pow(_innerRadius, 2) - Math.PI * Math.Pow(_outerRadius, 2);
        }
    }
}
