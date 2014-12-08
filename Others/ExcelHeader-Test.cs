using System;
using System.Collections.Generic;
using Microsoft.VisualStudio.TestTools.UnitTesting;

namespace OTHR
{
    [TestClass]
    public partial class OTHREx
    {
        [TestMethod]
        public void OTHR_GetHeaderTest1()
        {
            Assert.AreEqual("BC", GetHeader(8));
        }

        [TestMethod]
        public void OTHR_GetHeaderTest2()
        {
            Assert.AreEqual("BAB", GetHeader(22));
        }

        [TestMethod]
        public void OTHR_GetHeaderTest3()
        {
            Assert.AreEqual("B", GetHeader(1));
        }

        [TestMethod]
        public void OTHR_GetHeaderTest4()
        {
            Assert.AreEqual("AAAAA", GetHeader(120));
        }
    }
}
