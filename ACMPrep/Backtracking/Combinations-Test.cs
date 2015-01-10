using System;
using System.Collections.Generic;
using Microsoft.VisualStudio.TestTools.UnitTesting;

namespace ACMPrep
{
    [TestClass]
    public partial class Backtracking
    {
        [TestMethod]
        public void Backtracking_CombineTest1()
        {
            List<List<int>> ret = Combine(4, 2);
            Assert.AreEqual(6, ret.Count);
        }

        [TestMethod]
        public void Backtracking_CombineTest2()
        {
            List<List<int>> ret = Combine(2, 2);
            Assert.AreEqual(1, ret.Count);
        }

        [TestMethod]
        public void Backtracking_CombineTest3()
        {
            List<List<int>> ret = Combine(5, 2);
            Assert.AreEqual(10, ret.Count);
        }

        [TestMethod]
        public void Backtracking_CombineTest4()
        {
            List<List<int>> ret = Combine(7, 2);
            Assert.AreEqual(21, ret.Count);
        }

        [TestMethod]
        public void Backtracking_CombineTest5()
        {
            List<List<int>> ret = CombineDFS(4, 2);
            Assert.AreEqual(6, ret.Count);
        }

        [TestMethod]
        public void Backtracking_CombineTest6()
        {
            List<List<int>> ret = CombineDFS(2, 2);
            Assert.AreEqual(1, ret.Count);
        }

        [TestMethod]
        public void Backtracking_CombineTest7()
        {
            List<List<int>> ret = CombineDFS(5, 2);
            Assert.AreEqual(10, ret.Count);
        }

        [TestMethod]
        public void Backtracking_CombineTest8()
        {
            List<List<int>> ret = CombineDFS(7, 2);
            Assert.AreEqual(21, ret.Count);
        }
    };
}