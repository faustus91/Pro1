using Proba1.OneArguments;
using System;

namespace Proba1
{
    public class OneArgumentsFactory
    {
        public static IOneArgumentsCalculator CreateCalculator(string calculator)
        {
            switch (calculator)
            {
                case "squaring": return new SquaringCalculator();
                case "squareroot": return new SquareRootCalculator();
                case "sin": return new SinxCalculator();
                case "cos": return new CosxCalculator();
                case "tan": return new TanxCalculator();
                case "arcsin": return new ArcsinxCalculatorcs();
                case "arccos": return new ArccosxCalculate();
                default:
                    throw new Exception("error");
            }
        }
    }
}



