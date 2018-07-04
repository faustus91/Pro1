using NUnit.Framework;
using Proba1.OneArguments;
using Proba1.test.OneArgumentsTests;
using System;

namespace Proba1.test.OneArguments
{
    public class FactoryTests
    {
        [TestCase("squareroot", typeof(SquareRootCalculator))]
        [TestCase("squaring", typeof(SquaringCalculator))]
        public void CalculateTest(string name, Type type)
        {
            var calculator = OneArgumentsFactory.CreateCalculator(name);

            Assert.IsInstanceOf(type, calculator);
        }

    }
}
