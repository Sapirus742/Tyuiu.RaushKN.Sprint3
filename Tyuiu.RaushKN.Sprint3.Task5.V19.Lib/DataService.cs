using tyuiu.cources.programming.interfaces.Sprint3;

namespace Tyuiu.RaushKN.Sprint3.Task5.V19.Lib
{
    public class DataService : ISprint3Task5V19
    {
        public double GetSumSumSeries(int x, int startValue1, int startValue2, int stopValue1, int stopValue2)
        {
            double sumsumValue = 0;
            for (int i = 1; i <= 3; i++)
            {
                for (int k = 1; k <= 6; k++)
                    sumsumValue += Math.Pow((x / Math.Cos(x)), k);
            }
            return Math.Round(sumsumValue,3);
        }
    }
}
