using System;
using System.Collections.Generic;
using Microsoft.VisualStudio.TestTools.UnitTesting;

namespace ACMPrep
{
    [TestClass]
    public partial class BreadthFirstSearch
    {
        [TestMethod]
        public void BreadthFirstSearch_SolveTest1()
        {
            char[,] t = {{'X', 'X', 'X', 'X'},
                         {'X', 'O', 'O', 'X'},
                         {'X', 'X', 'O', 'X'},
                         {'X', 'O', 'X', 'X'}};
            Solve(t);
            Assert.AreEqual('X', t[1, 1]);
            Assert.AreEqual('X', t[1, 2]);
            Assert.AreEqual('X', t[2, 2]);
            Assert.AreEqual('O', t[3, 1]);
        }

        [TestMethod]
        public void BreadthFirstSearch_SolveTest2()
        {
            char[,] t = {{'X', 'O', 'X', 'X'},
                         {'X', 'O', 'O', 'X'},
                         {'X', 'X', 'O', 'X'},
                         {'X', 'O', 'X', 'X'}};
            Solve(t);
            Assert.AreEqual('O', t[0, 1]);
            Assert.AreEqual('O', t[1, 1]);
            Assert.AreEqual('O', t[1, 2]);
            Assert.AreEqual('O', t[2, 2]);
            Assert.AreEqual('O', t[3, 1]);
        }
    };
}