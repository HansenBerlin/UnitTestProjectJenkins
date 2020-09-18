using System;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using BreakMe;

namespace MSUnitTests
{
    [TestClass]
    public class TestArithmeticFunctions
    {
        [TestMethod]
        public void TestAddFunktion()
        {
            Model.InputNumberOne = 10;
            Model.InputNumberTwo = 10;
            Model.InputOperator = "+";
            Controller.Calculate();
            Assert.AreEqual(Model.Output, 20);
        }

        
    }
}
