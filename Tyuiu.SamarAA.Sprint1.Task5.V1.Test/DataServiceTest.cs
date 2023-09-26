using Microsoft.VisualStudio.TestTools.UnitTesting;
using System;

using Tyuiu.SamarAA.Sprint1.Task5.V1.Lib;

namespace Tyuiu.SamarAA.Sprint1.Task5.V1.Test
{
    [TestClass]
    public class DataServiceTest
    {
        [TestMethod]
        public void ValidExpression()
        {
            double x1 = -1;
            double x2 = 3;
            double y1 = 6;
            double y2 = 2;
            DataService ds = new DataService();
            double res = ds.DistanceBetweenDots(x1,x2,y1,y2);

            int result = Convert.ToInt32(res);

            int wait = 7;
            Assert.AreEqual(wait, result);
        }
    }
}
