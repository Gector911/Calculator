using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Calculator
{
    public class ctg : CalcForOneArgument
    {
        public double Calculate(double firstArgument)
        {
            return (1/Math.Tan(firstArgument));
        }
    }
}
