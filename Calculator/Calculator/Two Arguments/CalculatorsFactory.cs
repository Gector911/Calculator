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
                default:
                    throw new Exception("unknown operation");
            }
        }
 
    }
}
