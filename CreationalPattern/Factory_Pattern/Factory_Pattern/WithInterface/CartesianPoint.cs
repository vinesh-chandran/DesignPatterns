using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Factory_Pattern.WithInterface
{
    // Concrete products..
    class CartesianPoint : IPointDraw
    {
        public double x_Cordiate, y_Cordinate;
        public void Draw(double x, double y)
        {
            x_Cordiate = x;
            y_Cordinate = y;
        }
    }
}
