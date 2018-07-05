using System;

namespace Proba1.OneArguments
{
    public class LnCalculator : IOneArgumentsCalculator
    {
        public double Calculate(double firstArgument)
        {
            return Math.Log(firstArgument);
        }
    }
}

