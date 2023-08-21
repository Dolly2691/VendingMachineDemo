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
        public void AddCoin_ValidInput_ResultAmountAdded()
        {
            var vendingMachine= new VendingMachine();
            var result=vendingMachine.AddCointoCurrentAmount(.05);
            Assert.IsTrue(result);
        }
        [TestMethod()]
        public void AddCoin_InValidInput_ResultAmountNotAdded()
        {
            var vendingMachine = new VendingMachine();
            var result = vendingMachine.AddCointoCurrentAmount(1);
            Assert.IsFalse(result);
        }
        [TestMethod()]
        public void WantToAddMoreMoney_InValidInput_ResultAmountNotAdded()
        {
            var vendingMachine = new VendingMachine();
            var result = vendingMachine.LookForAvailableProduct();
            Assert.IsFalse(result);
        }
        [TestMethod()]
        public void WantToAddMoreMoney_EnoughMoneyAdded_ResultTrue()
        {
            var vendingMachine = new VendingMachine();
            vendingMachine.CurrentAmount = 110;
            var result = vendingMachine.LookForAvailableProduct();

            Assert.IsTrue(result);
        }
        [TestMethod()]
        public void WantToCountineShopping_YAsInput_ResultTrue()
        {
            var program = new Program();
            var result = VendingMachine.WantToCountineShopping("Y");
            Assert.IsTrue(result);
        }
        [TestMethod()]
        public void WantToCountineShopping_InvalidAsInput_ResultTrue()
        {
            var program =new Program();
         
            var result = VendingMachine.WantToCountineShopping("XYZ");
            Assert.IsTrue(result);
        }
        [TestMethod()]
        public void WantToCountineShopping_NAsInput_ResultFalse()
        {
            var program = new Program();
            var result = VendingMachine.WantToCountineShopping("N");
            Assert.IsFalse(result);
        }



    }
}