using System;
using System.IO;
using System.Text;
using System.Globalization;
using tyuiu.cources.programming.interfaces.Sprint5;

namespace Tyuiu.GalchinskayaVV.Sprint5.Task1.V19.Lib
{
    public class DataService : ISprint5Task1V19
    {
        public string SaveToFileTextData(int startValue, int stopValue)
        {
            string path = Path.Combine(Path.GetTempPath(), "OutPutFileTask1.txt");
            StringBuilder sb = new StringBuilder();

            for (int x = startValue; x <= stopValue; x++)
            {
                double denom = 3 * x + 0.5;
                double fx;

                if (denom == 0)
                {
                    fx = 0;
                }
                else
                {
                    fx = Math.Sin(x) + 2.0 / denom - 2 * Math.Cos(x) * 2 * x;
                }

                fx = Math.Round(fx, 2);
                sb.AppendLine(fx.ToString("0.##").Replace('.', ','));
            }


            File.WriteAllText(path, sb.ToString());
            return path;
        }
    }
}
