using System;
using System.Collections.Generic;
using Microsoft.VisualStudio.TestTools.UnitTesting;

namespace ACMPrep
{
    public partial class LinkedListIntv
    {
        [TestMethod]
        public void LinkedListIntv_InsertionSortListTest1()
        {
            ListNode l0 = new ListNode(3), 
                l1 = new ListNode(1), 
                l2 = new ListNode(4), 
                l3 = new ListNode(2), 
                l4 = new ListNode(0);
            l0.Next = l1; 
            l1.Next = l2; 
            l2.Next = l3; 
            l3.Next = l4;
            ListNode r = InsertionSortList(l0);
            Assert.AreEqual(0, r.Val); 
            r = r.Next;
            Assert.AreEqual(1, r.Val); 
            r = r.Next;
            Assert.AreEqual(2, r.Val); 
            r = r.Next;
            Assert.AreEqual(3, r.Val); 
            r = r.Next;
            Assert.AreEqual(4, r.Val); 
            r = r.Next;
        }

        [TestMethod]
        public void LinkedListIntv_InsertionSortListTest2()
        {
            ListNode l0 = new ListNode(3), 
                l1 = new ListNode(1);
            l0.Next = l1;
            ListNode r = InsertionSortList(l0);
            Assert.AreEqual(1, r.Val); 
            r = r.Next;
            Assert.AreEqual(3, r.Val); 
            r = r.Next;
        }

        [TestMethod]
        public void LinkedListIntv_InsertionSortListTest3()
        {
            ListNode l0 = new ListNode(3);
            ListNode r = InsertionSortList(l0);
            Assert.AreEqual(3, r.Val); 
            r = r.Next;
        }
    };
}