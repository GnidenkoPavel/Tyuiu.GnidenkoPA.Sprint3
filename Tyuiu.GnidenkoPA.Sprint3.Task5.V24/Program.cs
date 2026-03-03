using System;
using Tyuiu.GnidenkoPA.Sprint3.Task5.V24.Lib;

namespace Tyuiu.GnidenkoPA.Sprint3.Task5.V24
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.Title = "Спринт #3 | Выполнил: Гниденко П.А. | ИИПб-24-2";
            Console.WriteLine("***************************************************************************");
            Console.WriteLine("* Спринт #3                                                               *");
            Console.WriteLine("* Тема: Вложенные циклы                                                   *");
            Console.WriteLine("* Задание #5                                                              *");
            Console.WriteLine("* Вариант #24                                                             *");
            Console.WriteLine("* Выполнил: Гниденко П.А. | ИИПб-24-2                                     *");
            Console.WriteLine("***************************************************************************");
            Console.WriteLine("* УСЛОВИЕ:                                                                *");
            Console.WriteLine("* Написать программу используя вложенные циклы, которая вычисляет сумму  *");
            Console.WriteLine("* ряда по формуле: y = sum(i=1..3) sum(k=1..12) (x^k + 2) * sin(k)       *");
            Console.WriteLine("* при X = 2                                                               *");
            Console.WriteLine("***************************************************************************");
            Console.WriteLine("* ИСХОДНЫЕ ДАННЫЕ:                                                        *");
            Console.WriteLine("***************************************************************************");

            int x = 2;
            int startI = 1;
            int stopI = 3;
            int startK = 1;
            int stopK = 12;

            Console.WriteLine($"X = {x}");
            Console.WriteLine($"Внешний цикл i от {startI} до {stopI}");
            Console.WriteLine($"Внутренний цикл k от {startK} до {stopK}");

            Console.WriteLine("***************************************************************************");
            Console.WriteLine("* РЕЗУЛЬТАТ:                                                              *");
            Console.WriteLine("***************************************************************************");

            Sprint3Task5V24 ds = new Sprint3Task5V24();
            double result = ds.GetSumSumSeries(x, startI, startK, stopI, stopK);

            Console.WriteLine($"Сумма ряда = {result}");
            Console.ReadKey();
        }
    }
}