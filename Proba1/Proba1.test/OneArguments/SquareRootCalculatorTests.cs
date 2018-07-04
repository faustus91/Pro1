using NUnit.Framework;

namespace Proba1.test.OneArguments
{

    [TestFixture]
    public class SquareRootCalculatorTests

    {
        [TestCase(0, 0)]
        [TestCase(9, 3)]
        [TestCase(49, 7)]
        public void TestCalculate(double firstValue, double expected)
        {
            IOneArgumentsCalculator calculator = OneArgumentsFactory.CreateCalculator("squareroot");
            double result = calculator.Calculate(firstValue);
            Assert.AreEqual(expected, result);
        }
    }
}

