using System;

namespace Proba1.TwoArguments
{
    public class LogorifmCalculator : ITwoArgumentsCalculator
    {
        /// <summary>
        /// Log count
        /// </summary>
        /// <param name="firstArgument"></param>
        /// <param name="secondArgument"></param>
        /// <returns>
        /// firstArgument
        /// secondArgument
        /// </returns>
        public double Calculate(double firstArgument, double secondArgument)
        {
            return Math.Log(firstArgument, secondArgument);
        }
    }
}
