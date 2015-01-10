using System;
using System.Collections.Generic;
using Microsoft.VisualStudio.TestTools.UnitTesting;

namespace ACMPrep
{
    public partial class StringIntv
    {
        [TestMethod]
        public void StringIntv_MultiplyTest1()
        {
            Assert.AreEqual("56088", Multiply("123", "456"));
        }

        [TestMethod]
        public void StringIntv_MultiplyTest2()
        {
            Assert.AreEqual("0", Multiply("0", "45623456432"));
        }

        [TestMethod]
        public void StringIntv_MultiplyTest3()
        {
            Assert.AreEqual("55597647977088", Multiply("1232123", "45123456"));
        }
    };
}