using System;
using Microsoft.VisualStudio.TestTools.UnitTesting;

using Tyuiu.MaslennikovVA.Sprint4.Task2.V20.Lib;

namespace Tyuiu.MaslennikovVA.Sprint4.Task2.V20.Test
{
    [TestClass]
    public class DataServiceTest
    {
        [TestMethod]
        public void ValidCalculate()
        {
            DataService ds = new DataService();

            int[] numsArray = { 2, 4, 7, 5, 2, 6, 5, 7, 7, 6, 4, 5, 6, 7, 4, 5 };

            int res = ds.Calculate(numsArray);
            int wait = 35;

            Assert.AreEqual(wait, res);
        }
    }
}
