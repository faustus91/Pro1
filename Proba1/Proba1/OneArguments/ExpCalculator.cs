using System;

namespace Proba1.OneArguments
{
    public class ExpCalculator : IOneArgumentsCalculator
    {
        /// <summary>
        /// exp function
        /// </summary>
        /// <param name="firstArgument"> the number lying in the gap [-1;1]</param>
        /// <returns> number </returns>
        
        public double Calculate(double firstArgument)
        {
            return Math.Exp(firstArgument);
        }
    }
}

