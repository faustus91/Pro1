using System;

namespace Proba1.OneArguments
{

    public class TenInThDegreeCalculator : IOneArgumentsCalculator
    {
        public double Calculate(double firstArgument)
        {
            return Math.Pow(10, firstArgument);
        }
    }
}
