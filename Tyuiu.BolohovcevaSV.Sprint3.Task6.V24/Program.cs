using System;
using Tyuiu.BolohovcevaSV.Sprint3.Task6.V24.Lib;

namespace Tyuiu.BolohovcevaSV.Sprint3.Task6.V24
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
            Console.WriteLine("* Задание №6                                                              *");
            Console.WriteLine("* Вариант №24                                                             *");
            Console.WriteLine("* Выполнила: Болоховцева София Вячеславовна | СМАРТб-26-1                 *");
            Console.WriteLine("***************************************************************************");
            Console.WriteLine("* УСЛОВИЕ:                                                                *");
            Console.WriteLine("* Найти количество всех делителей чисел на отрезке [17, 26]               *");
            Console.WriteLine("*                                                                         *");
            Console.WriteLine("***************************************************************************");
            Console.WriteLine("* ИСХОДНЫЕ ДАННЫЕ:                                                        *");

            int startValue = 17;
            int stopValue = 26;

            Console.WriteLine("Начало отрезка" + startValue);
            Console.WriteLine("Конец отрезка" + stopValue);


            Console.WriteLine("***************************************************************************");
            Console.WriteLine("* РЕЗУЛЬТАТ:                                                              *");
            Console.WriteLine("***************************************************************************");

            Console.WriteLine("Количество делителей" + ds.GetSumTheDivisors(startValue, stopValue));

            Console.ReadLine();
        }
    }
}