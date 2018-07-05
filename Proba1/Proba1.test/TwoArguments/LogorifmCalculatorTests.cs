using NUnit.Framework;

namespace Proba1.test.TwoArguments
{
    [TestFixture]
    public class LogorifmCalculatorTests
    {
        [TestCase(4, 2, 2)]
        [TestCase(8, 2, 3)]
        [TestCase(1, 2, 0)]

        public void TestCalculate(double firstValue, double secondValue, double expected)
        {
            ITwoArgumentsCalculator calculator = TwoArgumentsFactory.CreateCalculator("logorifm");
            double result = calculator.Calculate(firstValue, secondValue);
            Assert.AreEqual(expected, result);
        }
    }
}

