using System;
using Tyuiu.BolohovcevaSV.Sprint3.Task7.V20.Lib;

namespace Tyuiu.BolohovcevaSV.Sprint3.Task7.V20
{
    class Program
    {
        static void Main(string[] args)
        {
            DataService ds = new DataService();

            Console.Title = "Спринт 3 | Выполнила: Болоховцева С. В. | СМАРТб-26-1";

            Console.WriteLine("***************************************************************************");
            Console.WriteLine("* Спринт 3                                                                *");
            Console.WriteLine("* Тема: Операторы циклов                                                   *");
            Console.WriteLine("* Задание №7                                                              *");
            Console.WriteLine("* Вариант №20                                                             *");
            Console.WriteLine("* Выполнила: Болоховцева София Вячеславовна | СМАРТб-26-1                 *");
            Console.WriteLine("***************************************************************************");
            Console.WriteLine("* УСЛОВИЕ:                                                                *");
            Console.WriteLine("* Вычислить значения функции на отрезке [-5; 5] с шагом 1.                *");
            Console.WriteLine("* Проверить деление на ноль. Значения занести в массив.                   *");
            Console.WriteLine("***************************************************************************");
            Console.WriteLine("* ИСХОДНЫЕ ДАННЫЕ:                                                        *");

            int startValue = -5;
            int stopValue = 5;

            Console.WriteLine("Старт шага = " + startValue);
            Console.WriteLine("Конец шага = " + stopValue);

            int len = ds.GetMassFunction(startValue, stopValue).Length;

            double[] valueArray;
            valueArray = new double[len];

            valueArray = ds.GetMassFunction(startValue, stopValue);

            Console.WriteLine("***************************************************************************");
            Console.WriteLine("* РЕЗУЛЬТАТ:                                                              *");
            Console.WriteLine("***************************************************************************");

            Console.WriteLine("------------+------------");
            Console.WriteLine("|     x     |    f(x)    |");
            Console.WriteLine("------------+------------");

            for (int i = 0; i < len; i++)
            {
                Console.WriteLine("| {0,7:d}   | {1,8:f2}   |", startValue, valueArray[i]);
                startValue++;
            }

            Console.WriteLine("------------+------------");

            Console.ReadKey();
        }
    }
}