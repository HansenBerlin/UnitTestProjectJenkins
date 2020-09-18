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
            Assert.AreEqual(Program.Add(10, 10), 20);
        }

        [TestMethod]
        public void TestSubstractFunktion()
        {
            Assert.AreEqual(Program.Substract(10, 10), 0);
        }
    }
}
