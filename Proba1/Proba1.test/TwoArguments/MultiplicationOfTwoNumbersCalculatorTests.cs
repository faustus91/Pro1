using NUnit.Framework;

namespace Proba1.test.TwoArguments
{
    [TestFixture]
    public class MultiplicationOfTwoNumbersCalculatorTests
    {

        [TestCase(0, 0, 0)]
        [TestCase(3, 4, 12)]
        [TestCase(-7, -2, 14)]

        public void TestCalculate(double firstValue, double secondValue, double expected)
        {
            ITwoArgumentsCalculator calculator = TwoArgumentsFactory.CreateCalculator("multiplication_of_two_numbers");
            double result = calculator.Calculate(firstValue, secondValue);
            Assert.AreEqual(expected, result);
        }
    }
}

