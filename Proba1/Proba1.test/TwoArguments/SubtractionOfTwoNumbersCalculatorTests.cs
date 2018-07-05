using NUnit.Framework;

namespace Proba1.test.TwoArguments
{
    [TestFixture]
    public class SubtractionOfTwoNumbersCalculatorTests
    {
        [TestCase(0, 0, 0)]
        [TestCase(3, 4, -1)]
        [TestCase(-1, -2, 1)]

        public void TestCalculate(double firstValue, double secondValue, double expected)
        {
            ITwoArgumentsCalculator calculator = TwoArgumentsFactory.CreateCalculator("subtraction_of_two_numbers");
            double result = calculator.Calculate(firstValue, secondValue);
            Assert.AreEqual(expected, result);
        }
    }
}
