using System;
using System.Globalization;
using System.IO;
using tyuiu.cources.programming.interfaces.Sprint5;

namespace Tyuiu.GalchinskayaVV.Sprint5.Task0.V18.Lib
{
    public class DataService : ISprint5Task0V18
    {

        private double Calculate(int x)
        {
            double y = (double)x / Math.Sqrt(x * x + x);
            return Math.Round(y, 3);
        }

        public string SaveToFileTextData(int x)
        {
            double result = Calculate(x);

            string path = Path.Combine(Path.GetTempPath(), "OutPutFileTask0.txt");

            File.WriteAllText(path, result.ToString("0.000", CultureInfo.InvariantCulture));

            return path;
        }
    }
}
