using System;

namespace Calculator.One_Argument
{
    public class sqrt : CalcForOneArgument
    {
        /// <summary>
        /// This method returns a value of sqrt
        /// </summary>
        /// <param name="firstArgument"></param>
        /// <returns></returns>
        public double Calculate(double firstArgument)
        {
            if (firstArgument < 0)
            {
                throw new Exception("sqrt expression < 0");
            }
            return (Math.Sqrt(firstArgument));
        }
    }
}
