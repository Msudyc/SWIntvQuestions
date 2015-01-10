using System;
using System.Collections.Generic;
using Microsoft.VisualStudio.TestTools.UnitTesting;

namespace ACMPrep
{
    public partial class StringIntv
    {
        [TestMethod]
        public void StringIntv_LengthOfLastWordTest1()
        {
            Assert.AreEqual(5, LengthOfLastWord("abc aaaaa"));
        }

        [TestMethod]
        public void StringIntv_LengthOfLastWordTest2()
        {
            Assert.AreEqual(3, LengthOfLastWord(" abc"));
        }

        [TestMethod]
        public void StringIntv_LengthOfLastWordTest3()
        {
            Assert.AreEqual(1, LengthOfLastWord(" abc ss vv a "));
        }

        [TestMethod]
        public void StringIntv_LengthOfLastWordTest4()
        {
            Assert.AreEqual(5, LengthOfLastWord2("abc aaaaa"));
        }

        [TestMethod]
        public void StringIntv_LengthOfLastWordTest5()
        {
            Assert.AreEqual(3, LengthOfLastWord2(" abc"));
        }

        [TestMethod]
        public void StringIntv_LengthOfLastWordTest6()
        {
            Assert.AreEqual(1, LengthOfLastWord2(" abc ss vv a "));
        }
    };
}