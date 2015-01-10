using System;
using System.Collections.Generic;
using Microsoft.VisualStudio.TestTools.UnitTesting;

namespace ACMPrep
{
    [TestClass]
    public partial class BitOperation
    {
        [TestMethod]
        public void BitOperation_SingleNumberTest1()
        {
            int[] t = { 1, 3, 2, 4, 2, 1, 3 };
            Assert.AreEqual(4, SingleNumber(t));
        }

        [TestMethod]
        public void BitOperation_SingleNumberTest2()
        {
            int[] t = { 1 };
            Assert.AreEqual(1, SingleNumber(t));
        }
    };
}