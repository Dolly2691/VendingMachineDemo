using Microsoft.VisualStudio.TestTools.UnitTesting;
using VendingMachineDemo;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace VendingMachineDemo.Tests
{
    [TestClass()]
    public class VendingMachineTests
    {
        [TestMethod()]
        public void AddCoin_ValidInput_ResultMonedyAdded()
        {
            var vendingMachine= new VendingMachine();
            var result=vendingMachine.AddCoin(5);
            Assert.IsTrue(result);
        }
        [TestMethod()]
        public void AddCoin_InValidInput_ResultMonedyNotAdded()
        {
            var vendingMachine = new VendingMachine();
            var result = vendingMachine.AddCoin(1);
            Assert.IsFalse(result);
        }

       
    }
}