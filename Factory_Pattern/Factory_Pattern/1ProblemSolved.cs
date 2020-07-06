using System;
using System.CodeDom;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Factory_Pattern
{
    public enum CordinateSystem
    {
        Cartesian,
        Polar
    }

    // Issues solved are:
    // 1. It deals with the problem of creating objects (products) without specifying the exact class of object that will be created.
    // 2. The process of objects created is required to centralize within the application.
    // 3. A class (creator) will not know what classes it will be required to create.
    // 4. A Subclasses figure out what objects should be created.

    // This class accepts cordinates (Polar and Cratesian), here constructor third parameter added .. 
    // Form1 class needs to know about the SubClass details (third parameter).
    // This issue needs to be solved..
    class ProblemSolved
    {
        private double x, y;

        public ProblemSolved(double a, double b, int system)
        {
            switch (system)
            {
                case (int)CordinateSystem.Cartesian:
                    x = a;
                    y = b;
                    break;
                case (int)CordinateSystem.Polar:
                    x = a * Math.Cos(b);
                    y = a * Math.Sin(b);
                    break;
                default:
                    throw new ArgumentOutOfRangeException(nameof(system), system, null);
            }
        }

    }
}
