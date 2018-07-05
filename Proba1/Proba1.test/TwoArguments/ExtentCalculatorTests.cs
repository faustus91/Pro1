using NUnit.Framework;

namespace Proba1.test.TwoArguments
{
    [TestFixture]
    public class ExtentCalculatorTests
    {
        [TestCase(0, 0, 1)]
        [TestCase(4, 2, 16)]
        [TestCase(-1, -2, 1)]

        public void TestCalculate(double firstValue, double secondValue, double expected)
        {
            ITwoArgumentsCalculator calculator = TwoArgumentsFactory.CreateCalculator("Extent");
            double result = calculator.Calculate(firstValue, secondValue);
            Assert.AreEqual(expected, result);

        }
    }
}
