using System;
using tyuiu.cources.programming.interfaces.Sprint3;

namespace Tyuiu.BolohovcevaSV.Sprint3.Task2.V20.Lib
{
    public class DataService : ISprint3Task2V20
    {
        public double GetMultiplySeries(int value, int startValue, int stopValue)
        {
            double multiplySeries = 1;
            int k = startValue;
            do
            {
                multiplySeries *= Math.Pow((2.0 / (Math.Cos(value) + 0.5)), k);
                k++;
            } while (k <= stopValue);
            return Math.Round(multiplySeries, 3);
        }
    }
}
