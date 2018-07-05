using NUnit.Framework;

namespace Proba1.test.TwoArguments
{

    [TestFixture]
    public class MinCalculatorTests
    {
        [TestCase(0, 0, 0)]
        [TestCase(3, 4, 3)]
        [TestCase(-1, -2, -2)]

        public void TestCalculate(double firstValue, double secondValue, double expected)
        {
            ITwoArgumentsCalculator calculator = TwoArgumentsFactory.CreateCalculator("min");
            double result = calculator.Calculate(firstValue, secondValue);
            Assert.AreEqual(expected, result);
        }
    }
}
