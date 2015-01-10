using System;
using System.Collections.Generic;
using Microsoft.VisualStudio.TestTools.UnitTesting;

namespace ACMPrep
{
    [TestClass]
    public partial class LinkedListIntv
    {
        [TestMethod]
        public void LinkedListIntv_AddTwoNumbersTest1()
        {
            ListNode l1 = null, l2 = null;
            Assert.IsNull(AddTwoNumbers(l1, l2));
        }

        [TestMethod]
        public void LinkedListIntv_AddTwoNumbersTest2()
        {
            ListNode l1 = new ListNode(5);
            ListNode l2 = new ListNode(5);
            ListNode r = AddTwoNumbers(l1, l2);
            Assert.AreEqual(0, r.Val);
            r = r.Next;
            Assert.AreEqual(1, r.Val);
        }

        [TestMethod]
        public void LinkedListIntv_AddTwoNumbersTest3()
        {
            ListNode l1 = new ListNode(1);
            ListNode l2 = new ListNode(9);
            l2.Next = new ListNode(9);
            ListNode r = AddTwoNumbers(l1, l2);
            Assert.AreEqual(0, r.Val);
            r = r.Next;
            Assert.AreEqual(0, r.Val);
            r = r.Next;
            Assert.AreEqual(1, r.Val);
        }

        [TestMethod]
        public void LinkedListIntv_AddTwoNumbersTest4()
        {
            ListNode l1 = new ListNode(1);
            ListNode l2 = new ListNode(9);
            l2.Next = new ListNode(9);
            l2.Next.Next = new ListNode(9);
            ListNode r = AddTwoNumbers(l1, l2);
            Assert.AreEqual(0, r.Val);
            r = r.Next;
            Assert.AreEqual(0, r.Val);
            r = r.Next;
            Assert.AreEqual(0, r.Val);
            r = r.Next;
            Assert.AreEqual(1, r.Val);
        }

        [TestMethod]
        public void LinkedListIntv_AddTwoNumbersTest5()
        {
            ListNode l1 = new ListNode(1);
            ListNode l2 = new ListNode(9);
            l2.Next = new ListNode(8);
            ListNode r = AddTwoNumbers(l1, l2);
            Assert.AreEqual(0, r.Val);
            r = r.Next;
            Assert.AreEqual(9, r.Val);
        }
    };
}