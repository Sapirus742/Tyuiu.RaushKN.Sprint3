using tyuiu.cources.programming.interfaces.Sprint3;

namespace Tyuiu.RaushKN.Sprint3.Task1.V11.Lib
{
    public class DataService : ISprint3Task1V11
    {
        public double GetMultiplySeries(double value, int startValue, int stopValue)
        {
            double multSeries = 1;
            for (int i = startValue; i <= stopValue; i++)
            { 
                multSeries *= (Math.Pow(value,i) + 0.5);
            }
            return Math.Round(multSeries,3);
        }
    }
}
