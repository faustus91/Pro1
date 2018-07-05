using NUnit.Framework;

namespace Proba1.test.OneArguments
{
    [TestFixture]
    public class TenInThDegreeCalculatorTests

    {
        [TestCase(0, 1.0)]
        [TestCase(3, 1000.0)]
        [TestCase(-1, 0.10000000000000001)]
        public void TestCalculate(double firstValue, double expected)
        {
            IOneArgumentsCalculator calculator = OneArgumentsFactory.CreateCalculator("ten_in_th_degree");
            double result = calculator.Calculate(firstValue);
            Assert.AreEqual(expected, result);
        }
    }
}