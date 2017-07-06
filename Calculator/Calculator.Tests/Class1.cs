using NUnit.Framework;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Calculator.One_Argument;

namespace Calculator.Tests
{
    [TestFixture]
    public class prob
    {


        [Test]
        public void sinTest()
        {
            var calc = new sin();
            var actual = calc.Calculate(0);
            Assert.AreEqual(0, actual);
        }
        [Test]
        public void cosTest()
        {
            var calc = new cos();
            var actual = calc.Calculate(0);
            Assert.AreEqual(1, actual);
        }
        [Test]
        public void tgTest()
        {
            var calc = new tg();
            var actual = calc.Calculate(0);
            Assert.AreEqual(0, actual);
        }
        [Test]
        public void ctgTest()
        {
            var calc = new ctg();
            var actual = (int)Math.Floor(calc.Calculate(4.7));
            Assert.AreEqual(0, actual);
        }
        [Test]
        public void lg()
        {
            var calc = new lg();
            var actual = calc.Calculate(100000);
            Assert.AreEqual(5, actual);
        }
        [Test]
        public void ln()
        {
            var calc = new ln();
            var actual = calc.Calculate(1);
            Assert.AreEqual(0, actual);
        }
    }
}
