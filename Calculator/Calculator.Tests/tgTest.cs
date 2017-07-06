using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Calculator.One_Argument;
using NUnit.Framework;

namespace Calculator.Tests
{
    class tgTest
    {
        [TestCase(0, 0)]
   

        public void CalculateTest(double firstValue, double expected)
        {
            var calc = new tg();
            var actual = calc.Calculate(firstValue);
            Assert.AreEqual(expected, actual);
        }
    }
}
