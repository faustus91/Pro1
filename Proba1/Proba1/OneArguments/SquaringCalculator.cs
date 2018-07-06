using System;

namespace Proba1
{
    public class SquaringCalculator : IOneArgumentsCalculator
    {
        /// <summary>
        /// multiplying the number by itself again
        /// </summary>
        /// <param name="firstArgument"> the number lying in the gap [-1;+infinity)</param>
        /// <returns> number </returns>
         
        public double Calculate(double firstArgument)
        {
            return Math.Pow(firstArgument, 2);
        }
    }
}