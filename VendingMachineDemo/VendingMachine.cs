using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Linq;
using System.Runtime.InteropServices.WindowsRuntime;
using System.Text;
using System.Threading.Tasks;
using static VendingMachineDemo.Enum;

namespace VendingMachineDemo
{
    public class VendingMachine
    {
        Coin coin = new Coin();
        Product product = new Product();
      
        
        public double CurrentAmount { get; set; }
        public VendingMachine()
        {
            Console.Clear();
            CurrentAmount = 0.0;
        }
        public bool AddCointoCurrentAmount(double money)
        {
            switch (money)
            {
                case .05:
                    CurrentAmount += Convert.ToDouble(coin.NICKLE);
                    break;
                case .1:
                      CurrentAmount += Convert.ToDouble(coin.DIME);
                    break;

                case .25:
                     CurrentAmount += Convert.ToDouble(coin.QUARTER);
                    break;
                
                default:
                    
                    Console.WriteLine("\n****Invalid Entry****\n");
                    return false;    
            }
            return true;
        }
        
      
        public  bool LookForAvailableProduct ()
        {
            if (CurrentAmount >= product.COLAPRICE)
            {
                Console.WriteLine("\n Enough Money to buy any product ! Current Amount is {0}: ", CurrentAmount);
               product.ShowProductForSelection(CurrentAmount);
                return true;
            }
            else if
            (CurrentAmount < product.COLAPRICE)
            {
                return WantToAddMoreCoin(CurrentAmount);
            }
            else
            {
               Console.WriteLine("\nNot Enough Money to Buy Product Add More Coins , Otherwise  Amount to be Returned is {0:C}: " , CurrentAmount);
                return WantToAddMoreCoin(CurrentAmount);
            }

            
        }
        public void showMessageBasedonCurrentAmount(double currentAmount)
        {
             if (currentAmount >= product.CANDYPRICE)
            {
                Console.WriteLine("\nEnough Money to buy Chips or Candy! Current Amount is {0}: ", CurrentAmount);
                Console.WriteLine(" Press B to Buy Product or Press R to get back your coins or Press Y to add more Coin");
            }
            else if (currentAmount >= product.CHIPSPRICE)
            {
                Console.WriteLine("\nEnough Money to buy Chips! Current Amount is {0}: ", CurrentAmount);
                Console.WriteLine(" Press B to Buy Product or Press R to get back your coins or Press Y to add more Coin");
            }
            else
            {
                Console.WriteLine("Not Enough Money to Buy Product Add More Coins , Otherwise  Amount to be Returned is {0:C}: ", CurrentAmount);
                Console.WriteLine("Press R to get back your coins or Press Y to add more Coins");
            }
        }
        public  bool WantToAddMoreCoin( double currentAmount)
        {
            showMessageBasedonCurrentAmount(currentAmount);


            string inputValue = Console.ReadLine();
            if (inputValue.ToLower() == "r")
            {
                Console.WriteLine("Please collect your coin : {0}", currentAmount);
               
                return false;
            }
            else if (inputValue.ToLower() == "y")
            {
                coin.showMessageToEnterCoin(); 
                AddCointoCurrentAmount(Convert.ToDouble(Console.ReadLine()));
                return LookForAvailableProduct();
            }
            else if (inputValue.ToLower() == "b")
            {
                product.ShowProductForSelection(currentAmount);
                return true;
            }
            else
            {
                Console.WriteLine("Invalid Entry, Try Again to Add Coin");
                coin.showMessageToEnterCoin();
                AddCointoCurrentAmount(Convert.ToDouble(Console.ReadLine()));
                return LookForAvailableProduct();
            }
        }
        public static bool WantToCountineShopping(string input)
        {
            bool choice = false;
           
            while (!choice)
            {

                if (input.ToLower().Equals("y") )
                { 
                    return true;
                }
                else if (input.ToLower().Equals("n"))
                {

                    return false;
                }
                else
                {
                    Console.WriteLine("\nInvalid Input!..Press Y to Continue or N to Stop!\n");
                    choice = VendingMachine.WantToCountineShopping(Console.ReadLine());
                    return choice;

                }

            }
            return choice;
        }
    }
}
