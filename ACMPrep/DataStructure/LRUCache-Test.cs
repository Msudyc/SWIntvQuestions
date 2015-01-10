using System;
using System.Collections.Generic;
using Microsoft.VisualStudio.TestTools.UnitTesting;

namespace ACMPrep
{
    public partial class DataStructure
    {
        [TestMethod]
        public void DataStructure_LRUCacheTest1()
        {
            Ex146LRUCache ex = new Ex146LRUCache(3);
            ex.Set(1, 101);
            ex.Set(2, 103);
            ex.Set(3, 103);
            Assert.AreEqual(101, ex.Get(1));
            ex.Set(4, 104);
            ex.Set(5, 105);
            Assert.AreEqual(-1, ex.Get(2));
        }
    };
}