using System;

namespace Proba1.TwoArguments
{

    public class PowCalculator : ITwoArgumentsCalculator
    {
        public double Calculate(double firstArgument, double secondArgument)
        {
            return Math.Pow(secondArgument, firstArgument);
        }
    }
}