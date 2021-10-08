using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace StaticApp
{
    public class Circle
    {
        public const double pi = 3.14;
        public static int _r;
        public Circle(int r)
        {
            _r = r;
        }

        public static double CalculateArea(int r)
        {
            return 2 * pi * r;
        }
    }
}
