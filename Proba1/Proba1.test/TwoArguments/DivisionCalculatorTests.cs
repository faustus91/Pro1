using NUnit.Framework;
using System;

namespace Proba1.test.TwoArgumentsTests
{
    [TestFixture]
    public class DivisionCalculatorTests
    {
        [TestCase(1, 1, 1)]
        [TestCase(6, 2, 3)]
        [TestCase(-9, -3, 3)]

        public void TestCalculate(double firstValue, double secondValue, double expected)
        {
            ITwoArgumentsCalculator calculator = TwoArgumentsFactory.CreateCalculator("Div");
            double result = calculator.Calculate(firstValue, secondValue);
            Assert.AreEqual(expected, result);
           
        }
    }
}

