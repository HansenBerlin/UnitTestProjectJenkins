using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using BreakMe;
using Xunit;

namespace XUnitsTests
{
    public class XUnitTestArithmeticFunctions
    {
        [Fact]
        public void TestAddFunktion()
        {
            Model.InputNumberOne = 10;
            Model.InputNumberTwo = 10;
            Model.InputOperator = "+";
            Assert.Equal(20, Controller.Calculate());
        }
    }
}
