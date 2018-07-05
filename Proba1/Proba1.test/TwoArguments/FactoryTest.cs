using NUnit.Framework;
using Proba1.TwoArguments;
using System;

namespace Proba1.test.TwoArguments
{
    public class FactoryTest
    {
        [TestCase("Add", typeof(AdditionCalculator))]
        [TestCase("minus", typeof(SubtractionCalculator))]
        [TestCase("Div", typeof(DivisionCalculator))]
        [TestCase("multi", typeof(MultiplyCalculator))]
        [TestCase("pow", typeof(PowCalculator))]
        [TestCase("subtraction_of_two_numbers", typeof(SubtractionOfTwoNumbersCalculator))]
        [TestCase("min", typeof(MinCalculator))]
        [TestCase("addition_of_two_numbers", typeof(AdditionOfTwoNumbersCalculator))]
        [TestCase("DegreeRoot", typeof(DegreeRootCalculator))]
        [TestCase("Extent", typeof(ExtentCalculator))]
        [TestCase("logorifm", typeof(LogorifmCalculator))]
        [TestCase("multiplication_of_two_numbers", typeof(MultiplicationOfTwoNumbersCalculator))]
        public void CalculateTest(string name, Type type)
        {
            var calculator = TwoArgumentsFactory.CreateCalculator(name);

            Assert.IsInstanceOf(type, calculator);
        }

    }
}
