using System;

namespace Calculator.One_Argument
{
    public class cos : CalcForOneArgument
    {
        /// <summary>
        /// This method returns a value of cos
        /// </summary>
        /// <param name="firstArgument"></param>
        /// <returns></returns>
        public double Calculate(double firstArgument)
        {
            return (Math.Cos(firstArgument));
        }
    }
}
