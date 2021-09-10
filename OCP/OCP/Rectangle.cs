using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace OCP
{
    public class Rectangle : Shape
    {
        public double Height { get; set; }
        public double Width { get; set; }

        public Rectangle(double height, double width)
        {
            this.Height = height;
            this.Width = width;
        }
    
        public override double CalculateArea()
        {
            return Height * Width;
        }
    }
}
