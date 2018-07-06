using System;

namespace Proba1.OneArguments
{
    public class CosxCalculator : IOneArgumentsCalculator
    {
        /// <summary>
        /// cos function
        /// </summary>
        /// <param name="firstArgument"> the number lying in the gap [-1;1]</param>
        /// <returns> rads </returns>

        public double Calculate(double firstArgument)
        {
            return Math.Cos(firstArgument * Math.PI / 180);
        }
    }
}