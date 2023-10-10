using Microsoft.VisualStudio.TestTools.UnitTesting;
using System;
using Tyuiu.SpirinAA.Sprint2.Task4.V3.Lib;

namespace Tyuiu.SpirinAA.Sprint2.Task4.V3.Test
{
    [TestClass]
    public class DataServiceTest
    {
        [TestMethod]
        public void ValidCondition1()
        {
            DataService ds = new DataService();
            double x = 10;
            double y = 13;
            double res = ds.Calculate(x, y);
            double wait = 14;
            Assert.AreEqual(wait, res);
        }

        [TestMethod]
        public void ValidCondition2()
        {
            DataService ds = new DataService();
            double x = 5;
            double y = 4;
            double res = ds.Calculate(x, y);
            double wait = 6.143;
            Assert.AreEqual(wait, res);
        }
    }
}
