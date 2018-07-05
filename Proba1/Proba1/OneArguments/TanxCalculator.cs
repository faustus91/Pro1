﻿using System;

namespace Proba1.OneArguments
{
    public class TanxCalculator : IOneArgumentsCalculator
    {
        public double Calculate(double firstArgument)
        {
            return Math.Tan(firstArgument * Math.PI / 180);
        }
    }
}