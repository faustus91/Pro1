using NUnit.Framework;

namespace Proba1.test.TwoArgumentsTests
{
    [TestFixture]
    public class MultiplyCalculatorTests
    {
        [Test]
        public void TestCalculate()
        {
            ITwoArgumentsCalculator calculator = TwoArgumentsFactory.CreateCalculator("multi");
            double result = calculator.Calculate(2, 2);
            Assert.AreEqual(4, result);
        }
    }
}
