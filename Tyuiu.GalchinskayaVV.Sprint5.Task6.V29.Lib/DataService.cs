using System;
using System.IO;
using tyuiu.cources.programming.interfaces.Sprint5;

namespace Tyuiu.GalchinskayaVV.Sprint5.Task6.V29.Lib
{
    public class DataService : ISprint5Task6V29
    {
        public int LoadFromDataFile(string path)
        {
            string text = File.ReadAllText(path);

            char[] separators =
            {
                ' ', '\r', '\n', '\t',
                '.', ',', '!', '?', ';', ':',
                '-', '"', '\'', '(', ')'
            };

            string[] parts = text.Split(separators, StringSplitOptions.RemoveEmptyEntries);

            int count = 0;

            foreach (string word in parts)
            {
                if (word.Length == 7)
                {
                    count++;
                }
            }

            return count;
        }
    }
}
