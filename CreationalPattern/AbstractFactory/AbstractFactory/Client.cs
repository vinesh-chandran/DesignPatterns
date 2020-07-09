using AbstractFactory.ConcreteFactories;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AbstractFactory
{
    public class Client
    {
        public enum MANUFACTURERS
        {
            SAMSUNG,
            HTC,
            NOKIA
        }

        ISmart sam;
        IDumb htc;
        IPhoneFactory factory;
        MANUFACTURERS manu;

        public Client(MANUFACTURERS m)
        {
            manu = m;
        }

        public void CheckProducts()
        {
            switch (manu)
            {
                case MANUFACTURERS.SAMSUNG:
                    factory = new SamsungFactory();
                    break;
                case MANUFACTURERS.HTC:
                    factory = new HTCFactory();
                    break;
                case MANUFACTURERS.NOKIA:
                    factory = new NokiaFactory();
                    break;
            }

            Console.WriteLine(manu.ToString() + ":\nSmart Phone: " +
            factory.GetSmart().Name() + "\nDumb Phone: " + factory.GetDumb().Name());
        }
    }
}
