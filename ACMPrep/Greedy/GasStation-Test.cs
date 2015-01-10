using System;
using System.Collections.Generic;
using Microsoft.VisualStudio.TestTools.UnitTesting;

namespace ACMPrep
{
    public partial class Greedy
    {
        [TestMethod]
        public void Greedy_CanCompleteCircuitTest1()
        {
            int[] gas = { 1, 2, 1, 5 };
            int[] cost = { 1, 2, 2, 2 };
            Assert.AreEqual(3, CanCompleteCircuit(gas, cost));
        }

        [TestMethod]
        public void Greedy_CanCompleteCircuitTest2()
        {
            int[] gas = { 5, 2, 1, 1 };
            int[] cost = { 1, 2, 2, 2 };
            Assert.AreEqual(0, CanCompleteCircuit(gas, cost));
        }

        [TestMethod]
        public void Greedy_CanCompleteCircuitTest3()
        {
            int[] gas = { 1, 4, 1, 2 };
            int[] cost = { 1, 2, 2, 2 };
            Assert.AreEqual(0, CanCompleteCircuit(gas, cost));
        }

        [TestMethod]
        public void Greedy_CanCompleteCircuitTest4()
        {
            int[] gas = { 1, 2, 1, 2 };
            int[] cost = { 1, 2, 2, 2 };
            Assert.AreEqual(-1, CanCompleteCircuit(gas, cost));
        }
    };
}