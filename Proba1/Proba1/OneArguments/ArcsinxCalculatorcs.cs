using System;

namespace Proba1.OneArguments
{
    public class ArcsinxCalculatorcs : IOneArgumentsCalculator
    {
        
        public double Calculate(double firstArgument)
        {
            return Math.Asin(firstArgument * Math.PI / 180);
        }
    } 
}