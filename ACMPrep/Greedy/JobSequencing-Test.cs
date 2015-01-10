using System;
using System.Collections.Generic;
using Microsoft.VisualStudio.TestTools.UnitTesting;

namespace ACMPrep
{
    public partial class Greedy
    {
        [TestMethod]
        public void Greedy_MaxProfitTest1()
        {
            List<Job> jobs = new List<Job>();
            jobs.Add(new Job('a', 4, 20));
            jobs.Add(new Job('b', 1, 10));
            jobs.Add(new Job('c', 1, 40));
            jobs.Add(new Job('d', 1, 30));
            List<char> result = MaxProfit(jobs);
            Assert.AreEqual('c', result[0]);
            Assert.AreEqual('a', result[1]);
        }

        [TestMethod]
        public void Greedy_MaxProfitTest2()
        {
            List<Job> jobs = new List<Job>();
            jobs.Add(new Job('a', 2, 100));
            jobs.Add(new Job('b', 1, 19));
            jobs.Add(new Job('c', 2, 27));
            jobs.Add(new Job('d', 1, 25));
            jobs.Add(new Job('e', 3, 15));
            List<char> result = MaxProfit(jobs);
            Assert.AreEqual('c', result[0]);
            Assert.AreEqual('a', result[1]);
            Assert.AreEqual('e', result[2]);
        }
    }
}
