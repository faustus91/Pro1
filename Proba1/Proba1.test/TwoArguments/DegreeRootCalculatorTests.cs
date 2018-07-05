using NUnit.Framework;

namespace Proba1.test.TwoArguments
{
    [TestFixture]
    public class DegreeRootCalculatorTests
    {
        [TestCase(1, 1, 1)]
        [TestCase(4, 2, 2)]
        [TestCase(0, 0, 0)]

        public void TestCalculate(double firstValue, double secondValue, double expected)
        {
            ITwoArgumentsCalculator calculator = TwoArgumentsFactory.CreateCalculator("DegreeRoot");
            double result = calculator.Calculate(firstValue, secondValue);
            Assert.AreEqual(expected, result);

        }
    }
}
