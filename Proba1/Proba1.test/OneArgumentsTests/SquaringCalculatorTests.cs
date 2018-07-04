using NUnit.Framework;

namespace Proba1.test.OneArgumentsTests

{

    [TestFixture]
        public class SquaringCalculatorTests

        {
            [Test]
            public void TestCalculate()
            {
                IOneArgumentsCalculator calculator = OneArgumentsFactory.CreateCalculator("squaring");
                double result = calculator.Calculate(4);
                Assert.AreEqual(16, result);
            }
        }
    }