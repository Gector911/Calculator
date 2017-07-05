using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Calculator.One_Argument
{
    public class decad : CalcForOneArgument
    {
        public double Calculate(double firstArgument)
        {
            return (Math.Pow(10, firstArgument));
        }
    }
}
