namespace Proba1.OneArguments
{
    public class UnitDividedCalculator : IOneArgumentsCalculator
    {
        public double Calculate(double firstArgument)
        {
            return (1 / firstArgument);
        }
    }
}