using System;

namespace Proba1.TwoArguments
{
    public class DegreeRootCalculator : ITwoArgumentsCalculator
    {
        public double Calculate(double firstArgument, double secondArgument)
        {
            return Math.Pow(firstArgument, 1/secondArgument);
        }
    }
}


