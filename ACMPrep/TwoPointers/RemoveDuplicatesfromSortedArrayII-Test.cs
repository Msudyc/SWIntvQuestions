using System;
using System.Collections.Generic;
using Microsoft.VisualStudio.TestTools.UnitTesting;

namespace ACMPrep
{
    public partial class TwoPointers
    {
        [TestMethod]
        public void TwoPointers_RemoveDuplicatesTest1()
        {
            int[] t = {1,1,1,2,2,3};
            Assert.AreEqual(5, RemoveDuplicates(t));
        }

        [TestMethod]
        public void TwoPointers_RemoveDuplicatesTest2()
        {
            int[] t = {1,1,2,2,3};
            Assert.AreEqual(5, RemoveDuplicates(t));
        }

        [TestMethod]
        public void TwoPointers_RemoveDuplicatesTest3()
        {
            int[] t = {1,1,1,1,1,1,2,2,3};
            Assert.AreEqual(5, RemoveDuplicates(t));
        }

        [TestMethod]
        public void TwoPointers_RemoveDuplicatesTest4()
        {
            int[] t = {1,2,3};
            Assert.AreEqual(3, RemoveDuplicates(t));
        }

        [TestMethod]
        public void TwoPointers_RemoveDuplicatesTest5()
        {
            int[] t = { 1, 1, 1, 2, 2, 3 };
            Assert.AreEqual(5, RemoveDuplicates2(t));
        }

        [TestMethod]
        public void TwoPointers_RemoveDuplicatesTest6()
        {
            int[] t = { 1, 1, 2, 2, 3 };
            Assert.AreEqual(5, RemoveDuplicates2(t));
        }

        [TestMethod]
        public void TwoPointers_RemoveDuplicatesTest7()
        {
            int[] t = { 1, 1, 1, 1, 1, 1, 2, 2, 3 };
            Assert.AreEqual(5, RemoveDuplicates2(t));
        }

        [TestMethod]
        public void TwoPointers_RemoveDuplicatesTest8()
        {
            int[] t = { 1, 2, 3 };
            Assert.AreEqual(3, RemoveDuplicates2(t));
        }
    };
}