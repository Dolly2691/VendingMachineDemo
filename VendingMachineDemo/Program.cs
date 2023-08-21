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
                var coin = new Coin();
                
                    Console.WriteLine("\n Welcome to Vending Machine!");
                    coin.showMessageToEnterCoin();
                    vendingMachine.AddCointoCurrentAmount(Convert.ToDouble(Console.ReadLine()));
                    vendingMachine.LookForAvailableProduct();
                    Console.WriteLine("\n________Press Y to Continue or N to Stop!_______\n");
            }
            while (VendingMachine.WantToCountineShopping(Console.ReadLine()));
        }
    }
}
