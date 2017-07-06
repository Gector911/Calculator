using System;

namespace Calculator.Two_Arguments
{
    public class max : ICalculator
    {
        /// <summary>
        /// This method returns a value of MAX value
        /// </summary>
        /// <param name="firstArgument"></param>
        /// <param name="secondArgument"></param>
        /// <returns></returns>
        public double Calculate(double firstArgument, double secondArgument)
        {
            return (Math.Max(firstArgument, secondArgument));
        }
    }
}
