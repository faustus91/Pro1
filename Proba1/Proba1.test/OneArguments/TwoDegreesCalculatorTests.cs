using NUnit.Framework;

namespace Proba1.test.OneArguments
{
    [TestFixture]
    public class TwoDegreesCalculatorTests

    {
        [TestCase(0, 1.0)]
        [TestCase(3, 8.0)]
        [TestCase(-1, 0.5)]
        public void TestCalculate(double firstValue, double expected)
        {
            IOneArgumentsCalculator calculator = OneArgumentsFactory.CreateCalculator("two_degrees");
            double result = calculator.Calculate(firstValue);
            Assert.AreEqual(expected, result);
        }
    }
}