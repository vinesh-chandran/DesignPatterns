using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Factory_Pattern.WithoutInterface
{
    class PointProgram
    {
        private double x, y;

        private PointProgram(double x, double y)
        {
            this.x = x;
            this.y = y;
        }

        // Factory Method.
        public static PointProgram NewCartesianPoint(double x, double y)
        {
            return new PointProgram(x,y);
        }

        // Factory Method.
        public static PointProgram NewPolarsPoint(double rho, double theta)
        {
            return new PointProgram(rho*Math.Cos(theta), rho * Math.Sin(theta));
        }
    }
}
