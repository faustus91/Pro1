using NUnit.Framework;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Proba1.test.OneArguments
{
 
        [TestFixture]
        public class SquareRootCalculatorTests

        {
            [Test]
            public void TestCalculate()
            {
            IOneArgumentsCalculator calculator = OneArgumentsFactory.CreateCalculator("squareroot");
                double result = calculator.Calculate(4);
                Assert.AreEqual(2, result);
            }
        }
    }