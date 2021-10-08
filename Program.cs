using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace StaticApp
{
    class Program
    {
        static void Main(string[] args)
        {
            int area = Rectangle.CalculateArea(6, 10);
            Console.WriteLine($"Area={area}");
            int perimeter = Rectangle.CalculatePerimeter(6, 10);
            Console.WriteLine($"Perimeter={perimeter}");

            Triangle.CalculateArea();
            Triangle.CalculatePerimeter();

            double areaCircle = Circle.CalculateArea(5);
            Console.WriteLine($"Area of Circle: {areaCircle}");
            Console.ReadLine();
        }
    }
}
