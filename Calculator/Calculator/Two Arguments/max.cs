using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Calculator
{
    public class max : ICalculator
    {
        public double Calculate(double firstArgument, double secondArgument)
        {
            return (Math.Max(firstArgument, secondArgument));
        }
    }
}
