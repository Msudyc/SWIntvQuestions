using System;
using System.Collections.Generic;
using Microsoft.VisualStudio.TestTools.UnitTesting;

namespace ACMPrep
{
    public partial class Backtracking
    {
        [TestMethod]
        public void Backtracking_ExistTest1()
        {
            char[,] t = { { 'A', 'B', 'C', 'E' }, 
                          { 'S', 'F', 'C', 'S' }, 
                          { 'A', 'D', 'E', 'E' } };
            Assert.IsTrue(Exist(t, "ABCCED"));
        }

        [TestMethod]
        public void Backtracking_ExistTest2()
        {
            char[,] t = { { 'A', 'B', 'C', 'E' }, 
                          { 'S', 'F', 'C', 'S' }, 
                          { 'A', 'D', 'E', 'E' } };
            Assert.IsTrue(Exist(t, "ABC"));
        }

        [TestMethod]
        public void Backtracking_ExistTest3()
        {
            char[,] t = { { 'A', 'B', 'C', 'E' }, 
                          { 'S', 'F', 'C', 'S' }, 
                          { 'A', 'D', 'E', 'E' } };
            Assert.IsFalse(Exist(t, "ABCB"));
        }

        [TestMethod]
        public void Backtracking_ExistTest4()
        {
            char[,] t = { { 'A', 'B', 'C', 'E' }, 
                          { 'S', 'F', 'C', 'S' }, 
                          { 'A', 'D', 'E', 'E' } };
            Assert.IsFalse(Exist(t, "XYCZ"));
        }
    };
}