namespace Proba1
{
    public class SubtractionCalculator : ITwoArgumentsCalculator
    {
        /// <summary>
        /// Minus count
        /// </summary>
        /// <param name="firstArgument"></param>
        /// <param name="secondArgument"></param>
        /// <returns>
        /// firstArgument
        /// secondArgument
        /// </returns>
        public double Calculate(double firstArgument, double secondArgument)
        {
            return firstArgument - secondArgument;
        }
    }
}
