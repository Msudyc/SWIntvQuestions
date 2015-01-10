using System;
using System.Collections.Generic;
using Microsoft.VisualStudio.TestTools.UnitTesting;

namespace ACMPrep
{
    public partial class Greedy
    {
        [TestMethod]
        public void Greedy_JumpTest1()
        {
            int[] A = {2,3,1,1,4};
            Assert.AreEqual(2, Jump(A));
        }

        [TestMethod]
        public void Greedy_JumpTest2()
        {
            int[] A = {1,1,1,1,1};
            Assert.AreEqual(4, Jump(A));
        }

        [TestMethod]
        public void Greedy_JumpTest3()
        {
            int[] A = {6,3,1,1,4};
            Assert.AreEqual(1, Jump(A));
        }

        [TestMethod]
        public void Greedy_JumpTest4()
        {
            int[] A = {2,1,1,1,4};
            Assert.AreEqual(3, Jump(A));
        }
    };
}