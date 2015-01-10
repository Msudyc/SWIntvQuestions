using System;
using System.Collections.Generic;
using Microsoft.VisualStudio.TestTools.UnitTesting;

namespace ACMPrep
{
    public partial class DynamicProgramming
    {
        [TestMethod]
        public void DynamicProgramming_WordBreakIITest1()
        {
            HashSet<string> dict = new HashSet<string>();
            dict.Add("cat"); 
            dict.Add("cats");
            dict.Add("and"); 
            dict.Add("sand");
            dict.Add("dog");
            List<string> r = WordBreakII("catsanddog", dict);
            Assert.AreEqual(2, r.Count);
            Assert.IsTrue(r.Contains("cat sand dog"));
            Assert.IsTrue(r.Contains("cats and dog"));
        }
    };
}