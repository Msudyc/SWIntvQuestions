using System;
using System.Collections.Generic;
using Microsoft.VisualStudio.TestTools.UnitTesting;

namespace TWT
{
    [TestClass]
    public partial class TWTEx
    {
        [TestMethod]
        public void TWT_SortPatternTest1()
        {
            GraphTWT graph = new GraphTWT();
            List<string> words = new List<string>();
            words.Add("foo");
            words.Add("cat");
            words.Add("cao");
            words.Add("bag");
            words.Add("bat");
            words.Add("aac");
            words.Add("gac");
            words.Add("tac");
            Assert.AreEqual("fcbagto", graph.SortPattern(words));
        }

        [TestMethod]
        public void TWT_SortPatternTest2()
        {
            GraphTWT graph = new GraphTWT();
            List<string> words = new List<string>();
            words.Add("foo");
            words.Add("cat");
            words.Add("cao");
            words.Add("bag");
            words.Add("bat");
            words.Add("aac");
            words.Add("gac");
            words.Add("tac");
            words.Add("cool");
            Assert.AreEqual("invalid", graph.SortPattern(words));
        }
    }
}
