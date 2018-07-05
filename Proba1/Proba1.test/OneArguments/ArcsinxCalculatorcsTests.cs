using NUnit.Framework;

namespace Proba1.test.OneArguments
{

    [TestFixture]
public class ArcsinxCalculatorcsTests

{
    [TestCase(0, 0)]
    [TestCase(1, 0.017454178737585171d)]
    [TestCase(-7, -0.12247903839280565d)]
    public void TestCalculate(double firstValue, double expected)
    {
        IOneArgumentsCalculator calculator = OneArgumentsFactory.CreateCalculator("arcsin");
        double result = calculator.Calculate(firstValue);
        Assert.AreEqual(expected, result);
    }
}
}