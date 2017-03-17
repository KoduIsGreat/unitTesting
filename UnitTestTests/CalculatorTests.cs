using Microsoft.VisualStudio.TestTools.UnitTesting;
using ConsoleApplication4;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApplication4.Tests
{
    [TestClass()]
    public class CalculatorTests
    {
        private Calculator calc = new Calculator();

        [TestMethod()]
        public void CalculatorTest()
        {
            
        }

        [TestMethod()]
        public void addTest()
        {
            Assert.AreEqual(2,calc.add(1, 1));
        }

        [TestMethod()]
        public void subtractTest()
        {
            Assert.AreEqual(3, calc.subtract(6, 3));
        }

        [TestMethod()]
        public void productTest()
        {
            Assert.AreEqual(5, calc.product(5, 1));
        }

        [TestMethod()]
        public void divisionTest()
        {
            Assert.AreEqual(2, calc.division(4, 2));
        }
    }
}