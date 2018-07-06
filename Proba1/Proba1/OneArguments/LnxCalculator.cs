using System;

namespace Proba1.OneArguments
{
    public class LnCalculator : IOneArgumentsCalculator
    {
        /// <summary>
        /// natural logarithm 
        /// </summary>
        /// <param name="firstArgument"> the number lying in the gap[0;+infinity) </param> 
        /// <returns> number </returns>

        public double Calculate(double firstArgument)
        {
            return Math.Log(firstArgument);
        }
    }
}

