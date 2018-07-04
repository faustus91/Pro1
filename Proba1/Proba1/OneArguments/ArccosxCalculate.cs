using System;

namespace Proba1.OneArguments
{
    public class ArccosxCalculate : IOneArgumentsCalculator
    {
        public double Calculate(double firstArgument)
        {
            return Math.Acos(firstArgument * Math.PI / 180);
        }
    }
}