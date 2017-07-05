using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Calculator
{
    public class power : ICalculator
    {
        public double Calculate(double firstArgument, double secondArgument)
        {
            return (Math.Pow(firstArgument, secondArgument));
        }
    }
}
