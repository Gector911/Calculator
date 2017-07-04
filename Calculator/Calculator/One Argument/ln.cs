using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Calculator
{
    public class ln : CalcForOneArgument
    {
        public double Calculate(double firstArgument)
        {
            return (Math.Log(firstArgument));
        }
    }
}
