namespace Calculator.Two_Arguments
{
 
    public class Subtraction:ICalculator
    {
        /// <summary>
        /// This method returns a value of subtraction
        /// </summary>
        /// <param name="firstArgument"></param>
        /// <param name="secondArgument"></param>
        /// <returns></returns>
        public double Calculate(double firstArgument, double secondArgument)
        {
            return (firstArgument - secondArgument);
        }
    }
}
