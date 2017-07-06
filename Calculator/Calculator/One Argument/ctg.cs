using System;

namespace Calculator.One_Argument
{
    
    public class ctg : CalcForOneArgument
    {
        /// <summary>
        /// This method returns a value of ctg
        /// </summary>
        /// <param name="firstArgument"></param>
        /// <returns></returns>
        public double Calculate(double firstArgument)
        {
            return (1/Math.Tan(firstArgument));
        }
    }
}
