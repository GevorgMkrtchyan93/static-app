using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace StaticApp
{
    static class Triangle
    {
        public static int basis;
        public static int height;
        public static int firstSide;
        public static int secondSide;
        static Triangle()
        {
            basis = 12;
            height = 5;
            firstSide = 7;
            secondSide = 4;
        }
        public static void CalculateArea()
        {
            double area = 0.5 * height * basis;
            Console.WriteLine($"Area of Triangle: {area}");
        }
        public static void CalculatePerimeter()
        {
            int perimeter = basis + firstSide + secondSide;
            Console.WriteLine($"Perimeter of Triangle: {perimeter}");
        }
    }
}
