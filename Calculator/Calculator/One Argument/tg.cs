using System;

namespace Calculator.One_Argument
{

    public class tg : CalcForOneArgument
    {
        /// <summary>
        /// This method returns a value of tg
        /// </summary>
        /// <param name="firstArgument"></param>
        /// <returns></returns>
        public double Calculate(double firstArgument)
        {
            return (Math.Tan(firstArgument));
        }
    }
}
