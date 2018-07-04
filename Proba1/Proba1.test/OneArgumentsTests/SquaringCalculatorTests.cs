using NUnit.Framework;

namespace Proba1.test.OneArgumentsTests

{

    [TestFixture]
        public class SquaringCalculatorTests

        {
        [TestCase(0,  0)]
        [TestCase(3,  9)]
        [TestCase(-7,  49)]
        public void TestCalculate(double firstValue, double expected)
        {
                IOneArgumentsCalculator calculator = OneArgumentsFactory.CreateCalculator("squaring");
            double result = calculator.Calculate(firstValue);
            Assert.AreEqual(expected, result);
        }
        }
}
