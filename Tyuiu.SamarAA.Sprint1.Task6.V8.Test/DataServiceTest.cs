using Microsoft.VisualStudio.TestTools.UnitTesting;
using System;

using Tyuiu.SamarAA.Sprint1.Task6.V8.Lib;

namespace Tyuiu.SamarAA.Sprint1.Task6.V8.Test
{
    [TestClass]
    public class DataServiceTest
    {
        [TestMethod]
        public void ValidString()
        {
            string strTest = "АБВ ВГД ДЗЖ";
            DataService ds = new DataService();
            string res = ds.MoveLetterToEnd(strTest);
            string wait = "БВА ГДВ ЗЖД";
            Assert.AreEqual(wait, res);
        }
    }
}
