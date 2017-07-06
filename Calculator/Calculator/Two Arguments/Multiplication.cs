namespace Calculator.Two_Arguments
{

    public class Multiplication : ICalculator
    {
        /// <summary>
        /// This method returns a value of multiplication
        /// </summary>
        /// <param name="firstArgument"></param>
        /// <param name="secondArgument"></param>
        /// <returns></returns>
        public double Calculate(double firstArgument, double secondArgument)
        {
            return (firstArgument * secondArgument);
        }
    }
}
