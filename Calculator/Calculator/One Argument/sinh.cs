using System;

namespace Calculator.One_Argument
{
    public class sinh : CalcForOneArgument
    {
        /// <summary>
        /// This method returns a value of sinh
        /// </summary>
        /// <param name="firstArgument"></param>
        /// <returns></returns>
        public double Calculate(double firstArgument)
        {
            return (Math.Sinh(firstArgument));
        }
    }
}
