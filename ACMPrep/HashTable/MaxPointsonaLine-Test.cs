using System;
using System.Collections.Generic;
using Microsoft.VisualStudio.TestTools.UnitTesting;

namespace ACMPrep
{
    public partial class HashTable
    {
        [TestMethod]
        public void HashTable_MaxPointsTest1()
        {
            List<Point> t = new List<Point>();
            t.Add(new Point(1, 1)); 
            t.Add(new Point(1, 2));
            t.Add(new Point(2, 2)); 
            t.Add(new Point(2, 3));
            t.Add(new Point(3, 3)); 
            t.Add(new Point(3, 4));
            t.Add(new Point(4, 4)); 
            t.Add(new Point(4, 5));
            Assert.AreEqual(4, MaxPoints(t));
        }

        [TestMethod]
        public void HashTable_MaxPointsTest2()
        {
            List<Point> t = new List<Point>();
            t.Add(new Point(1, 1)); 
            t.Add(new Point(2, 2));
            t.Add(new Point(3, 3)); 
            t.Add(new Point(4, 4));
            Assert.AreEqual(4, MaxPoints(t));
        }
    };
}