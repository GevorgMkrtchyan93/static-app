using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace StaticApp
{
    public class Rectangle
    {
        private static int _width;
        private static int _height;
        public Rectangle(int width, int height)
        {
            _width = width;
            _height = height;
        }

        public static int CalculateArea(int width, int height)
        {
            return width * height;
        }
        public static int CalculatePerimeter(int width, int height)
        {
            return 2 * width + 2 * height;
        }
    }
}
