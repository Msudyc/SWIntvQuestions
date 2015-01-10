using System;
using System.Collections.Generic;
using Microsoft.VisualStudio.TestTools.UnitTesting;

namespace ACMPrep
{
    public partial class DetailImpl
    {
        [TestMethod]
        public void DetailImpl_MergeTest1()
        {
            List<Interval> t = new List<Interval>();
            t.Add(new Interval(0, 2));
            t.Add(new Interval(1, 4));
            t.Add(new Interval(5, 7));
            List<Interval> r = Merge(t);
            Assert.AreEqual(2, r.Count);
        }

        [TestMethod]
        public void DetailImpl_MergeTest2()
        {
            List<Interval> t = new List<Interval>();
            t.Add(new Interval(0, 2));
            List<Interval> r = Merge(t);
            Assert.AreEqual(1, r.Count);
        }

        [TestMethod]
        public void DetailImpl_MergeTest3()
        {
            List<Interval> t = new List<Interval>();
            t.Add(new Interval(0, 2));
            t.Add(new Interval(1, 4));
            t.Add(new Interval(4, 7));
            List<Interval> r = Merge(t);
            Assert.AreEqual(1, r.Count);
        }

        [TestMethod]
        public void DetailImpl_MergeTest4()
        {
            List<Interval> t = new List<Interval>();
            t.Add(new Interval(0, 2));
            t.Add(new Interval(1, 4));
            t.Add(new Interval(5, 7));
            List<Interval> r = Merge2(t);
            Assert.AreEqual(2, r.Count);
        }

        [TestMethod]
        public void DetailImpl_MergeTest5()
        {
            List<Interval> t = new List<Interval>();
            t.Add(new Interval(0, 2));
            List<Interval> r = Merge2(t);
            Assert.AreEqual(1, r.Count);
        }

        [TestMethod]
        public void DetailImpl_MergeTest6()
        {
            List<Interval> t = new List<Interval>();
            t.Add(new Interval(0, 2));
            t.Add(new Interval(1, 4));
            t.Add(new Interval(4, 7));
            List<Interval> r = Merge2(t);
            Assert.AreEqual(1, r.Count);
        }
    };
}