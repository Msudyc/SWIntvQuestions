using System;
using System.Collections.Generic;
using Microsoft.VisualStudio.TestTools.UnitTesting;

namespace ACMPrep
{
    [TestClass]
    public partial class HashTable
    {
        [TestMethod]
        public void HashTable_AnagramsTest1()
        {
            List<string> t = new List<string>();
            t.Add("abcd");
            t.Add("dcbd");
            t.Add("dcba");
            t.Add("fcba");
            List<string> r = Anagrams(t);
            Assert.AreEqual(2, r.Count);
        }

        [TestMethod]
        public void HashTable_AnagramsTest2()
        {
            List<string> t = new List<string>();
            t.Add("abc");
            t.Add("cba");
            t.Add("ad");
            t.Add("da");
            t.Add("dac");
            List<string> r = Anagrams(t);
            Assert.AreEqual(4, r.Count);
        }
    };
}