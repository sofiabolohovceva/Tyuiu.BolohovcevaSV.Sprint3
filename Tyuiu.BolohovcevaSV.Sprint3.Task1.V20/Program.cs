using System;
using Tyuiu.BolohovcevaSV.Sprint3.Task1.V20.Lib;

namespace Tyuiu.BolohovcevaSV.Sprint3.Task1.V20
{
    class Program
    {
        static void Main(string[] args)
        {
            DataService ds = new DataService();
            Console.Title = "Спринт 3 | Выполнила: Болоховцева С. В. | СМАРТб-26-1";
            Console.WriteLine("***************************************************************************");
            Console.WriteLine("* Спринт 3                                                                *");
            Console.WriteLine("* Тема: Операции сравнения                                                *");
            Console.WriteLine("* Задание №1                                                              *");
            Console.WriteLine("* Вариант №20                                                             *");
            Console.WriteLine("* Выполнила: Болоховцева София Вячеславовна | СМАРТб-26-1                 *");
            Console.WriteLine("***************************************************************************");
            Console.WriteLine("* УСЛОВИЕ:                                                                *");
            Console.WriteLine("* вычислить сумму ряда по заданной формуле.                               *");
            Console.WriteLine("* S = сумма от k=1 до 16 (1/cos(k))^2                                     *");
            Console.WriteLine("*                                                                         *");
            Console.WriteLine("***************************************************************************");
            Console.WriteLine("* ИСХОДНЫЕ ДАННЫЕ:                                                        *");

            int startValue = 1;
            int stopValue = 16;

            Console.WriteLine("Начало шага" + startValue);
            Console.WriteLine("Конец шага" + stopValue);


            Console.WriteLine("***************************************************************************");
            Console.WriteLine("* РЕЗУЛЬТАТ:                                                              *");
            Console.WriteLine("***************************************************************************");

            Console.WriteLine("Сумма ряда" + ds.GetSumSeries(startValue, stopValue));

            Console.ReadLine();
        }
    }
}