using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace OCP
{
    public class Triangle : Shape
    {
        public double Base { get; set; }
        public double Height { get; set; }

        public Triangle(double vbase, double vheight)
        {
            this.Base = vbase;
            this.Height = vheight;
        }

        public override double CalculateArea()
        {
            return 1 / 2.0 * Base * Height;
        }
    }
}
