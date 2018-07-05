using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Proba1.TwoArguments
{

   
public class MultiplicationOfTwoNumbersCalculator : ITwoArgumentsCalculator
{
    public double Calculate(double firstArgument, double secondArgument)
    {
        return firstArgument * secondArgument;
    }
}
}
