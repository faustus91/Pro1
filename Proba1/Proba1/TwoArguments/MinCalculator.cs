namespace Proba1.TwoArguments
{
    public class MinCalculator : ITwoArgumentsCalculator
    {
        /// <summary>
        /// minimum of two arguments
        /// </summary>
        /// <param name="firstArgument"></param>
        /// <param name="secondArgument"></param>
        /// <returns>
        /// firstArgument
        /// secondArgument
        /// </returns>
        public double Calculate(double firstArgument, double secondArgument)
        {
            if (firstArgument > secondArgument) return secondArgument;
            return firstArgument;
        }
    }
}