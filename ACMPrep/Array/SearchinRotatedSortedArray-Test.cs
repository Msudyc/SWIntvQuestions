using System;
using System.Collections.Generic;
using Microsoft.VisualStudio.TestTools.UnitTesting;

namespace ACMPrep
{
    public partial class ArrayIntv
    {
        [TestMethod]
        public void ArrayIntv_SearchTest1()
        {
            int[] t = {4,5,6,7,0,1,2};
            Assert.AreEqual(5, Search(t, 1));
        }

        [TestMethod]
        public void ArrayIntv_SearchTest2()
        {
            int[] t = {4,5,6,7,0,1,2};
            Assert.AreEqual(-1, Search(t, 9));
        }

        [TestMethod]
        public void ArrayIntv_SearchTest3()
        {
            int[] t = {4};
            Assert.AreEqual(-1, Search(t, 9));
        }

        [TestMethod]
        public void ArrayIntv_SearchTest4()
        {
            int[] t = {0};
            Assert.AreEqual(-1, Search(t, 9));
        }
    };
}