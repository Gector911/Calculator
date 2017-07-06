using System;

namespace Calculator.Two_Arguments
{

    public class min : ICalculator
    {
        /// <summary>
        /// This method returns a value of MIN value
        /// </summary>
        /// <param name="firstArgument"></param>
        /// <param name="secondArgument"></param>
        /// <returns></returns>
        public double Calculate(double firstArgument, double secondArgument)
        {
            return (Math.Min(firstArgument, secondArgument));
        }
    }
}
