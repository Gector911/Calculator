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
                case "arcsin":
                    return new arcsin();
                case "arccos":
                    return new arccos();
                case "arctg":
                    return new arctg();
                case "sinh":
                    return new sinh();
                case "cosh":
                    return new cosh();
                case "tgh":
                    return new tgh();
                case "sqrt":
                    return new sqrt();
                case "decad":
                    return new decad();
                case "exponent":
                    return new exponent();
                default:
                    throw new Exception("unknown operation");
            }

        }
    }
}
