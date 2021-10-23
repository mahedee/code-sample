using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace OCP
{
    public class Circle : Shape
    {
        public double Radius { get; set; }


        public Circle(double radius)
        {
            this.Radius = radius;
        }

        public override double CalculateArea()
        {
            return Math.PI * Radius * Radius;
        }
    }
}
