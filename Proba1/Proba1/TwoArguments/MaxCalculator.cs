using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Proba1.TwoArguments

    {
        public class MaxCalculator : ITwoArgumentsCalculator
        {
            public double Calculate(double firstArgument, double secondArgument)
            {
            if (firstArgument > secondArgument) return firstArgument;
                return secondArgument;
        }
        }
    }