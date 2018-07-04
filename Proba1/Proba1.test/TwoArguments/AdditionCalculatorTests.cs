using NUnit.Framework;


namespace Proba1.test.TwoArgumentsTests
{
    [TestFixture]
    public class AdditionCalculatorTests
    {
        [TestCase(0, 0, 0)]
        [TestCase(3, 4, 7)]
        [TestCase(-7, -2, -9)]

        public void TestCalculate( double firstValue, double secondValue, double expected)
        {
            ITwoArgumentsCalculator calculator = TwoArgumentsFactory.CreateCalculator("Add");
            double result = calculator.Calculate(firstValue, secondValue);
            Assert.AreEqual(expected, result );
        }
    }
}
