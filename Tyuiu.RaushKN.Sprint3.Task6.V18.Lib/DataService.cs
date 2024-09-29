﻿using tyuiu.cources.programming.interfaces.Sprint3;

namespace Tyuiu.RaushKN.Sprint3.Task6.V18.Lib
{
    public class DataService : ISprint3Task6V18
    {
        public int GetSumTheDivisors(int startValue, int stopValue)
        {
            int sumDiv = 0;
            for (int i = startValue; i <= stopValue; i++)
            {
                for (int j = 1; j <= i; j++)
                {
                    if ((i % j == 0) & (j < 10))
                    {
                        sumDiv += j;
                    }
                }
            }
            return sumDiv;
        }
    }
}
