using Microsoft.VisualStudio.TestTools.UnitTesting;
using System;
using System.Configuration;
using VendingMachineDemo;

namespace VendingMachineDemoTests
{
    [TestClass]
    public class ProductTests
    {
        [TestMethod]
        public void ShowProductForSelection()
        {
            var product = new Product();
            var vendingMachine = new VendingMachine();
            var currentAmount= vendingMachine.CurrentAmount = 110;

        }
    }
}
