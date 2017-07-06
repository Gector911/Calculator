using System;

namespace Calculator.Two_Arguments
{
  
    public class power : ICalculator
    {
        /// <summary>
        /// This method returns a value of power
        /// </summary>
        /// <param name="firstArgument"></param>
        /// <param name="secondArgument"></param>
        /// <returns></returns>
        public double Calculate(double firstArgument, double secondArgument)
        {
            return (Math.Pow(firstArgument, secondArgument));
        }
    }
}
