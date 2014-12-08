using System;
using System.Collections.Generic;
using Microsoft.VisualStudio.TestTools.UnitTesting;

namespace OTHR
{
    public partial class OTHREx
    {
        [TestMethod]
        public void OTHR_MyIteratorTest1()
        {
            int[] array = { 1, 2, 4, 5, 7, 8, 6 };
            ArrayIterator i = new ArrayIterator(array);
            MyIterator myIterator = new MyIterator(i, i.IsEven);

            Assert.IsTrue(myIterator.HasNext());
            Assert.IsTrue(myIterator.HasNext());

            Assert.AreEqual(2, myIterator.Next());
            Assert.IsTrue(myIterator.HasNext());

            Assert.AreEqual(4, myIterator.Next());
            Assert.IsTrue(myIterator.HasNext());

            Assert.AreEqual(8, myIterator.Next());
            Assert.IsTrue(myIterator.HasNext());

            Assert.AreEqual(6, myIterator.Next());
            Assert.IsFalse(myIterator.HasNext());
        }

        [TestMethod]
        public void OTHR_MyIteratorTest2()
        {
            int[] array = { 1, 3, 5, 5, 7, 9, 7 };
            ArrayIterator i = new ArrayIterator(array);
            MyIterator myIterator = new MyIterator(i, i.IsEven);

            Assert.IsFalse(myIterator.HasNext());
        }
    }
}
