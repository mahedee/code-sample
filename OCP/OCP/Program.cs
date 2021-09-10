using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace OCP
{
    public class Program
    {
        public static void Main(string[] args)
        {
            Shape objShape = new Rectangle(20, 30);
            Console.WriteLine("Area of Rectangle: " + objShape.CalculateArea());

            objShape = new Triangle(20, 30);
            Console.WriteLine("Area of Triangle: " + objShape.CalculateArea());

            objShape = new Circle(4);
            Console.WriteLine("Area of Circle: " + objShape.CalculateArea());


            Console.ReadKey();
        }
    }
}
