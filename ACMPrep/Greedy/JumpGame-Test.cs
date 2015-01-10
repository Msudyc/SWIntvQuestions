using System;
using System.Collections.Generic;
using Microsoft.VisualStudio.TestTools.UnitTesting;

namespace ACMPrep
{
    public partial class Greedy
    {
        [TestMethod]
        public void Greedy_CanJumpTest1()
        {
            int[] A = {2,3,1,1,4};
            Assert.IsTrue(CanJump(A));

            int[] B = {3,2,1,0,4};
            Assert.IsFalse(CanJump(B));
        }

        [TestMethod]
        public void Greedy_CanJumpTest2()
        {
            int[] A = {2};
            Assert.IsTrue(CanJump(A));

            int[] B = {0,2,1,0,4};
            Assert.IsFalse(CanJump(B));
        }

        [TestMethod]
        public void Greedy_CanJumpTest3()
        {
            int[] A = { 2, 3, 1, 1, 4 };
            Assert.IsTrue(CanJump2(A));

            int[] B = { 3, 2, 1, 0, 4 };
            Assert.IsFalse(CanJump2(B));
        }

        [TestMethod]
        public void Greedy_CanJumpTest4()
        {
            int[] A = { 2 };
            Assert.IsTrue(CanJump2(A));

            int[] B = { 0, 2, 1, 0, 4 };
            Assert.IsFalse(CanJump2(B));
        }
    };
}