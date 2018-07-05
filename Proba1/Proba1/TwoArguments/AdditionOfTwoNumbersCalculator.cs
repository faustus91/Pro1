namespace Proba1.TwoArguments
{

    public class AdditionOfTwoNumbersCalculator : ITwoArgumentsCalculator
    {
        public double Calculate(double firstArgument, double secondArgument)
        {
            return firstArgument + secondArgument;
        }
    }
}
