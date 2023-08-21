using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace VendingMachineDemo
{
    public class Product
    {
        public const double COST_OF_COLA = 1;
        public const double COST_OF_CHIPS = .50;
        public const double COST_OF_CANDY = .65;
        public double COLAPRICE
        {
            get { return COST_OF_COLA; }
        }
        public double CHIPSPRICE
        {
            get { return COST_OF_CHIPS; }
        }
        public double CANDYPRICE
        {
            get { return COST_OF_CANDY; }
        }
        public void ShowProductForSelection(double CurrentAmount)
        {
            if (CurrentAmount >= COST_OF_COLA)
            {
                Console.WriteLine("Press 1 for COLA for $1");
                Console.WriteLine("Press 2 for CHIPS for $.5");
                Console.WriteLine("Press 3 for CANDY for $.65 \n");
                Console.WriteLine("*** Please Choose Your Product ***\n");
            }
            else if (CurrentAmount >= COST_OF_CANDY)
            {
                Console.WriteLine("Press 2 for CHIPS for $.5");
                Console.WriteLine("Press 3 for CANDY for $.65 \n");
                Console.WriteLine("*** Please Choose Your Product ***\n");
            }
            else if (CurrentAmount >= COST_OF_CHIPS)
            {
                Console.WriteLine("Press 2 for CHIPS for $.5 \n");
                Console.WriteLine("*** Please Choose Your Product ***\n");
            }
            SelectProduct(Convert.ToInt32(Console.ReadLine()), CurrentAmount);


        }

        private void SelectProduct(int choiceOfProduct,double currentAmount)
        {
            bool selectionOkay = false;
            while (!selectionOkay)
            {
                switch (choiceOfProduct)
                {
                    case 1:
                        Console.WriteLine("Thank you for Choosing COLA\n");
                        ReturnChange(choiceOfProduct,currentAmount);
                        selectionOkay = true;
                        break;
                    case 2:
                        Console.WriteLine("Thank you for Choosing CHIPS\n");
                        ReturnChange(choiceOfProduct, currentAmount);
                        selectionOkay = true;
                        break;
                    case 3:
                        Console.WriteLine("Thank you for Choosing CANDY\n");
                        ReturnChange(choiceOfProduct, currentAmount);
                        selectionOkay = true;
                        break;
                    default:
                        Console.WriteLine("Invalid Choice , Please re-enter your choice\n\n");
                        choiceOfProduct = Convert.ToInt32(Console.ReadLine());
                        selectionOkay = false;
                        break;
                }
            }
        }
        private void ReturnChange(int selectedProduct,double currentAmount)
        {
            if (selectedProduct == Convert.ToInt32(Enum.Product.Cola))
            {
                if (currentAmount > COST_OF_COLA)
                    Console.WriteLine("\nYour Change is {0}", currentAmount - COST_OF_COLA);
            }
            else if (selectedProduct == Convert.ToInt32(Enum.Product.Chips))
            {
                if (currentAmount > COST_OF_CHIPS)
                    Console.WriteLine("\nYour Change is {0}", currentAmount - COST_OF_CHIPS);
            }
            else if (selectedProduct == Convert.ToInt32(Enum.Product.Candy))
            {
                if (currentAmount > COST_OF_CANDY)
                    Console.WriteLine("\nYour Change is {0}", currentAmount - COST_OF_CANDY);
            }
        }
    }
}
