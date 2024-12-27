using System;
using Microsoft.VisualStudio.TestTools.UnitTesting;

using Tyuiu.MaslennikovVA.Sprint4.Task5.V17.Lib;

namespace Tyuiu.MaslennikovVA.Sprint4.Task5.V17.Test
{
    [TestClass]
    public class DataServiceTest
    {
        [TestMethod]
        public void ValidCalculate()
        {
            DataService ds = new DataService();

            int[,] mas2 = new int[5, 5] { { -5, 1, -7, 1, 3 },
                                          { 1, -5, -5, 2, 3 },
                                          { 3, 1, 3, -8, 2 },
                                          { 3, 1, 2, -8, 3 },
                                          { 2, -6, -7, -7, 2 } };
            int res = ds.Calculate(mas2);
            int wait = 9;
            Assert.AreEqual(wait, res);
        }
    }
}
