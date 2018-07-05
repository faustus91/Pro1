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
                case "ln": return new LnCalculator();
                case "arcsin": return new ArcsinxCalculatorcs();
                case "arccos": return new ArccosxCalculate();
                case "exp": return new ExpCalculator();
                case "ten_in_th_degree": return new TenInThDegreeCalculator();
                case "two_degrees": return new TwoDegreesCalculator();
                case "unit_divided": return new UnitDividedCalculator();
                default:
                    throw new Exception("error");
            }
        }
    }
}



