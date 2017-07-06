using System;

namespace Calculator.One_Argument
{
    public class sin : CalcForOneArgument
    {
        /// <summary>
        /// This method returns a value of sin
        /// </summary>
        /// <param name="firstArgument"></param>
        /// <returns></returns>
        public double Calculate(double firstArgument)
        {
            return (Math.Sin(firstArgument));
        }
    }
}
