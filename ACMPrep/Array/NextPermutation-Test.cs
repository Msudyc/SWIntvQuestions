using System;
using System.Collections.Generic;
using Microsoft.VisualStudio.TestTools.UnitTesting;

namespace ACMPrep
{
    public partial class ArrayIntv
    {
        [TestMethod]
        public void ArrayIntv_NextPermutationTest1()
        {
            List<int> t = new List<int>();
            t.Add(1); t.Add(2); t.Add(3);
            nextPermutation(t);
            Assert.AreEqual(1, t[0]);
            Assert.AreEqual(3, t[1]);
            Assert.AreEqual(2, t[2]);
        }

        [TestMethod]
        public void ArrayIntv_NextPermutationTest2()
        {
            List<int> t = new List<int>();
            t.Add(3); t.Add(2); t.Add(1);
            nextPermutation(t);
            Assert.AreEqual(1, t[0]);
            Assert.AreEqual(2, t[1]);
            Assert.AreEqual(3, t[2]);
        }

        [TestMethod]
        public void ArrayIntv_NextPermutationTest3()
        {
            List<int> t = new List<int>();
            t.Add(1); t.Add(1); t.Add(5);
            nextPermutation(t);
            Assert.AreEqual(1, t[0]);
            Assert.AreEqual(5, t[1]);
            Assert.AreEqual(1, t[2]);
        }
    };
}