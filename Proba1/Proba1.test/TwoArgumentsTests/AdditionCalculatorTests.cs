using NUnit.Framework;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;


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
