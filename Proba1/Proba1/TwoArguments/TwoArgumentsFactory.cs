using System;
using System.Collections.Generic;
using System.Linq;

namespace Proba1
{
    public class TwoArgumentsFactory
    {
        public static ITwoArgumentsCalculator CreateCalculator(string calculator)
        {
            switch (calculator)
            {
                case "Add": return new AdditionCalculator();
                case "minus": return new SubtractionCalculator();
                case "multi": return new MultiplyCalculator();
                case "Div": return new DivisionCalculator();
                default:
                    throw new Exception("error");
            }
        }
    }
}