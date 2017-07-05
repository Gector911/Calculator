using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Calculator
{
    public class sqrt : CalcForOneArgument
    {
        public double Calculate(double firstArgument)
        {
            return (Math.Sqrt(firstArgument));
        }
    }
}
