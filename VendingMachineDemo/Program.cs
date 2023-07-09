using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace VendingMachineDemo
{
   public  class Program
    {
        static void Main(string[] args)
        {

            do
            {   
                var vendingMachine = new VendingMachine();
                do
                {
                    Console.WriteLine("\n Welcome to Vending Machine !");
                    Console.WriteLine("\nEnter Coin\n");
                    Console.WriteLine("5 for Nickle ");
                    Console.WriteLine("10 for Dime");
                    Console.WriteLine("25 for Quarter");
                    Console.WriteLine("1 for Pennies\n");
                 
                    vendingMachine.AddCoin(Convert.ToInt32(Console.ReadLine()));
                }
                while (!vendingMachine.WantToAddMoreCoin());

                vendingMachine.ShowProductSelection();

               
            }
            
            while (VendingMachine.WantToCountineShopping(Console.ReadLine()));
        }
    }
}
