using System;
using Tyuiu.BolohovcevaSV.Sprint3.Task2.V20.Lib;

namespace Tyuiu.BolohovcevaSV.Sprint3.Task2.V20
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
            Console.WriteLine("* Задание №2                                                              *");
            Console.WriteLine("* Вариант №20                                                             *");
            Console.WriteLine("* Выполнила: Болоховцева София Вячеславовна | СМАРТб-26-1                 *");
            Console.WriteLine("***************************************************************************");
            Console.WriteLine("* УСЛОВИЕ:                                                                *");
            Console.WriteLine("* Написать программу используя цикл do...while, при х = 1                 *");
            Console.WriteLine("* P = произведение от k=1 до 6 (2/(cos(x)+0.5))^k                         *");
            Console.WriteLine("*                                                                         *");
            Console.WriteLine("***************************************************************************");
            Console.WriteLine("* ИСХОДНЫЕ ДАННЫЕ:                                                        *");

            int value = 1;
            int startValue = 1;
            int stopValue = 6;

            Console.WriteLine("Переменная х" + value);
            Console.WriteLine("Начало шага" + startValue);
            Console.WriteLine("Конец шага" + stopValue);


            Console.WriteLine("***************************************************************************");
            Console.WriteLine("* РЕЗУЛЬТАТ:                                                              *");
            Console.WriteLine("***************************************************************************");

            Console.WriteLine("Произведение ряда" + ds.GetMultiplySeries(value, startValue, stopValue));

            Console.ReadLine();
        }
    }
}