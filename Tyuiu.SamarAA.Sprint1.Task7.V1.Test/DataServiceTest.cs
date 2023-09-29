using Microsoft.VisualStudio.TestTools.UnitTesting;
using System;

using Tyuiu.SamarAA.Sprint1.Task7.V1.Lib;

namespace Tyuiu.SamarAA.Sprint1.Task7.V1.Test
{
    [TestClass]
    public class DataServiceTest
    {
        [TestMethod]
        public void ValidExpression()
        {
            DataService ds = new DataService();
            double a = 1;
            double b = 2;
            double c = 3;
            double wait = 0.25;
            var res = ds.Calculate(a, b, c);
            Assert.AreEqual(wait, res);

        }
    }
}
