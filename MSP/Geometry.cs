using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MSP
{
    class Geometry
    {
        public double GetSquareArea(double a)
        {
            return a * a;
        }
        public double GetTriangleArea(double a, double h)
        {
            return a * h / 2;
        }
        public double GetRectangleArea(double a, double b)
        {
            return a * b;
        }
    }
}
