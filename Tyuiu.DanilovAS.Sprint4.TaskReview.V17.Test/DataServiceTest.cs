using Microsoft.VisualStudio.TestTools.UnitTesting;
using System;

using Tyuiu.DanilovAS.Sprint4.TaskReview.V17.Lib;

namespace Tyuiu.DanilovAS.Sprint4.TaskReview.V17.Test
{
    [TestClass]
    public class DataServiceTest
    {
        [TestMethod]
        public void ValidCalc()
        {
            DataService ds = new DataService();
            //"753159864"
            int rows = 3;
            int columns = 3;
            int[,] array = new int[rows, columns];
            string str = "753159864";
            int res = ds.Calculate(rows, columns, str);
            int wait = 3;
            Assert.AreEqual(wait, res);


        }
    }
}
