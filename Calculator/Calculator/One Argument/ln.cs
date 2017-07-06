using System;

namespace Calculator.One_Argument
{

    public class ln : CalcForOneArgument
    {
        /// <summary>
        /// This method returns a value of ln
        /// </summary>
        /// <param name="firstArgument"></param>
        /// <returns></returns>
        public double Calculate(double firstArgument)
        {
            if (firstArgument <= 0)
            {
                throw new Exception("logarithm expression <=0");
            }
            return (Math.Log(firstArgument));
        }
    }
}
