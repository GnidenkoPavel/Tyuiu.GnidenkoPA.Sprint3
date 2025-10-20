using tyuiu.cources.programming.interfaces;
using tyuiu.cources.programming.interfaces.Sprint1;
namespace Tyuiu.GnidenkoPA.Sprint3.Task0.V15.Lib
{
    public class DataService : ISprint1Task3V15
    {
        public double DistanceOverTime(double v1, double v2, double S, double T)
        {
            double t = T;
            double sum = 0;
            double sinT = Math.Sin(t);

            for (int k = 1; k <= 10; k++)
            {
                double term = (Math.Pow(t, k) + (2.0 / (k + 1))) * sinT;
                sum += term;
            }

            return sum;
        }
    }
}
