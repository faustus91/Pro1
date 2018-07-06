namespace Proba1.TwoArguments
{
    public class DivisionOfTwoNumbersCalculator : ITwoArgumentsCalculator
    {
        /// <summary>
        /// Division count
        /// </summary>
        /// <param name="firstArgument"></param>
        /// <param name="secondArgument"></param>
        /// <returns>
        /// firstArgument
        /// secondArgument
        /// </returns>
        public double Calculate(double firstArgument, double secondArgument)
        {
            return firstArgument / secondArgument;
        }
    }
}