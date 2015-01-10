using System;
using System.Collections.Generic;
using Microsoft.VisualStudio.TestTools.UnitTesting;

namespace ACMPrep
{
    [TestClass]
    public partial class DetailImpl
    {
        [TestMethod]
        public void DetailImpl_InsertTest1()
        {
            List<Interval> t = new List<Interval>();
            t.Add(new Interval(0, 2));
            t.Add(new Interval(1, 4));
            t.Add(new Interval(5, 7));
            List<Interval> r = Insert(t, new Interval(1, 6));
            Assert.AreEqual(1, r.Count);
        }

        [TestMethod]
        public void DetailImpl_InsertTest2()
        {
            List<Interval> t = new List<Interval>();
            t.Add(new Interval(0, 1));
            t.Add(new Interval(2, 4));
            t.Add(new Interval(7, 9));
            List<Interval> r = Insert(t, new Interval(3, 7));
            Assert.AreEqual(2, r.Count);
        }
    };
}