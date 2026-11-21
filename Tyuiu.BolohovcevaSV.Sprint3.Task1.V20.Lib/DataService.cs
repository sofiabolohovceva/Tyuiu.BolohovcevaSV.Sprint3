using System;
using tyuiu.cources.programming.interfaces.Sprint3;

namespace Tyuiu.BolohovcevaSV.Sprint3.Task1.V20.Lib
{
    public class DataService : ISprint3Task1V20
    {
        public double GetSumSeries(int startValue, int stopValue)
        {
            double sumSeries = 0;
            int k = startValue;
            
            while (k <= stopValue)
            {
                sumSeries += Math.Pow((1.0 / Math.Cos(k)), 2);
                k++;
            }
            return Math.Round(sumSeries, 3);
        }
    }
}
