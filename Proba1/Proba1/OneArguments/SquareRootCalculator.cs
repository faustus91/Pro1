using System;

namespace Proba1.OneArguments
{
    public class SquareRootCalculator : IOneArgumentsCalculator
    {
        public double Calculate(double firstArgument)
        {
            if (firstArgument <0)
            {
                throw new Exception("Ошибка");
            }

            return Math.Sqrt(firstArgument);
        }
    }
}