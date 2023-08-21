using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Xml.Linq;

namespace VendingMachineDemo
{
    public class Coin
    {
        private const double nickle = .05;
        private const double dime = .10;
        private const double quarter = .25;
        public double NICKLE
        {
            get { return nickle; }

        }
        public double DIME
        {
            get { return dime; }

        }
        public double QUARTER
        {
            get { return quarter; }

        }

        public void showMessageToEnterCoin()
        {
            Console.WriteLine("\nEnter Coin\n");
            Console.WriteLine("$.05 for Nickle ");
            Console.WriteLine("$.1 for Dime");
            Console.WriteLine("$.25 for Quarter");
        }

    }
}
