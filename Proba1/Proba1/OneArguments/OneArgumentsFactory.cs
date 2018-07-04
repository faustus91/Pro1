using Proba1.OneArguments;
using System;

namespace Proba1
{
    static class OneArgumentsFactory
    {
        public static IOneArgumentsCalculator CreateCalculator(string calculator)
        {
            switch (calculator)
            {
                case "squaring": return new SquaringCalculator();
                case "squareroot": return new SquareRootCalculator();
                default:
                    throw new Exception("error");
            }
        }
    }
}



