using NUnit.Framework;

namespace Proba1.test.TwoArguments
{
    [TestFixture]
    public class MaxCalculatorTests
    {
        [TestCase(0, 0, 0)]
        [TestCase(3, 4, 4)]
        [TestCase(-1, -2, -1)]

        public void TestCalculate(double firstValue, double secondValue, double expected)
        {
            ITwoArgumentsCalculator calculator = TwoArgumentsFactory.CreateCalculator("max");
            double result = calculator.Calculate(firstValue, secondValue);
            Assert.AreEqual(expected, result);
        }
    }
}