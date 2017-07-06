using System;

namespace Calculator.One_Argument
{
    public class tgh : CalcForOneArgument
    {
        /// <summary>
        /// This method returns a value of tgh
        /// </summary>
        /// <param name="firstArgument"></param>
        /// <returns></returns>
        public double Calculate(double firstArgument)
        {
            return (Math.Tanh(firstArgument));
        }
    }
}
