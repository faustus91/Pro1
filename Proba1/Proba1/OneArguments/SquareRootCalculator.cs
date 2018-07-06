using System;

namespace Proba1.OneArguments
{
    public class SquareRootCalculator : IOneArgumentsCalculator
    {
        /// <summary>
        /// Extraction of the square root 
        /// </summary>
        /// <param name="firstArgument"> the number lying in the gap [0;++infinity)</param>
        /// <returns> number </returns>
         
        public double Calculate(double firstArgument)
        {
            if (firstArgument < 0)
            {
                throw new Exception("Ошибка");
            }

            return Math.Sqrt(firstArgument);
        }
    }
}