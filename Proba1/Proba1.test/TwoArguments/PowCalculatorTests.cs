using NUnit.Framework;

namespace Proba1.test.TwoArguments
{
    [TestFixture]
    public class PowCalculatorTests
    {
        [TestCase(0, 0, 1)]
        [TestCase(3, 4, 64)]
        [TestCase(-1, -2, -0.5)]

        public void TestCalculate(double firstValue, double secondValue, double expected)
        {
            ITwoArgumentsCalculator calculator = TwoArgumentsFactory.CreateCalculator("pow");
            double result = calculator.Calculate(firstValue, secondValue);
            Assert.AreEqual(expected, result);
        }
    }
}

