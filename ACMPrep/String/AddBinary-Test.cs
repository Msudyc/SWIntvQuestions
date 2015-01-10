using System;
using System.Collections.Generic;
using Microsoft.VisualStudio.TestTools.UnitTesting;

namespace ACMPrep
{
    [TestClass]
    public partial class StringIntv
    {
        [TestMethod]
        public void StringIntv_AddBinaryTest1()
        {
            Assert.AreEqual("101010110", AddBinary("11111111", "1010111"));
        }

        [TestMethod]
        public void StringIntv_AddBinaryTest2()
        {
            Assert.AreEqual("10", AddBinary("1", "1"));
        }

        [TestMethod]
        public void StringIntv_AddBinaryTest3()
        {
            Assert.AreEqual("0", AddBinary("0", "0"));
        }

        [TestMethod]
        public void StringIntv_AddBinaryTest4()
        {
            Assert.AreEqual("1", AddBinary("1", "0"));
        }
    };
}