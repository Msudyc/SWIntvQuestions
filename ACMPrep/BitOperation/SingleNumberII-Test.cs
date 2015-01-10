using System;
using System.Collections.Generic;
using Microsoft.VisualStudio.TestTools.UnitTesting;

namespace ACMPrep
{
    public partial class BitOperation
    {
        [TestMethod]
        public void BitOperation_SingleNumberIITest1()
        {
            int[] t = { 1, 3, 2, 3, 2, 1, 4, 2, 1, 3 };
            Assert.AreEqual(4, SingleNumberII(t));
        }

        [TestMethod]
        public void BitOperation_SingleNumberIITest2()
        {
            int[] t = { 1 };
            Assert.AreEqual(1, SingleNumberII(t));
        }

        [TestMethod]
        public void BitOperation_SingleNumberIITest3()
        {
            int[] t = { 1, 3, 2, 3, 2, 1, 4, 2, 1, 3 };
            Assert.AreEqual(4, SingleNumberII(t));
        }

        [TestMethod]
        public void BitOperation_SingleNumberIITest4()
        {
            int[] t = { 1 };
            Assert.AreEqual(1, SingleNumberII(t));
        }
    };
}