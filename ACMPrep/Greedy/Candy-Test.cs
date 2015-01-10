using System;
using System.Collections.Generic;
using Microsoft.VisualStudio.TestTools.UnitTesting;

namespace ACMPrep
{
    [TestClass]
    public partial class Greedy
    {
        [TestMethod]
        public void Greedy_CandyTest1()
        {
            int[] rating = { 1, 4, 1, 2 };
            Assert.AreEqual(6, Candy(rating));
        }

        [TestMethod]
        public void Greedy_CandyTest2()
        {
            int[] rating = { 1, 4 };
            Assert.AreEqual(3, Candy(rating));
        }

        [TestMethod]
        public void Greedy_CandyTest3()
        {
            int[] rating = { 1 };
            Assert.AreEqual(1, Candy(rating));
        }
    };
}