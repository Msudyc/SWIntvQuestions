using System;
using Microsoft.VisualStudio.TestTools.UnitTesting;

namespace FB
{
    public partial class FBEx
    {
        [TestMethod]
        public void FB_SearchRotatedTest1()
        {
            int[] t = {4,5,6,7,0,1,2};
            Assert.AreEqual(5, Search(t, 1));
        }

        [TestMethod]
        public void FB_SearchRotatedTest2()
        {
            int[] t = {4,5,6,7,0,1,2};
            Assert.AreEqual(-1, Search(t, 9));
        }

        [TestMethod]
        public void FB_SearchRotatedTest3()
        {
            int[] t = {4};
            Assert.AreEqual(-1, Search(t, 9));
        }

        [TestMethod]
        public void FB_SearchRotatedTest4()
        {
            int[] t = {0};
            Assert.AreEqual(-1, Search(t, 9));
        }
    };
}