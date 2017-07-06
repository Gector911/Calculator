using System;

namespace Calculator.One_Argument
{
    public class cosh : CalcForOneArgument
    {
        /// <summary>
        /// This method returns a value of cosh
        /// </summary>
        /// <param name="firstArgument"></param>
        /// <returns></returns>
        public double Calculate(double firstArgument)
        {
            return (Math.Cosh(firstArgument));
        }
    }
}
