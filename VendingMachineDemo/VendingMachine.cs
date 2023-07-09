using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.InteropServices.WindowsRuntime;
using System.Text;
using System.Threading.Tasks;

namespace VendingMachineDemo
{
    public class VendingMachine
    {
        
        public const int COST_OF_COLA = 100;
        public const int COST_OF_CHIPS = 50;
        public const int COST_OF_CANDY = 65;
        
        public int CurrentAmount { get; set; }
        public VendingMachine()
        {
            Console.Clear();
            CurrentAmount = 0;
        }
        public bool AddCoin(int money)
        {
            switch (money)
            {
                case 5:
                    CurrentAmount += Convert.ToInt32(Enum.Coins.Nickle);
                    break;
                case 10:
                      CurrentAmount += Convert.ToInt32(Enum.Coins.Dime);
                    break;

                case 25:
                     CurrentAmount += Convert.ToInt32(Enum.Coins.Quarter);
                    break;
                
                default:
                    
                    Console.WriteLine("\n****Invalid Entry****\n");
                    return false;
                    

                    
            }
            return true;
        }
        public void ShowProductSelection()
        {
            Console.WriteLine("Press 1 for COLA for $100");
            Console.WriteLine("Press 2 for CHIPS for $50");
            Console.WriteLine("Press 3 for CANDY for $65 \n");
            Console.WriteLine("*** Please Choose Your Product ***\n");
             SelectProduct(Convert.ToInt32(Console.ReadLine()));
            Console.WriteLine("\n________Press Y to Continue or N to Stop!_______\n");
            
        }

        private void SelectProduct(int choiceOfProduct)
        {
            bool selectionOkay = false;
            while (!selectionOkay)
            {
                switch (choiceOfProduct)
                {
                    case 1:
                        Console.WriteLine("Thank you for Choosing COLA\n");
                        ReturnChange(choiceOfProduct);
                        selectionOkay = true;

                        break;
                    case 2:
                        Console.WriteLine("Thank you for Choosing CHIPS\n");
                        ReturnChange(choiceOfProduct);
                        selectionOkay = true; break;
                    case 3:
                        Console.WriteLine("Thank you for Choosing CANDY\n");
                        ReturnChange(choiceOfProduct);
                        selectionOkay = true; break;
                    default:
                        Console.WriteLine("Invalid Choice , Please re-enter your choice\n\n");
                        choiceOfProduct = Convert.ToInt32(Console.ReadLine());
                        selectionOkay = false;
                        break;

                }
            }
           
        }
       
        private void ReturnChange(int selectedProduct)
        {
            
            if (selectedProduct == Convert.ToInt32(Enum.Product.Cola))
            {
                if (CurrentAmount > COST_OF_COLA)
                    Console.WriteLine("\nYour Change is {0:C}", CurrentAmount - COST_OF_COLA);
            }
            else if (selectedProduct == Convert.ToInt32(Enum.Product.Chips))
            { 
            if (CurrentAmount > COST_OF_CHIPS)
                Console.WriteLine("\nYour Change is {0:C}", CurrentAmount - COST_OF_CHIPS);
            }
            else if (selectedProduct == Convert.ToInt32(Enum.Product.Candy))
            {
                    if (CurrentAmount > COST_OF_CANDY)
                        Console.WriteLine("\nYour Change is {0:C}", CurrentAmount - COST_OF_CANDY);
            }


        }
        public bool WantToAddMoreCoin()
        {
            
            if (CurrentAmount >= COST_OF_COLA)
            {
               
                Console.WriteLine("\nEnough Money to Buy Product! Current Amount is {0:C}: " , CurrentAmount);
                return true;
            }
            else
            {
                
                Console.WriteLine("\nNot Enough Money to Buy Product Add More Coins , Otherwise  Amount to be Returned is {0:C}: " , CurrentAmount);
                return false;
            }

            
        }
        public static bool WantToCountineShopping(string input)
        {
            if (input.Equals("Y") || input.Equals("y"))
            { return true; }
            else if (input.Equals("N") || input.Equals("n"))
            {
                
                return false;
            }
            else
            {
                Console.WriteLine("\nInvalid Input!..Press Y to Continue or N to Stop!\n");
                return true;
            }
        }
    }
}
