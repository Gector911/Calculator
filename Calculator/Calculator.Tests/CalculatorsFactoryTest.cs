using NUnit.Framework;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Calculator.Tests
{
    class CalculatorsFactoryTest
    {
        [TestCase("Addition", typeof(Addition))]
        [TestCase("Subtraction", typeof(Subtraction))]
        [TestCase("Multiplication", typeof(Multiplication))]
        [TestCase("Division", typeof(Division))]
        public void CalculateTest(string name, Type type)
        {
            var calculator = CalculatorsFactory.CreateCalculator(name);
            Assert.IsInstanceOf(type, calculator);
        }
 

    }
}
