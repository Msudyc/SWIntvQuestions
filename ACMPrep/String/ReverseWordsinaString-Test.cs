using System;
using System.Collections.Generic;
using Microsoft.VisualStudio.TestTools.UnitTesting;

namespace ACMPrep
{
    public partial class StringIntv
    {
        [TestMethod]
        public void StringIntv_ReverseWordsTest1()
        {
            string s = "the sky is blue";
            string es = "blue is sky the";
            Assert.AreEqual(es, ReverseWords(s));
        }

        [TestMethod]
        public void StringIntv_ReverseWordsTest2()
        {
            string s = "a";
            string es = "a";
            Assert.AreEqual(es, ReverseWords(s));
        }
    };
}