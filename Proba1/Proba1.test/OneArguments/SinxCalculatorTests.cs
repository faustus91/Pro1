using NUnit.Framework;

namespace Proba1.test.OneArguments
{
    [TestFixture]
    public class SinxCalculatorTests

    {
        [TestCase(2, 0.034899496702500969)]
        [TestCase(1, 0.017452406437283512)]
        [TestCase(7, 0.12186934340514748)]
        public void TestCalculate(double firstValue, double expected)
        {
            IOneArgumentsCalculator calculator = OneArgumentsFactory.CreateCalculator("sin");
            double result = calculator.Calculate(firstValue);
            Assert.AreEqual(expected, result);
        }
    }
}