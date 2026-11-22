using System;
using Tyuiu.BolohovcevaSV.Sprint3.Task5.V17.Lib;

namespace Tyuiu.BolohovcevaSV.Sprint3.Task5.V17
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
            Console.WriteLine("* Задание №5                                                              *");
            Console.WriteLine("* Вариант №17                                                             *");
            Console.WriteLine("* Выполнила: Болоховцева София Вячеславовна | СМАРТб-26-1                 *");
            Console.WriteLine("***************************************************************************");
            Console.WriteLine("* УСЛОВИЕ:                                                                *");
            Console.WriteLine("* вычислить значение функции y=x/(sin(x) - x),                            *");
            Console.WriteLine("* где x принимает значения от -5 до 5                                     *");
            Console.WriteLine("*                                                                         *");
            Console.WriteLine("***************************************************************************");
            Console.WriteLine("* ИСХОДНЫЕ ДАННЫЕ:                                                        *");

            int x = 2;
            int startValue1 = 1;
            int stopValue1 = 3;
            int startValue2 = 1;
            int stopValue2 = 12;

            Console.WriteLine("Переменная х" + x);
            Console.WriteLine("Старт шага первой суммы ряда" + startValue1);
            Console.WriteLine("Конец шага первой суммы ряда" + stopValue1);
            Console.WriteLine("Старт шага второй суммы ряда" + startValue2); 
            Console.WriteLine("Конец шага второй суммы ряда" + stopValue2);

            Console.WriteLine("***************************************************************************");
            Console.WriteLine("* РЕЗУЛЬТАТ:                                                              *");
            Console.WriteLine("***************************************************************************");

            Console.WriteLine("Сумма сумм ряда" + ds.GetSumSumSeries(x, startValue1, startValue2, stopValue1, stopValue2));

            Console.ReadLine();
        }
    }
}