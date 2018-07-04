using System;

namespace Proba1
{
    public class DivisionCalculator : ITwoArgumentsCalculator
    {
        public double Calculate(double firstArgument, double secondArgument)
        {
           if (secondArgument == 0)
            {
                throw new Exception("Ошибка");

            }
            return firstArgument / secondArgument;
            

        }
    }
}
