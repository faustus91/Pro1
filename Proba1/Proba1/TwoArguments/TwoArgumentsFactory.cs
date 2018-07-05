using Proba1.TwoArguments;
using System;

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
                case "addition_of_two_numbers": return new AdditionOfTwoNumbersCalculator();
                case "subtraction_of_two_numbers": return new SubtractionOfTwoNumbersCalculator();
                case "multiplication_of_two_numbers": return new MultiplicationOfTwoNumbersCalculator();
                case "division_of_two_numbers": return new DivisionOfTwoNumbersCalculator();
                case "Extent": return new ExtentCalculator();
                case "logorifm": return new LogorifmCalculator();
                case "DegreeRoot": return new DegreeRootCalculator();
                case "min": return new MinCalculator();
                case "max": return new MaxCalculator();
                case "pow": return new PowCalculator();
                default:
                    throw new Exception("error");
            }
        }
    }
}