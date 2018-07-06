namespace Proba1.TwoArguments

{
    public class MaxCalculator : ITwoArgumentsCalculator
    {
        /// <summary>
        /// maximum of two arguments
        /// </summary>
        /// <param name="firstArgument"></param>
        /// <param name="secondArgument"></param>
        /// <returns>
        /// firstArgument
        /// secondArgument
        /// </returns>
        public double Calculate(double firstArgument, double secondArgument)
        {
            if (firstArgument > secondArgument) return firstArgument;
            return secondArgument;
        }
    }

}