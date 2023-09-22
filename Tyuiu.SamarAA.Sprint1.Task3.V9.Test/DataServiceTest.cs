using Microsoft.VisualStudio.TestTools.UnitTesting;
using System;

using Tyuiu.SamarAA.Sprint1.Task3.V9.Lib;

namespace Tyuiu.SamarAA.Sprint1.Task3.V9.Test
{
    [TestClass]
    public class DataServiceTest
    {
        [TestMethod]
        public void ValidExpression()
        {
            DataService ds = new DataService();
            int x = 180;
            int wait = 3;
            var res = ds.ConvertMinutesToHours(x);
            Assert.AreEqual(wait, res);

        }
    }
}
