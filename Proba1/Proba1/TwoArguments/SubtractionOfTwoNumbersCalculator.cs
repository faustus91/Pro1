namespace Proba1.TwoArguments
{


    
public class SubtractionOfTwoNumbersCalculator : ITwoArgumentsCalculator
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