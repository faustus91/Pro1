using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Proba1
{
    static class OneArgumentsFactory
    {
        public static IOneArgumentsCalculator CreateCalculator(string calculator)
        {
            switch (calculator)
            {
                case "squaring": return new SquaringCalculator();
               
                default:
                    throw new Exception("error");
            }
        }
    }
}



