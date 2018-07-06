using System;

namespace Proba1.OneArguments
{
    public class TwoDegreesCalculator : IOneArgumentsCalculator
    {
        /// <summary>
        /// the raising of the number 2 to the power of an equal argument
        /// </summary>
        /// <param name="firstArgument">the number </param>
        /// <returns>  number  </returns>

        public double Calculate(double firstArgument)
        {
            return Math.Pow(2, firstArgument);
        }
    }
}