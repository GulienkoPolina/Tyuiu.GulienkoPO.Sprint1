using tyuiu.cources.programming.interfaces.Sprint1;
using static System.Runtime.InteropServices.JavaScript.JSType;

namespace Tyuiu.GulienkoPO.Sprint1.Task4.V17.Lib
{
    public class DataService : ISprint1Task4V17
    {
        public double Calculate(double x, double y)
        {
            var res = 1 / (Math.Sqrt(x - 5 * y));
            return Math.Round(res, 3);
        }
    }
}