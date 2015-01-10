using System;
using System.Collections.Generic;
using Microsoft.VisualStudio.TestTools.UnitTesting;

namespace ACMPrep
{
    public partial class ArrayIntv
    {
        [TestMethod]
        public void ArrayIntv_RemoveDuplicatesTest1()
        {
            int[] t = {1, 1, 2};
            Assert.AreEqual(2, RemoveDuplicates(t, 3));
            Assert.AreEqual(1, t[0]);
            Assert.AreEqual(2, t[1]);
        }

        [TestMethod]
        public void ArrayIntv_RemoveDuplicatesTest2()
        {
            int[] t = {1, 2, 2, 3, 4, 5, 6, 6, 6};
            Assert.AreEqual(6, RemoveDuplicates(t, 9));
            Assert.AreEqual(1, t[0]);
            Assert.AreEqual(2, t[1]);
            Assert.AreEqual(3, t[2]);
            Assert.AreEqual(4, t[3]);
            Assert.AreEqual(5, t[4]);
            Assert.AreEqual(6, t[5]);
        }

        [TestMethod]
        public void ArrayIntv_RemoveDuplicatesTest3()
        {
            int[] t = {1};
            Assert.AreEqual(1, RemoveDuplicates(t, 1));
            Assert.AreEqual(1, t[0]);
        }

        [TestMethod]
        public void ArrayIntv_RemoveDuplicatesTest4()
        {
            int[] t = {1, 2};
            Assert.AreEqual(2, RemoveDuplicates(t, 2));
            Assert.AreEqual(1, t[0]);
            Assert.AreEqual(2, t[1]);
        }

        [TestMethod]
        public void ArrayIntv_RemoveDuplicatesTest5()
        {
            int[] t = {1, 1};
            Assert.AreEqual(1, RemoveDuplicates(t, 2));
            Assert.AreEqual(1, t[0]);
        }
    };
}