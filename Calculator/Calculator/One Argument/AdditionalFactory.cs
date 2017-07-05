using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Calculator
{
   public static class AdditionalFactory
    {
               public static CalcForOneArgument CreateAdditionalCalculator(string calcName)
        {
            switch (calcName)
            {
                case "sin":
                    return new sin();
                case "cos":
                    return new cos();
                case "tg":
                    return new tg();
                case "ctg":
                    return new ctg();
                case "lg":
                    return new lg();
                case "ln":
                    return new ln();
                default:
                    throw new Exception("unknown operation");
            }

        }
    }
}
