using System;

namespace Proba1.OneArguments
{
    public class ArccosxCalculate : IOneArgumentsCalculator
    {/// <summary>
     /// arccosine function
     /// </summary>
     /// <param name="firstArgument"> firstArgument-value of cosinus </param>
     /// <returns>degree</returns>
        public double Calculate(double firstArgument)
        {
            return Math.Acos(firstArgument * Math.PI / 180);
        }
    }
}