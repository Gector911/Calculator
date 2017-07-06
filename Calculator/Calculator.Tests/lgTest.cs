using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Calculator.One_Argument;
using NUnit.Framework;

namespace Calculator.Tests
{
    class lgTest
    {
        [TestCase(100000, 5)]
        [TestCase(10, 1)]
        [TestCase(1, 0)]
        public void CalculateTest(double firstValue, double expected)
        {
            var calc = new lg();
            var actual = calc.Calculate(firstValue);
            Assert.AreEqual(expected, actual);
        }
    }
}
