using Microsoft.VisualStudio.TestTools.UnitTesting;
using System;
using System.IO;
using Tyuiu.GalchinskayaVV.Sprint5.Task6.V29.Lib;

namespace Tyuiu.GalchinskayaVV.Sprint5.Task6.V29.Test
{
    [TestClass]
    public class DataServiceTest
    {
        [TestMethod]
        public void CheckLoadFromDataFile()
        {
            string path = @"C:\Users\1\source\repos\Tyuiu.GalchinskayaVV.Sprint5\InPutDataFileTask6V29.txt";

            DataService ds = new DataService();
            int actual = ds.LoadFromDataFile(path);

            string text = File.ReadAllText(path);
            char[] separators =
            {
                ' ', '\r', '\n', '\t',
                '.', ',', '!', '?', ';', ':',
                '-', '"', '\'', '(', ')'
            };
            string[] parts = text.Split(separators, StringSplitOptions.RemoveEmptyEntries);

            int expected = 0;
            foreach (string word in parts)
            {
                if (word.Length == 7)
                {
                    expected++;
                }
            }

            Assert.AreEqual(expected, actual);
        }
    }
}
