using NUnit.Framework;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Calculator.Tests
{
    [TestFixture]
    public class AdditionTests
    {
        [TestCase(557, 43, 600)]
        [TestCase(21, 40, 61)]
        [TestCase(67, -2, 65)]
        public void CalculateTest(double firstValue, double secondValue, double expected)
        {
            var calc = new Addition();
            var actual = calc.Calculate(firstValue, secondValue);
            Assert.AreEqual(expected, actual);
        }
    }
}