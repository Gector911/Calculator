using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Calculator
{
  public  static class CalculatorsFactory
    {
        public static ICalculator CreateCalculator(string calcName)
        {
            
            switch (calcName)
            {
                case "Subtraction":
                    return new Subtraction();
                case "Addition":
                    return new Addition();
                case "Multiplication":
                    return new Multiplication();
                case "Division":
                    return new Division();
                case "power":
                    return new power();
                case "min":
                    return new min();
                case "max":
                    return new max();
                default:
                    throw new Exception("unknown operation");
            }
        }
 
    }
}
