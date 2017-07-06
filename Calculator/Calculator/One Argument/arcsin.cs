using System;

namespace Calculator.One_Argument
{
    public class arcsin : CalcForOneArgument
    {
        /// <summary>
        /// This method returns a value of arcsin
        /// </summary>
        /// <param name="firstArgument"></param>
        /// <returns></returns>
        public double Calculate(double firstArgument)
        {
            return (Math.Asin(firstArgument));
        }
    }
}
