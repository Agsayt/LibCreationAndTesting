using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SomeLibrary
{
    class QEquation
    {
        // Класс для решения квадратного уравнения

        public double[] FindRoots(double a, double b, double c, out string message)
        {
            double d = Math.Pow(b, 2) - 4 * a * c;

            if (d < 0)
            {
                message = "Equation doesn't has any roots";
                return null;
            } 
            else if (d == 0)
            {
                double x = (-b + Math.Sqrt(d)) / (2 * a);
                message = "Equation has one root x = " + x;
                return new double[1] { x };
            }
            else
            {
                double x1 = (-b + Math.Sqrt(d)) / (2 * a);
                double x2 = (-b - Math.Sqrt(d)) / (2 * a);
                message = "Equation has two roots: x1 = " + x1 + "; x2 = " + x2;
                return new double[2] { x1, x2 };
            }

        }
    }
}
