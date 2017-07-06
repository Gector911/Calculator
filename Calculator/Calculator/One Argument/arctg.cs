using System;

namespace Calculator.One_Argument
{
    public class arctg : CalcForOneArgument
    {
        /// <summary>
        /// This method returns a value of arctg
        /// </summary>
        /// <param name="firstArgument"></param>
        /// <returns></returns>
        public double Calculate(double firstArgument)
        {
            return (Math.Atan(firstArgument));
        }
    }
}
