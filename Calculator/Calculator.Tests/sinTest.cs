using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Calculator.One_Argument;
using NUnit.Framework;

namespace Calculator.Tests
{
    class sinTest
    {
        [TestCase(0, 0)]
        [TestCase(Math.PI / 2, 1)]

        public void CalculateTest(double firstValue, double expected)
        {
            var calc = new sin();
            var actual = calc.Calculate(firstValue);
            Assert.AreEqual(expected, actual);
        }
    }
}
