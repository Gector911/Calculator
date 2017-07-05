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
            if (firstArgument < 0)
            {
                throw new Exception("sqrt expression < 0");
            }
            return (Math.Sqrt(firstArgument));
        }
    }
}
