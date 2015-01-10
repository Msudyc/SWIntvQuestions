using System;
using System.Collections.Generic;
using Microsoft.VisualStudio.TestTools.UnitTesting;

namespace ACMPrep
{
    public partial class HashTable
    {
        [TestMethod]
        public void HashTable_FindSubstringTest1()
        {
            List<string> s = new List<string>();
            s.Add("bar");
            s.Add("foo");
            List<int> r = FindSubstring("barfoothefoobarman", s);
            Assert.AreEqual(0, r[0]);
            Assert.AreEqual(9, r[1]);

            s.Clear();
            r.Clear();
            s.Add("a");
            s.Add("a");
            r = FindSubstring("aaa", s);
            Assert.AreEqual(0, r[0]);
            Assert.AreEqual(1, r[1]);

            s.Clear();
            r.Clear();
            s.Add("a");
            s.Add("a");
            s.Add("b");
            r = FindSubstring("abababab", s);
            Assert.AreEqual(0, r[0]);
            Assert.AreEqual(2, r[1]);
            Assert.AreEqual(4, r[2]);
        }
    };
}