using System;

namespace Proba1.TwoArguments
{
    public class DegreeRootCalculator : ITwoArgumentsCalculator
    {
        /// <summary>
        /// DegreeFraction count
        /// </summary>
        /// <param name="firstArgument"></param>
        /// <param name="secondArgument"></param>
        /// <returns>
        /// firstArgument
        /// secondArgument
        /// </returns>
        public double Calculate(double firstArgument, double secondArgument)
        {
            return Math.Pow(firstArgument, 1 / secondArgument);
        }
    }
}


