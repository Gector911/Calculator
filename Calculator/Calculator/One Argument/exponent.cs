using System;

namespace Calculator.One_Argument
{
    public class exponent : CalcForOneArgument
    {
        /// <summary>
        /// This method returns a value of exponent
        /// </summary>
        /// <param name="firstArgument"></param>
        /// <returns></returns>
        public double Calculate(double firstArgument)
        {
            return (Math.Exp(firstArgument));
        }
    }
}
