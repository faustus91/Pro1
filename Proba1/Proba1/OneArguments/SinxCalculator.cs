using System;

namespace Proba1.OneArguments
{
    public class SinxCalculator : IOneArgumentsCalculator
    {
        /// <summary>
        /// sinus function
        /// </summary>
        /// <param name="firstArgument"> the number lying in the gap [-1;1]</param>
        /// <returns> rads </returns>
        
        public double Calculate(double firstArgument)
        {
            return Math.Sin(firstArgument * Math.PI / 180);
        }
    }
}
