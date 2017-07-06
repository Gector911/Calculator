using System;

namespace Calculator.Two_Arguments
{
    public class Division : ICalculator
    {
        /// <summary>
        /// This method returns a value of division
        /// </summary>
        /// <param name="firstArgument"></param>
        /// <param name="secondArgument"></param>
        /// <returns></returns>
        public double Calculate(double firstArgument, double secondArgument)
        {
            if (secondArgument == 0)
            {
                throw new ArgumentNullException("Division by zero");
            }
            return (firstArgument / secondArgument);
        }
    }
}
