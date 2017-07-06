namespace Calculator.Two_Arguments
{
    public class Addition : ICalculator
    {
        /// <summary>
        /// This method returns a value of addition
        /// </summary>
        /// <param name="firstArgument"></param>
        /// <param name="secondArgument"></param>
        /// <returns></returns>
        public double Calculate (double firstArgument, double secondArgument)
        {
  
            return (firstArgument + secondArgument);
        }
    }
}
