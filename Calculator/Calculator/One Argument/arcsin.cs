using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Calculator
{
    public class arcsin : CalcForOneArgument
    {
        public double Calculate(double firstArgument)
        {
            return (Math.Asin(firstArgument));
        }
    }
}
