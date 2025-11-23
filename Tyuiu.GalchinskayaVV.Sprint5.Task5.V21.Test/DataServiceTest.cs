using Microsoft.VisualStudio.TestTools.UnitTesting;
using System;
using System.Globalization;
using System.IO;
using Tyuiu.GalchinskayaVV.Sprint5.Task5.V21.Lib;

namespace Tyuiu.GalchinskayaVV.Sprint5.Task5.V21.Test
{
    [TestClass]
    public class DataServiceTest
    {
        [TestMethod]
        public void CheckLoadFromDataFile()
        {
            string path = @"C:\Users\1\source\repos\Tyuiu.GalchinskayaVV.Sprint5\InPutDataFileTask5V21.txt";

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

            double expected = 0;

            if (found && maxEven >= 0)
            {
                double fact = 1;
                for (int i = 1; i <= maxEven; i++)
                {
                    fact *= i;
                }

                expected = Math.Round(fact, 3);
            }

            DataService ds = new DataService();
            double actual = ds.LoadFromDataFile(path);

            Assert.AreEqual(expected, actual);
        }
    }
}
