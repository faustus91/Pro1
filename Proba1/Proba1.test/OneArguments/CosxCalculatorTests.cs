using NUnit.Framework;

namespace Proba1.test.OneArguments
{
    [TestFixture]
    public class CosxCalculatorTests

    {
        [TestCase(0, 1.0)]
        [TestCase(1, 0.99984769515639127)]
        [TestCase(-7, 0.99254615164132198)]
        public void TestCalculate(double firstValue, double expected)
        {
            IOneArgumentsCalculator calculator = OneArgumentsFactory.CreateCalculator("cos");
            double result = calculator.Calculate(firstValue);
            Assert.AreEqual(expected, result);
        }
    }
}