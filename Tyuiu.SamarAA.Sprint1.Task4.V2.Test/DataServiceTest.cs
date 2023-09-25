using Microsoft.VisualStudio.TestTools.UnitTesting;
using System;

using Tyuiu.SamarAA.Sprint1.Task4.V2.Lib;

namespace Tyuiu.SamarAA.Sprint1.Task4.V2.Test
{
    [TestClass]
    public class DataServiceTest
    {
        [TestMethod]
        public void ValidExpression()
        {
            DataService ds = new DataService();
            double x = 5;
            double y = 2;
            double wait = 0.333;
            var res = ds.Calculate(x, y);
            Assert.AreEqual(wait, res);

        }
    }
}
