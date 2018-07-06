﻿using System;

namespace Proba1
{
    public class DivisionCalculator : ITwoArgumentsCalculator
    {
        /// <summary>
        /// Division count
        /// </summary>
        /// <param name="firstArgument"></param>
        /// <param name="secondArgument"></param>
        /// <returns>
        /// firstArgument
        /// secondArgument
        /// </returns>
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
