using AbstractFactory.Smart;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AbstractFactory.ConcreteFactories
{
    class SamsungFactory : IPhoneFactory
    {
        public ISmart GetSmart()
        {
            return new GalaxyS2();
        }

        public IDumb GetDumb()
        {
            return new Primo();
        }
    }
}
