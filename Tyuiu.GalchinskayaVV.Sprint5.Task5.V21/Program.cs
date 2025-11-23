using System;
using Tyuiu.GalchinskayaVV.Sprint5.Task5.V21.Lib;

namespace Tyuiu.GalchinskayaVV.Sprint5.Task5.V21
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.Title = "Спринт #5 | Выполнил: Гальчинская Виктория Владимировна | ПКТб-25-1";

            Console.WriteLine("***************************************************************************");
            Console.WriteLine("* Спринт #5                                                               *");
            Console.WriteLine("* Тема: Работа с файлами                                                  *");
            Console.WriteLine("* Задание #5                                                              *");
            Console.WriteLine("* Вариант #21                                                             *");
            Console.WriteLine("* Выполнил: Гальчинская Виктория Владимировна | ПКТб-25-1                 *");
            Console.WriteLine("***************************************************************************");
            Console.WriteLine("* УСЛОВИЕ:                                                                *");
            Console.WriteLine("* Найти факториал наибольшего целого числа, делящегося на 2,              *");
            Console.WriteLine("* из файла InPutDataFileTask5V21.txt                                      *");
            Console.WriteLine("***************************************************************************");

            string path = @"C:\Users\1\source\repos\Tyuiu.GalchinskayaVV.Sprint5\InPutDataFileTask5V21.txt";

            DataService ds = new DataService();
            double result = ds.LoadFromDataFile(path);

            Console.WriteLine("Результат: " + result);
            Console.ReadKey();
        }
    }
}
