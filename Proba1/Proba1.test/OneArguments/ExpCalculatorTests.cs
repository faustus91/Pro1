using NUnit.Framework;

namespace Proba1.test.OneArguments
{
    [TestFixture]
    public class ExpCalculatorTests

    {
        [TestCase(0, 1.0)]
        [TestCase(1, 2.7182818284590451)]
        [TestCase(-7, 0.0009118819655545162)]
        public void TestCalculate(double firstValue, double expected)
        {
            IOneArgumentsCalculator calculator = OneArgumentsFactory.CreateCalculator("exp");
            double result = calculator.Calculate(firstValue);
            Assert.AreEqual(expected, result);
        }
    }
}