using NUnit.Framework;

namespace Proba1.test.OneArguments
{
    [TestFixture]
    public class LnxCalculatorTests

    {
        [TestCase(2, 0.69314718055994529)]
        [TestCase(1, 0.0)]
        [TestCase(7, 1.9459101490553132)]
        public void TestCalculate(double firstValue, double expected)
        {
            IOneArgumentsCalculator calculator = OneArgumentsFactory.CreateCalculator("ln");
            double result = calculator.Calculate(firstValue);
            Assert.AreEqual(expected, result);
        }
    }
}