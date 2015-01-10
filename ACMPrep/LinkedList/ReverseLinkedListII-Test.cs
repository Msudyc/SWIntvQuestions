using System;
using System.Collections.Generic;
using Microsoft.VisualStudio.TestTools.UnitTesting;

namespace ACMPrep
{
    public partial class LinkedListIntv
    {
        [TestMethod]
        public void LinkedListIntv_ReverseBetweenTest1()
        {
            ListNode l1 = new ListNode(1),
                l2 = new ListNode(2),
                l3 = new ListNode(3),
                l4 = new ListNode(4),
                l5 = new ListNode(5);
            l1.Next = l2;
            l2.Next = l3;
            l3.Next = l4;
            l4.Next = l5;
            ListNode r = ReverseBetween(l1, 2, 4);
            Assert.AreEqual(1, r.Val); r = r.Next;
            Assert.AreEqual(4, r.Val); r = r.Next;
            Assert.AreEqual(3, r.Val); r = r.Next;
            Assert.AreEqual(2, r.Val); r = r.Next;
            Assert.AreEqual(5, r.Val); r = r.Next;
            Assert.IsNull(r);
        }

        [TestMethod]
        public void LinkedListIntv_ReverseBetweenTest2()
        {
            ListNode l1 = new ListNode(1);
            ListNode r = ReverseBetween(l1, 1, 1);
            Assert.AreEqual(1, r.Val); r = r.Next;
            Assert.IsNull(r);
        }

        [TestMethod]
        public void LinkedListIntv_ReverseBetweenTest3()
        {
            ListNode l1 = new ListNode(1),
                l2 = new ListNode(2),
                l3 = new ListNode(3),
                l4 = new ListNode(4),
                l5 = new ListNode(5);
            l1.Next = l2;
            l2.Next = l3;
            l3.Next = l4;
            l4.Next = l5;
            ListNode r = ReverseBetween(l1, 1, 5);
            Assert.AreEqual(5, r.Val); r = r.Next;
            Assert.AreEqual(4, r.Val); r = r.Next;
            Assert.AreEqual(3, r.Val); r = r.Next;
            Assert.AreEqual(2, r.Val); r = r.Next;
            Assert.AreEqual(1, r.Val); r = r.Next;
            Assert.IsNull(r);
        }

        [TestMethod]
        public void LinkedListIntv_ReverseBetweenTest4()
        {
            ListNode l1 = new ListNode(1),
                l2 = new ListNode(2),
                l3 = new ListNode(3),
                l4 = new ListNode(4),
                l5 = new ListNode(5);
            l1.Next = l2;
            l2.Next = l3;
            l3.Next = l4;
            l4.Next = l5;
            ListNode r = ReverseBetween(l1, 5, 5);
            Assert.AreEqual(1, r.Val); r = r.Next;
            Assert.AreEqual(2, r.Val); r = r.Next;
            Assert.AreEqual(3, r.Val); r = r.Next;
            Assert.AreEqual(4, r.Val); r = r.Next;
            Assert.AreEqual(5, r.Val); r = r.Next;
            Assert.IsNull(r);
        }
    };
}