using System;

namespace Proba1.OneArguments
{
    public class CosxCalculator : IOneArgumentsCalculator
    {
        public double Calculate(double firstArgument)
        {
            return Math.Cos(firstArgument * Math.PI / 180);
        }
    }
}