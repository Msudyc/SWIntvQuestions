using System;
using System.Collections.Generic;
using Microsoft.VisualStudio.TestTools.UnitTesting;

namespace ACMPrep
{
    public partial class BreadthFirstSearch
    {
        [TestMethod]
        public void BreadthFirstSearch_LadderLengthTest1()
        {
            HashSet<string> dict = new HashSet<string>();
            dict.Add("hot"); 
            dict.Add("dot"); 
            dict.Add("dog");
            dict.Add("lot"); 
            dict.Add("log");
            Assert.AreEqual(5, LadderLength("hit", "cog", dict));
        }

        [TestMethod]
        public void BreadthFirstSearch_LadderLengthTest2()
        {
            HashSet<string> dict = new HashSet<string>();
            dict.Add("hot"); 
            dict.Add("dot"); 
            dict.Add("dog");
            dict.Add("lot"); 
            dict.Add("log");
            Assert.AreEqual(2, LadderLength("hit", "hit", dict));
        }

        [TestMethod]
        public void BreadthFirstSearch_LadderLengthTest3()
        {
            HashSet<string> dict = new HashSet<string>();
            dict.Add("hot"); 
            dict.Add("dot"); 
            dict.Add("dog");
            dict.Add("lot"); 
            dict.Add("log");
            Assert.AreEqual(2, LadderLength("hit", "hot", dict));
        }
    };
}