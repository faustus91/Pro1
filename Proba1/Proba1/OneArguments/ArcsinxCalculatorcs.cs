﻿using System;

namespace Proba1.OneArguments
{
    public class ArcsinxCalculatorcs : IOneArgumentsCalculator
    {
        /// <summary>
        /// arcsin function
        /// </summary>
        /// <param name="firstArgument"> the number lying in the gap [-1;1]</param>
        /// <returns> rads </returns>

        public double Calculate(double firstArgument)
        {
            return Math.Asin(firstArgument * Math.PI / 180);
        }
    }
}