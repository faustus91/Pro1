using System;

namespace Proba1.TwoArguments
{
    public class ExtentCalculator : ITwoArgumentsCalculator
    {
        /// <summary>
        /// Degree count
        /// </summary>
        /// <param name="secondArgument"></param>
        /// <param name="firstArgument"></param>
        /// <returns>
        /// firstArgument
        /// secondArgument        
        /// /// </returns>
        public double Calculate(double firstArgument, double secondArgument)
        {
            return Math.Pow(firstArgument, secondArgument);
        }
    }
}
