namespace Proba1.TwoArguments
{
    public class MinCalculator : ITwoArgumentsCalculator
    {
        public double Calculate(double firstArgument, double secondArgument)
        {
            if (firstArgument > secondArgument) return secondArgument;
            return firstArgument;
        }
    }
}