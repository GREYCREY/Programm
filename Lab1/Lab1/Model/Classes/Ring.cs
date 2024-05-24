using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Lab1.Model.Classes
{
    internal class Ring
    {
        /// <summary>
        /// Внешний радиус кольца.
        /// </summary>
        
        private double _outerRadius;
        
        /// <summary>
        /// Внутренний радиус кольца.
        /// </summary>
        
        private double _innerRadius;
        
        /// <summary>
        /// Центр кольца.
        /// </summary>
        
        public Point2D CenterOfRing;
        
        /// <summary>
        /// Площадь кольца.
        /// </summary>
        
        private double AreaOfRing;

        /// <summary>
        /// Свойство для доступа к внешнему радиусу кольца.
        /// </summary>
        public double OuterRadius
        {
            get { return _outerRadius; }
            set
            {
                Validator.AssertValueInRange(value,0, _innerRadius);
                _outerRadius = value;
            }
        }
        /// <summary>
        /// Свойство для доступа к внутреннему радиусу кольца.
        /// </summary>
        public double InnerRadius
        {
            get { return _innerRadius; }
            set
            {
                Validator.AssertValueInRange(value, _outerRadius, 100);
                _innerRadius = value;
            }
        }
        
        /// <summary>
        /// Конструктор для создания экземпляра кольца.
        /// </summary>
        /// <param name="outerRadius">Внешний радиус кольца.</param>
        /// <param name="innerRadius">Внутренний радиус кольца.</param>
        /// <param name="center">Центр кольца.</param>

        public Ring(double outerRadius, double innerRadius, Point2D center)
        {
            OuterRadius = outerRadius;
            InnerRadius = innerRadius;
            CenterOfRing = center;
            AreaOfRing = Math.PI * Math.Pow(_innerRadius, 2) - Math.PI * Math.Pow(_outerRadius, 2);
        }
    }
}
