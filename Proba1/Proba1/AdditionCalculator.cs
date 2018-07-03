namespace Proba1
{
    public class AdditionCalculator : ITwoArgumentsCalculator
    {
        public double Calculate(double firstArgument, double secondArgument)
        {
            return firstArgument + secondArgument;
        }
    }
}
