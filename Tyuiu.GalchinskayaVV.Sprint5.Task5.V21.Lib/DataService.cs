using System;
using System.Globalization;
using System.IO;
using tyuiu.cources.programming.interfaces.Sprint5;

namespace Tyuiu.GalchinskayaVV.Sprint5.Task5.V21.Lib
{
    public class DataService : ISprint5Task5V21
    {
        public double LoadFromDataFile(string path)
        {
            string text = File.ReadAllText(path);
            char[] separators = { ' ', '\r', '\n', '\t', ';' };

            string[] parts = text.Split(separators, StringSplitOptions.RemoveEmptyEntries);

            int maxEven = int.MinValue;
            bool found = false;

            foreach (string part in parts)
            {
                string norm = part.Replace(',', '.');

                if (double.TryParse(norm, NumberStyles.Any, CultureInfo.InvariantCulture, out double value))
                {
                    double rounded = Math.Round(value);
                    if (Math.Abs(value - rounded) < 1e-9)
                    {
                        int intVal = (int)rounded;
                        if (intVal % 2 == 0)
                        {
                            if (!found || intVal > maxEven)
                            {
                                maxEven = intVal;
                                found = true;
                            }
                        }
                    }
                }
            }

            if (!found || maxEven < 0)
            {
                return 0;
            }

            double fact = 1;
            for (int i = 1; i <= maxEven; i++)
            {
                fact *= i;
            }

            return Math.Round(fact, 3);
        }
    }
}
