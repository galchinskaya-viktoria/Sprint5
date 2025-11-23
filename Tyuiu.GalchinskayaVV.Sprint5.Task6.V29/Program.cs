using System;
using Tyuiu.GalchinskayaVV.Sprint5.Task6.V29.Lib;

namespace Tyuiu.GalchinskayaVV.Sprint5.Task6.V29
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.Title = "Спринт #5 | Выполнил: Гальчинская Виктория Владимировна | ПКТб-25-1";

            Console.WriteLine("***************************************************************************");
            Console.WriteLine("* Спринт #5                                                               *");
            Console.WriteLine("* Тема: Работа с файлами                                                  *");
            Console.WriteLine("* Задание #6                                                              *");
            Console.WriteLine("* Вариант #29                                                             *");
            Console.WriteLine("* Выполнил: Гальчинская Виктория Владимировна | ПКТб-25-1                 *");
            Console.WriteLine("***************************************************************************");
            Console.WriteLine("* УСЛОВИЕ:                                                                *");
            Console.WriteLine("* Найти количество слов длиной 7 символов в заданной строке из файла     *");
            Console.WriteLine("***************************************************************************");

            string path = @"C:\Users\1\source\repos\Tyuiu.GalchinskayaVV.Sprint5\InPutDataFileTask6V29.txt";

            DataService ds = new DataService();
            int result = ds.LoadFromDataFile(path);

            Console.WriteLine("Количество слов длиной 7 символов: " + result);
            Console.ReadKey();
        }
    }
}
