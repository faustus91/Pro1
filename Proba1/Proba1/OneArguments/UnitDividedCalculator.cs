namespace Proba1.OneArguments
{
    public class UnitDividedCalculator : IOneArgumentsCalculator
    {
        /// <summary>
        /// unit divided by the argument
        /// </summary>
        /// <param name="firstArgument">the number  </param>
        /// <returns>  number  </returns>
        public double Calculate(double firstArgument)
        {
            return (1 / firstArgument);
        }
    }
}