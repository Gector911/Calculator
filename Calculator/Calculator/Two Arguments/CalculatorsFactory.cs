using System;

namespace Calculator.Two_Arguments
{
    /// <summary>
    /// This class creates new calculator for two argument
    /// </summary>
    public static class CalculatorsFactory
    {
        public static ICalculator CreateCalculator(string calcName)
        {
            
            switch (calcName)
            {
                case "Subtruction":
                    return new Subtraction();
                case "Addition":
                    return new Addition();
                case "Multiplication":
                    return new Multiplication();
                case "Division":
                    return new Division();
                case "min":
                    return new min();
                case "max":
                    return new max();
                case "power":
                    return new power();
                default:
                    throw new Exception("unknown operation");
            }
        }
 
    }
}
