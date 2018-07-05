using System;

namespace Proba1.OneArguments
{
    public class ArcsinxCalculatorcs : IOneArgumentsCalculator
    {/// <summary>
     /// arcsinus function
     /// </summary>
     /// <param name="firstArgument"> firstArgument-value of sinus </param>
     /// <returns>degree</returns>

        public double Calculate(double firstArgument)
        {
            return Math.Asin(firstArgument * Math.PI / 180);
        }
    } 
}