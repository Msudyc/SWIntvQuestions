using System;
using System.Collections.Generic;
using Microsoft.VisualStudio.TestTools.UnitTesting;

namespace ACMPrep
{
    public partial class StringIntv
    {
        [TestMethod]
        public void StringIntv_FullJustifyTest1()
        {
            List<string> t = new List<string>();
            t.Add("this");
            t.Add("is");
            t.Add("a");
            t.Add("very");
            t.Add("good");
            t.Add("example");
            t.Add("of");
            t.Add("test");
            List<string> r = FullJustify(t, 10);
            Assert.AreEqual(4, r.Count);
        }

        [TestMethod]
        public void StringIntv_FullJustifyTest2()
        {
            List<string> t = new List<string>();
            t.Add("this");
            t.Add("is");
            t.Add("a");
            t.Add("very");
            t.Add("good");
            t.Add("example");
            t.Add("of");
            t.Add("justification");
            t.Add("you");
            t.Add("can");
            t.Add("see");
            List<string> r = FullJustify(t, 10);
            Assert.AreEqual(6, r.Count);
        }

        [TestMethod]
        public void StringIntv_FullJustifyTest3()
        {
            List<string> t = new List<string>();
            t.Add("this");
            t.Add("is");
            t.Add("an");
            t.Add("example");
            List<string> r = FullJustify(t, 10);
            Assert.AreEqual(2, r.Count);
        }
    };
}