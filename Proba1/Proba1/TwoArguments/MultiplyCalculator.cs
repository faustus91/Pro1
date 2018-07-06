namespace Proba1
{
    public class MultiplyCalculator : ITwoArgumentsCalculator
    {
        /// <summary>
        /// Multi count
        /// </summary>
        /// <param name="firstArgument"></param>
        /// <param name="secondArgument"></param>
        /// <returns>
        /// firstArgument
        /// secondArgument
        /// </returns>
        public double Calculate(double firstArgument, double secondArgument)
        {
            return firstArgument * secondArgument;
        }
    }
}
