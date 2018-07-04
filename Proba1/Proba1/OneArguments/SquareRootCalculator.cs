using System;

namespace Proba1.OneArguments
{
    public class SquareRootCalculator : IOneArgumentsCalculator
    {
        public double Calculate(double firstArgument)
        {
            return Math.Sqrt(firstArgument);
        }
    }
}