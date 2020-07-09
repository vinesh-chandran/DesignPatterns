using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Factory_Pattern.WithInterface
{
    // Concrete creator..
    class PointFactory
    {
        public IPointDraw CreateFactory(int cordinateSystem)
        {
            IPointDraw returnInterface = null;

            switch (cordinateSystem)
            {
                case 1:
                    var objCartesian = new CartesianPoint();
                    returnInterface = objCartesian;
                    break;
                case 2:

                    var objPolarCord = new PolarPoint();
                    returnInterface = objPolarCord;
                    break;

                default:
                    return null;
            }
            return returnInterface;
        }
    }
}
