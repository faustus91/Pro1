using System;

namespace Proba1.OneArguments
{
    public class ExpCalculator : IOneArgumentsCalculator
    {
        public double Calculate(double firstArgument)
        {
            return Math.Exp(firstArgument);
        }
    }
}

