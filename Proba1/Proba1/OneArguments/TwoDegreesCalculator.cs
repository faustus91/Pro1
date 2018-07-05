using System;

namespace Proba1.OneArguments
{
    public class TwoDegreesCalculator : IOneArgumentsCalculator
    {
        public double Calculate(double firstArgument)
        {
            return Math.Pow(2, firstArgument);
        }
    }
}