using System;
using System.Collections.Generic;
using Microsoft.VisualStudio.TestTools.UnitTesting;

namespace ACMPrep
{
    public partial class StringIntv
    {
        [TestMethod]
        public void StringIntv_CountAndSayTest1()
        {
            Assert.AreEqual("1113213211", CountAndSay(8));
        }

        [TestMethod]
        public void StringIntv_CountAndSayTest2()
        {
            Assert.AreEqual("1", CountAndSay(1));
        }

        [TestMethod]
        public void StringIntv_CountAndSayTest3()
        {
            Assert.AreEqual("11", CountAndSay(2));
        }

        [TestMethod]
        public void StringIntv_CountAndSayTest4()
        {
            Assert.AreEqual("21", CountAndSay(3));
        }

        [TestMethod]
        public void StringIntv_CountAndSayTest5()
        {
            Assert.AreEqual("1211", CountAndSay(4));
        }
    };
}