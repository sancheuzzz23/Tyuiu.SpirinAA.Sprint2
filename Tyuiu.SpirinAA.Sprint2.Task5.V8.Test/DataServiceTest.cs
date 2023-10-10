using Microsoft.VisualStudio.TestTools.UnitTesting;
using System;
using System.Security.Cryptography;
using Tyuiu.SpirinAA.Sprint2.Task5.V8.Lib;

namespace Tyuiu.SpirinAA.Sprint2.Task5.V8.Test
{
    [TestClass]
    public class DataServiceTest
    {
        [TestMethod]
        public void ValidFindMonthName()
        {
            DataService ds = new DataService();

            int n = 24;
            int m = 8;
            string wait = "Предыдущий день: 23.08";

            string res = ds.FindDateOfPreviousDay(n, m);

            Assert.AreEqual(wait, res);
        }
    }
}
