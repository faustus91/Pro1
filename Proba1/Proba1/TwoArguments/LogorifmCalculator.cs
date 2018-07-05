using System;

namespace Proba1.TwoArguments
{
    public class LogorifmCalculator : ITwoArgumentsCalculator
    {
        public double Calculate(double firstArgument, double secondArgument)
        {
            return  Math.Log(firstArgument, secondArgument);
        }
    }
}
