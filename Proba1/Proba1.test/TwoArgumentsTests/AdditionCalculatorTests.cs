using NUnit.Framework;


namespace Proba1.test.TwoArgumentsTests
{
    [TestFixture]
    public class AdditionCalculatorTests
    {
        [Test]
        public void TestCalculate()
        {
            ITwoArgumentsCalculator calculator = TwoArgumentsFactory.CreateCalculator("Add") ;
            double result = calculator.Calculate(2, 2);
            Assert.AreEqual(4, result );
        }
    }
}
