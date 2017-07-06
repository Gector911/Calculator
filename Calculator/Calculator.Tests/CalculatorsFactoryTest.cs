using NUnit.Framework;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Calculator.Two_Arguments;

namespace Calculator.Tests
{
    class CalculatorsFactoryTest
    {
        [TestCase("Addition", typeof(Addition))]
        [TestCase("Subtruction", typeof(Subtraction))]
        [TestCase("Multiplication", typeof(Multiplication))]
        [TestCase("Division", typeof(Division))]
        [TestCase("power", typeof(power))]
        [TestCase("min", typeof(min))]
        [TestCase("max", typeof(max))]

        public void CalculateTest(string name, Type type)
        {
            var calculator = CalculatorsFactory.CreateCalculator(name);
            Assert.IsInstanceOf(type, calculator);
        }
        public void Exception()
        {
            Assert.Throws<Exception>(() => CalculatorsFactory.CreateCalculator("Wrong operation"));
        }

    }
}
