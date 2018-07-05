using NUnit.Framework;

namespace Proba1.test.OneArguments
{
    [TestFixture]
    public class UnitDividedCalculatorTests

    {
        [TestCase(1, 1.0)]
        [TestCase(3, 0.33333333333333331)]
        [TestCase(-1, -1.0)]
        public void TestCalculate(double firstValue, double expected)
        {
            IOneArgumentsCalculator calculator = OneArgumentsFactory.CreateCalculator("unit_divided");
            double result = calculator.Calculate(firstValue);
            Assert.AreEqual(expected, result);
        }
    }
}