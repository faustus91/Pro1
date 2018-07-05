namespace Proba1.TwoArguments
{
    public class DivisionOfTwoNumbersCalculator : ITwoArgumentsCalculator
    {
        public double Calculate(double firstArgument, double secondArgument)
        {
            return firstArgument / secondArgument;
        }
    }
}