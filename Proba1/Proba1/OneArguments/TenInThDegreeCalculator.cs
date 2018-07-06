using System;

namespace Proba1.OneArguments
{

    public class TenInThDegreeCalculator : IOneArgumentsCalculator
    {
        /// <summary>
        ///Degree count
        /// </summary>
        /// <param name="firstArgument"></param>
        /// <returns>
        /// firstArgument
        /// </returns>

        public double Calculate(double firstArgument)
        {
            return Math.Pow(10, firstArgument);
        }
    }
}
