using System;
using tyuiu.cources.programming.interfaces.Sprint3;

namespace Tyuiu.BolohovcevaSV.Sprint3.Task7.V20.Lib
{
    public class DataService : ISprint3Task7V20
    {
        public double[] GetMassFunction(int startValue, int stopValue)
        {
            int len = stopValue - startValue + 1;
            double[] valueArray = new double[len];

            for (int i = 0; i < len; i++)
            {
                double x = startValue + i;

                double denominator = 3 * x - 1;

                if (denominator == 0)
                {
                    valueArray[i] = 0;
                }
                else
                {
                    valueArray[i] = Math.Round(
                        (Math.Sin(x) - 2 * x) / denominator
                        + Math.Sin(x) - 3 * x + 2, 2);
                }
            }

            return valueArray;
        }
    }
}
