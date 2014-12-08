using System;
using System.Collections.Generic;
using Microsoft.VisualStudio.TestTools.UnitTesting;

namespace FB
{
    public partial class FBEx
    {
        [TestMethod]
        public void FB_SortByStringTest1()
        {
            List<string> test = new List<string>();
            test.Add("face");
            test.Add("ball");
            test.Add("apple");
            test.Add("art");
            test.Add("ah");
            test.Add("artk");
            SortByString(test, "badpchlerf");
            Assert.AreEqual("ball", test[0]);
            Assert.AreEqual("apple", test[1]);
            Assert.AreEqual("ah", test[2]);
            Assert.AreEqual("art", test[3]);
            Assert.AreEqual("artk", test[4]);
            Assert.AreEqual("face", test[5]);
        }
    }
}
