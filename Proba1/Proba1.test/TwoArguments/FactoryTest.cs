using NUnit.Framework;
using Proba1.test.TwoArgumentsTests;
using System;

namespace Proba1.test.TwoArguments
{
    public class FactoryTest
    {
        [TestCase("Add", typeof(AdditionCalculator))]
        [TestCase("minus", typeof(SubtractionCalculator))]
        [TestCase("Div", typeof(DivisionCalculator))]
        [TestCase("multi", typeof(MultiplyCalculator))]
        public void CalculateTest(string name, Type type)
        {
            var calculator = TwoArgumentsFactory.CreateCalculator(name);

            Assert.IsInstanceOf(type, calculator);
        }

    }
}
