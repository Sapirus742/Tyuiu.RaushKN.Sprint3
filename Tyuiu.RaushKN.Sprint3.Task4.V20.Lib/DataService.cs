using tyuiu.cources.programming.interfaces.Sprint3;

namespace Tyuiu.RaushKN.Sprint3.Task4.V20.Lib
{
    public class DataService : ISprint3Task4V20
    {
        public double Calculate(int startValue, int stopValue)
        {
            double calcValue = 1;

            for (int i = startValue; i <= stopValue; i++)
            {
                if (i == 0) continue;
                calcValue *= i / (Math.Cos(i) - i) + 2.5;
            }
            return Math.Round(calcValue,3);
        }
    }
}
