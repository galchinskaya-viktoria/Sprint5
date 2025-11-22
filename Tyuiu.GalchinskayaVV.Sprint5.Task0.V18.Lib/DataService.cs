using System;
using System.IO;
using System.Globalization;
using tyuiu.cources.programming.interfaces.Sprint5;

namespace Tyuiu.GalchinskayaVV.Sprint5.Task0.V18.Lib
{
    public class DataService : ISprint5Task0V18
    {
        public double Calculate(int x)
        {
            double y = x / Math.Sqrt(x * x + x);
            return Math.Round(y, 3);
        }

        public string SaveToFile(int x)
        {
            double result = Calculate(x);
            string path = Path.Combine(Path.GetTempPath(), "OutPutFileTask0.txt");
            File.WriteAllText(path, result.ToString("0.000", CultureInfo.InvariantCulture));
            return path;
        }
    }
}
