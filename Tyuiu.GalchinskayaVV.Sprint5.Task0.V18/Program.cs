using System;
using Tyuiu.GalchinskayaVV.Sprint5.Task0.V18.Lib;

namespace Tyuiu.GalchinskayaVV.Sprint5.Task0.V18
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.Title = "Спринт #5 | Выполнил: Гальчинская Виктория Владимировна | ПКТб-25-1";

            Console.WriteLine("***************************************************************************");
            Console.WriteLine("* Спринт #5                                                               *");
            Console.WriteLine("* Тема: Работа с файлами                                                  *");
            Console.WriteLine("* Задание #0                                                              *");
            Console.WriteLine("* Вариант #18                                                             *");
            Console.WriteLine("* Выполнил: Гальчинская Виктория Владимировна | ПКТб-25-1                 *");
            Console.WriteLine("***************************************************************************");
            Console.WriteLine("* УСЛОВИЕ:                                                                *");
            Console.WriteLine("* Вычислить значение функции при x = 3 и сохранить в файл                *");
            Console.WriteLine("***************************************************************************");

            int x = 3;
            Console.WriteLine("x = " + x);

            Console.WriteLine("***************************************************************************");
            Console.WriteLine("* РЕЗУЛЬТАТ:                                                              *");
            Console.WriteLine("***************************************************************************");

            DataService ds = new DataService();
            string path = ds.SaveToFileTextData(x);

            Console.WriteLine(path);
            Console.ReadKey();
        }
    }
}
