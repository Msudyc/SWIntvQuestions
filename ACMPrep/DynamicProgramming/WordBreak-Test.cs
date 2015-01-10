using System;
using System.Collections.Generic;
using Microsoft.VisualStudio.TestTools.UnitTesting;

namespace ACMPrep
{
    public partial class DynamicProgramming
    {
        [TestMethod]
        public void DynamicProgramming_WordBreakTest1()
        {
            HashSet<string> dict = new HashSet<string>();
            dict.Add("leet"); 
            dict.Add("code");
            Assert.IsTrue(WordBreak("leetcode", dict));
        }

        [TestMethod]
        public void DynamicProgramming_WordBreakTest2()
        {
            HashSet<string> dict = new HashSet<string>();
            dict.Add("leet"); 
            dict.Add("codeaa");
            Assert.IsFalse(WordBreak("leetcode", dict));
        }
    };
}