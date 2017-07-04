using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Calculator
{
    static class AdditionalFactory
    {
               public static CalcForOneArgument CreateAdditionalCalculator(string calcName)
        {
            switch (calcName)
            {
                case "button5":
                    return new sin();
                case "button6":
                    return new cos();
                case "button7":
                    return new tg();
                case "button8":
                    return new ctg();
                case "button9":
                    return new lg();
                case "button10":
                    return new ln();
                default:
                    throw new Exception("unknown operation");
            }

        }
    }
}
