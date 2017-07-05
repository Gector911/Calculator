using NUnit.Framework;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Calculator.Tests
{
    [TestFixture]
    public class DivisionTests
    {
        [TestCase(550, 50, 11)]
        [TestCase(20, 2, 10)]
        [TestCase(40, 10, 4)]
        public void CalculateTest(double firstValue, double secondValue, double expected)
        {
            var calc = new Division();
            var actual = calc.Calculate(firstValue, secondValue);
            Assert.AreEqual(expected, actual);
        }
    }
}