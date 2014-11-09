using System;
using Microsoft.VisualStudio.TestTools.UnitTesting;

namespace ACMPrep
{
    public partial class Sort
    {
        [TestMethod]
        public void Sort_SelectionSortTest1()
        {
            int[] test = { 4, 3, 1, 7, 6 };
            SelectionSort(test);
            Assert.AreEqual(1, test[0]);
            Assert.AreEqual(3, test[1]);
            Assert.AreEqual(4, test[2]);
            Assert.AreEqual(6, test[3]);
            Assert.AreEqual(7, test[4]);
        }

        [TestMethod]
        public void Sort_SelectionSortTest2()
        {
            int[] test = { 1, 3, 4, 6, 7 };
            SelectionSort(test);
            Assert.AreEqual(1, test[0]);
            Assert.AreEqual(3, test[1]);
            Assert.AreEqual(4, test[2]);
            Assert.AreEqual(6, test[3]);
            Assert.AreEqual(7, test[4]);
        }

        [TestMethod]
        public void Sort_SelectionSortTest3()
        {
            int[] test = { 7, 6, 4, 3, 1 };
            SelectionSort(test);
            Assert.AreEqual(1, test[0]);
            Assert.AreEqual(3, test[1]);
            Assert.AreEqual(4, test[2]);
            Assert.AreEqual(6, test[3]);
            Assert.AreEqual(7, test[4]);
        }
    }
}
