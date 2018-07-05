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