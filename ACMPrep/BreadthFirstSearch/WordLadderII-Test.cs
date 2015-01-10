using System;
using System.Collections.Generic;
using Microsoft.VisualStudio.TestTools.UnitTesting;

namespace ACMPrep
{
    public partial class BreadthFirstSearch
    {
        [TestMethod]
        public void BreadthFirstSearch_FindLaddersTest1()
        {
            HashSet<string> dict = new HashSet<string>();
            dict.Add("hot"); 
            dict.Add("dot"); 
            dict.Add("dog");
            dict.Add("lot"); 
            dict.Add("log");
            List<List<string>> res = FindLadders("hit", "cog", dict);
            Assert.AreEqual(2, res.Count);
        }

        [TestMethod]
        public void BreadthFirstSearch_FindLaddersTest2()
        {
            HashSet<string> dict = new HashSet<string>();
            dict.Add("hot"); 
            dict.Add("dot"); 
            dict.Add("dog");
            dict.Add("lot"); 
            dict.Add("log");
            List<List<string>> res = FindLadders("abc", "cog", dict);
            Assert.AreEqual(0, res.Count);
        }

        [TestMethod]
        public void BreadthFirstSearch_FindLaddersTest3()
        {
            HashSet<string> dict = new HashSet<string>();
            dict.Add("hot"); 
            dict.Add("dot"); 
            dict.Add("dog");
            dict.Add("lot"); 
            dict.Add("log");
            List<List<string>> res = FindLadders("cog", "cog", dict);
            Assert.AreEqual(1, res.Count);
        }
    };
}