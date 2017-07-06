using System;

namespace Calculator.One_Argument
{
    public class arccos : CalcForOneArgument
    {
        /// <summary>
        /// This method returns a value of arccos
        /// </summary>
        /// <param name="firstArgument"></param>
        /// <returns></returns>
        public double Calculate(double firstArgument)
        {
            return (Math.Acos(firstArgument));
        }
    }
}
