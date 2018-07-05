using NUnit.Framework;
using Proba1.OneArguments;
using System;

namespace Proba1.test.OneArguments
{
    public class FactoryTests
    {
        [TestCase("squareroot", typeof(SquareRootCalculator))]
        [TestCase("squaring", typeof(SquaringCalculator))]
        [TestCase("arcsin", typeof(ArcsinxCalculatorcs))]
        [TestCase("arccos", typeof(ArccosxCalculate))]
        [TestCase("cos", typeof(CosxCalculator))]
        [TestCase("exp", typeof(ExpCalculator))]
        [TestCase("ln", typeof(LnCalculator))]
        [TestCase("sin", typeof(SinxCalculator))]
        [TestCase("tan", typeof(TanxCalculator))]
        [TestCase("ten_in_th_degree", typeof(TenInThDegreeCalculator))]
        [TestCase("two_degrees", typeof(TwoDegreesCalculator))]
        [TestCase("unit_divided", typeof(UnitDividedCalculator))]
        public void CalculateTest(string name, Type type)
        {
            var calculator = OneArgumentsFactory.CreateCalculator(name);

            Assert.IsInstanceOf(type, calculator);
        }

    }
}
