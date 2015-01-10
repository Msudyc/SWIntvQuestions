using System;
using System.Collections.Generic;
using Microsoft.VisualStudio.TestTools.UnitTesting;

namespace ACMPrep
{
    public partial class StringIntv
    {
        [TestMethod]
        public void StringIntv_LongestCommonPrefixTest1()
        {
            List<string> t = new List<string>();
            t.Add("aab");
            t.Add("aabd");
            t.Add("aabe");
            Assert.AreEqual("aab", LongestCommonPrefix(t));
        }

        [TestMethod]
        public void StringIntv_LongestCommonPrefixTest2()
        {
            List<string> t = new List<string>();
            Assert.AreEqual("", LongestCommonPrefix(t));
        }

        [TestMethod]
        public void StringIntv_LongestCommonPrefixTest3()
        {
            List<string> t = new List<string>();
            t.Add("aab");
            Assert.AreEqual("aab", LongestCommonPrefix(t));
        }

        [TestMethod]
        public void StringIntv_LongestCommonPrefixTest4()
        {
            List<string> t = new List<string>();
            t.Add("a");
            t.Add("b");
            t.Add("aabe");
            Assert.AreEqual("", LongestCommonPrefix(t));
        }

        [TestMethod]
        public void StringIntv_LongestCommonPrefixTest5()
        {
            List<string> t = new List<string>();
            t.Add("aa");
            t.Add("ab");
            t.Add("aabe");
            Assert.AreEqual("a", LongestCommonPrefix(t));
        }

        [TestMethod]
        public void StringIntv_LongestCommonPrefixTest6()
        {
            List<string> t = new List<string>();
            t.Add("aaa");
            t.Add("aabe");
            t.Add("a");            
            Assert.AreEqual("a", LongestCommonPrefix(t));
        }
    }
}