using System;
using System.Collections.Generic;
using Microsoft.VisualStudio.TestTools.UnitTesting;

namespace ACMPrep
{
    public partial class StringIntv
    {
        [TestMethod]
        public void StringIntv_StrStrTest1()
        {
            string s = "abcdefghijklmopq";
            string t = "jkl";
            Assert.AreEqual("jklmopq", StrStr(s, t));
        }

        [TestMethod]
        public void StringIntv_StrStrTest2()
        {
            string s = "";
            string t = "";
            Assert.AreEqual("", StrStr(s, t));
        }

        [TestMethod]
        public void StringIntv_StrStrTest3()
        {
            string s = "abcdefghaabmopq";
            string t = "aab";
            Assert.AreEqual("aabmopq", StrStr(s, t));
        }

        [TestMethod]
        public void StringIntv_StrStrTest4()
        {
            string s = "abcdefghaabmopq";
            string t = "bab";
            Assert.IsNull(StrStr(s, t));
        }
    };
}