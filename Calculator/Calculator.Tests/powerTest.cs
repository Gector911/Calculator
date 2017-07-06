using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Calculator.Two_Arguments;
using NUnit.Framework;

namespace Calculator.Tests
{
    class powerTest
    {
        [TestCase(2, 5, 32)]
        [TestCase(4, 3, 64)]
        [TestCase(7, 3, 343)]
        public void CalculateTest(double firstValue, double secondValue, double expected)
        {
            var calc = new power();
            var actual = calc.Calculate(firstValue, secondValue);
            Assert.AreEqual(expected, actual);
        }
    }
}
