using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SomeLibrary
{
    class Circle
    {

        public bool IsInside(double x0, double y0, double x, double y, double radius)
        {

            double d = Math.Sqrt(Math.Pow(x0 - x, 2) + Math.Pow(y0 - y, 2));
            if (d <= radius)
                return true;
            else
                return false;
        }
    }
}
