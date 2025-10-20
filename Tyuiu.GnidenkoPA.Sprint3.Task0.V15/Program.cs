using System;
using Tyuiu.GnidenkoPA.Sprint3.Task0.V15.Lib;
namespace Tyuiu.GnidenkoPA.Sprint3.Task0.V15
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("***************************************************************************");
            Console.WriteLine("* ИСХОДНЫЕ ДАННЫЕ:                                                       *");
            Console.WriteLine("***************************************************************************");

            double t = 0.7;
            Console.WriteLine($"Значение t = {t}");

            Console.WriteLine();
            Console.WriteLine("***************************************************************************");
            Console.WriteLine("* РЕЗУЛЬТАТ:                                                             *");
            Console.WriteLine("***************************************************************************");

            DataService ds = new DataService();
            double result = ds.DistanceOverTime(0, 0, 0, t);

            Console.WriteLine($"Сумма ряда S при t = {t} равна: {result:F4}");
            Console.ReadKey();
        }
    }
}