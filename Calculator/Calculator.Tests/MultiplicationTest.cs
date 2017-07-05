using NUnit.Framework;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Calculator.Tests
{
    [TestFixture]
    public class MultiplicationTests
    {
        [TestCase(20, 5, 100)]
        [TestCase(50, 41, 2050)]
        [TestCase(65, -2, -130)]
        public void CalculateTest(double firstValue, double secondValue, double expected)
        {
            var calc = new Multiplication();
            var actual = calc.Calculate(firstValue, secondValue);
            Assert.AreEqual(expected, actual);
        }
    }
}