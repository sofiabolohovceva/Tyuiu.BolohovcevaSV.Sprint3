using System;
using Tyuiu.BolohovcevaSV.Sprint3.Task3.V9.Lib;

namespace Tyuiu.BolohovcevaSV.Sprint3.Task3.V9
{
    class Program
    {
        static void Main(string[] args)
        {
            DataService ds = new DataService();

            Console.Title = "Спринт 3 | Выполнила: Болоховцева С. В. | СМАРТб-26-1";

            Console.WriteLine("***************************************************************************");
            Console.WriteLine("* Спринт 3                                                                *");
            Console.WriteLine("* Тема: Операции с символами                                              *");
            Console.WriteLine("* Задание №3                                                              *");
            Console.WriteLine("* Вариант №9                                                              *");
            Console.WriteLine("* Выполнила: Болоховцева София Вячеславовна | СМАРТб-26-1                 *");
            Console.WriteLine("***************************************************************************");
            Console.WriteLine("* УСЛОВИЕ:                                                                *");
            Console.WriteLine("* Используя цикл foreach заменить цифры на заданный символ в строке.    *");
            Console.WriteLine("***************************************************************************");
            Console.WriteLine("* ИСХОДНЫЕ ДАННЫЕ:                                                        *");

            string value = "56hy vfe4r4 vf45b";
            char item = 'w';

            Console.WriteLine("Исходная строка: " + value);
            Console.WriteLine("Символ замены: " + item);

            Console.WriteLine("***************************************************************************");
            Console.WriteLine("* РЕЗУЛЬТАТ:                                                              *");
            Console.WriteLine("***************************************************************************");

            Console.WriteLine("Измененная строка: " + ds.ReplaceNumOnChar(value, item));

            Console.WriteLine("***************************************************************************");

            Console.ReadLine();
        }
    }
}
