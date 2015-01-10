using System;
using System.Collections.Generic;
using Microsoft.VisualStudio.TestTools.UnitTesting;

namespace ACMPrep
{
    public partial class DataStructure
    {
        [TestMethod]
        public void DataStructure_TwoSumTest1()
        {
            TwoSum test = new TwoSum();
            test.Add(2);
            test.Add(3);
            test.Add(1);
            test.Add(6);
            Assert.IsTrue(test.Find(5));
            Assert.IsFalse(test.Find(20));
        }
    };
}