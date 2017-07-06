using System;

namespace Calculator.One_Argument
{
    public class decad : CalcForOneArgument
    {
        /// <summary>
        /// This method returns a value of decad
        /// </summary>
        /// <param name="firstArgument"></param>
        /// <returns></returns>
        public double Calculate(double firstArgument)
        {
            return (Math.Pow(10, firstArgument));
        }
    }
}
