using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Calculator
{
    static class CalculatorsFactory
    {
        public static ICalculator CreateCalculator(string calcName)
        {
            
            switch (calcName)
            {
                case "button1":
                    return new Subtraction();
                case "button2":
                    return new Addition();
                case "button3":
                    return new Multiplication();
                case "button4":
                    return new Division();
                default:
                    throw new Exception("unknown operation");
            }
        }
    }
}
