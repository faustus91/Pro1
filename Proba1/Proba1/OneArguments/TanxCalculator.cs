using System;

namespace Proba1.OneArguments
{
    public class TanxCalculator : IOneArgumentsCalculator
    {
        public double Calculate(double firstArgument)
        {
            return Math.Sin(firstArgument * Math.PI / 180);
        }
    }
}