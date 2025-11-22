using Microsoft.VisualStudio.TestTools.UnitTesting;
using Tyuiu.GalchinskayaVV.Sprint5.Task0.V18.Lib;

namespace Tyuiu.GalchinskayaVV.Sprint5.Task0.V18.Test
{
    [TestClass]
    public class DataServiceTest
    {
        [TestMethod]
        public void CheckCalculateValid()
        {
            DataService ds = new DataService();
            int x = 3;
            double result = ds.Calculate(x);
            double wait = 0.866;
            Assert.AreEqual(wait, result);
        }

        [TestMethod]
        public void CheckSaveToFileValid()
        {
            DataService ds = new DataService();
            int x = 3;
            string path = ds.SaveToFile(x);

            Assert.IsTrue(File.Exists(path));

            string fileContent = File.ReadAllText(path);
            string expected = "0.866";
            Assert.AreEqual(expected, fileContent.Trim());
        }
    }
}
