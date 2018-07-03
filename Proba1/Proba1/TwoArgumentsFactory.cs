using System;
using System.Collections.Generic;
using System.Linq;

namespace Proba1
{
    static class TwoArgumentsFactory
    {
        public static ITwoArgumentsCalculator CreateCalculator(string calculator)
        {
            switch (calculator)
            {
                case "Add": return new AdditionCalculator();
                case "minus": return new SubtractionCalculator();
                default:
                    throw new Exception("error");
            }
        }
    }
}
