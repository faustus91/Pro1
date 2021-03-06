﻿using NUnit.Framework;

namespace Proba1.test.OneArguments
{

    [TestFixture]
    public class ArccosxCalculateTests

    {
        [TestCase(0, 1.5707963267948966d)]
        [TestCase(1, 1.5533421480573115)]
        [TestCase(-7, 1.6932753651877022)]
        public void TestCalculate(double firstValue, double expected)
        {
            IOneArgumentsCalculator calculator = OneArgumentsFactory.CreateCalculator("arccos");
            double result = calculator.Calculate(firstValue);
            Assert.AreEqual(expected, result);
        }
    }
}