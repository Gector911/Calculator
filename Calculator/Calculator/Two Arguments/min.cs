using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Calculator
{
    public class min : ICalculator
    {
        public double Calculate(double firstArgument, double secondArgument)
        {
            return (Math.Min(firstArgument, secondArgument));
        }
    }
}
