using System;
using System.Collections.Generic;
using Microsoft.VisualStudio.TestTools.UnitTesting;

namespace ACMPrep
{
    public partial class LinkedListIntv
    {
        [TestMethod]
        public void LinkedListIntv_DeleteDuplicatesTest1()
        {
            ListNode l1 = new ListNode(1), 
                l2 = new ListNode(2), 
                l3 = new ListNode(2), 
                l4 = new ListNode(4);
            l1.Next = l2; 
            l2.Next = l3; 
            l3.Next = l4;
            ListNode r = DeleteDuplicates(l1);
            Assert.AreEqual(1, r.Val); r = r.Next;
            Assert.AreEqual(2, r.Val); r = r.Next;
            Assert.AreEqual(4, r.Val); r = r.Next;
        }

        [TestMethod]
        public void LinkedListIntv_DeleteDuplicatesTest2()
        {
            ListNode l1 = new ListNode(1), 
                l2 = new ListNode(2), 
                l3 = new ListNode(3), 
                l4 = new ListNode(4);
            l1.Next = l2; 
            l2.Next = l3; 
            l3.Next = l4;
            ListNode r = DeleteDuplicates(l1);
            Assert.AreEqual(1, r.Val); r = r.Next;
            Assert.AreEqual(2, r.Val); r = r.Next;
            Assert.AreEqual(3, r.Val); r = r.Next;
            Assert.AreEqual(4, r.Val); r = r.Next;
        }

        [TestMethod]
        public void LinkedListIntv_DeleteDuplicatesTest3()
        {
            ListNode l1 = new ListNode(1);
            ListNode r = DeleteDuplicates(l1);
            Assert.AreEqual(1, r.Val); r = r.Next;
        }

        [TestMethod]
        public void LinkedListIntv_DeleteDuplicatesTest4()
        {
            ListNode l1 = new ListNode(2), 
                l2 = new ListNode(2), 
                l3 = new ListNode(2), 
                l4 = new ListNode(2);
            l1.Next = l2; 
            l2.Next = l3; 
            l3.Next = l4;
            ListNode r = DeleteDuplicates(l1);
            Assert.AreEqual(2, r.Val); r = r.Next;
            Assert.IsNull(r);
        }
    };
}