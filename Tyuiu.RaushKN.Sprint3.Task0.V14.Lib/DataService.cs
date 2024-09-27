using tyuiu.cources.programming.interfaces.Sprint3;

namespace Tyuiu.RaushKN.Sprint3.Task0.V14.Lib
{
    public class DataService : ISprint3Task0V14
    {
        public double GetMultiplySeries(int value, int startValue, int stopValue)
        {
            double multSeries = 1;
            for (int i = startValue; i <= stopValue; i++)
            {
                multSeries *= Math.Pow(i,value);
            }
            return multSeries;
        }
    }
}
