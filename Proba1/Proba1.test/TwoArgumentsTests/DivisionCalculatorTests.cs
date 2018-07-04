﻿using NUnit.Framework;

namespace Proba1.test.TwoArgumentsTests
{
    [TestFixture]
    public class DivisionCalculatorTests
    {
        [Test]
        public void TestCalculate()
        {
            ITwoArgumentsCalculator calculator = TwoArgumentsFactory.CreateCalculator("Div");
            double result = calculator.Calculate(2, 2);
            Assert.AreEqual(1, result);
        }
    }
}
