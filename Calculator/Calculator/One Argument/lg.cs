using System;

namespace Calculator.One_Argument
{
    public class lg : CalcForOneArgument
    {
        /// <summary>
        /// This method returns a value of lg
        /// </summary>
        /// <param name="firstArgument"></param>
        /// <returns></returns>
        public double Calculate(double firstArgument)
        {
            if (firstArgument <= 0)
            {
                throw new Exception("logarithm expression <=0");
            }
            return (Math.Log10(firstArgument));

        }
    }
}
