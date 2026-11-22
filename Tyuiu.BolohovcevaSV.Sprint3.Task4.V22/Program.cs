using System;
using Tyuiu.BolohovcevaSV.Sprint3.Task4.V22.Lib;

namespace Tyuiu.BolohovcevaSV.Sprint3.Task4.V22
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
            Console.WriteLine("* Задание №4                                                              *");
            Console.WriteLine("* Вариант №22                                                             *");
            Console.WriteLine("* Выполнила: Болоховцева София Вячеславовна | СМАРТб-26-1                 *");
            Console.WriteLine("***************************************************************************");
            Console.WriteLine("* УСЛОВИЕ:                                                                *");
            Console.WriteLine("* вычислить значение функции y=x/(sin(x) - x),                            *");
            Console.WriteLine("* где x принимает значения от -5 до 5                                     *");
            Console.WriteLine("*                                                                         *");
            Console.WriteLine("***************************************************************************");
            Console.WriteLine("* ИСХОДНЫЕ ДАННЫЕ:                                                        *");

            int startValue = -5;
            int stopValue = 5;

            Console.WriteLine("Начало шага" + startValue);
            Console.WriteLine("Конец шага" + stopValue);


            Console.WriteLine("***************************************************************************");
            Console.WriteLine("* РЕЗУЛЬТАТ:                                                              *");
            Console.WriteLine("***************************************************************************");

            Console.WriteLine("Сумма ряда" + ds.Calculate(startValue, stopValue));

            Console.ReadLine();
        }
    }
}