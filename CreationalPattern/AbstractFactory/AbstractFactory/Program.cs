using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using static AbstractFactory.Client;

namespace AbstractFactory
{
    class Program
    {
        static void Main(string[] args)
        {
            Client checker = new Client(MANUFACTURERS.SAMSUNG);
            checker.CheckProducts();
            Console.ReadLine();

            checker = new Client(MANUFACTURERS.HTC);
            checker.CheckProducts();
            Console.ReadLine();

            checker = new Client(MANUFACTURERS.NOKIA);
            checker.CheckProducts();
            Console.Read();


        }
    }
}
