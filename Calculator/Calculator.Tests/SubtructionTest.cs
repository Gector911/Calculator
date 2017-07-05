using NUnit.Framework;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Calculator.Tests
{
    [TestFixture]
    public class SubtructionTests
    {
        [TestCase(57, 7, 50)]
        [TestCase(21, 4, 17)]
        [TestCase(8, -2, 10)]
        public void CalculateTest(double firstValue, double secondValue, double expected)
        {
            var calc = new Subtraction();
            var actual = calc.Calculate(firstValue, secondValue);
            Assert.AreEqual(expected, actual);
        }
    }
}