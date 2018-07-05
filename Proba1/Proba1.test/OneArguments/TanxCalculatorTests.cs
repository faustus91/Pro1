using NUnit.Framework;

namespace Proba1.test.OneArguments
{
    [TestFixture]
    public class TanxCalculatorTests

    {
        [TestCase(0, 0)]
        [TestCase(3, 0.052407779283041196)]
        [TestCase(-7, -0.1227845609029046)]
        public void TestCalculate(double firstValue, double expected)
        {
            IOneArgumentsCalculator calculator = OneArgumentsFactory.CreateCalculator("tan");
            double result = calculator.Calculate(firstValue);
            Assert.AreEqual(expected, result);
        }
    }
}
