using System;
using System.Collections.Generic;
using Microsoft.VisualStudio.TestTools.UnitTesting;

namespace ACMPrep
{
    public partial class LinkedListIntv
    {
        [TestMethod]
        public void LinkedListIntv_RemoveNthFromEndTest1()
        {
            ListNode h0 = new ListNode(0); 
            ListNode h1 = new ListNode(1); 
            ListNode h2 = new ListNode(2); 
            ListNode h3 = new ListNode(3);

            h0.Next = h1; 
            h1.Next = h2; 
            h2.Next = h3;

            ListNode r = RemoveNthFromEnd(h0, 1);
            Assert.AreEqual(0, r.Val);
            Assert.AreEqual(1, r.Next.Val);
            Assert.AreEqual(2, r.Next.Next.Val);
            Assert.IsNull(r.Next.Next.Next);

            h0.Next = h1; 
            h1.Next = h2; 
            h2.Next = h3;
            r = RemoveNthFromEnd(h0, 2);
            Assert.AreEqual(0, r.Val);
            Assert.AreEqual(1, r.Next.Val);
            Assert.AreEqual(3, r.Next.Next.Val);

            h0.Next = h1; 
            h1.Next = h2; 
            h2.Next = h3;
            r = RemoveNthFromEnd(h0, 3);
            Assert.AreEqual(0, r.Val);
            Assert.AreEqual(2, r.Next.Val);
            Assert.AreEqual(3, r.Next.Next.Val);

            h0.Next = h1; 
            h1.Next = h2; 
            h2.Next = h3;
            r = RemoveNthFromEnd(h0, 4);
            Assert.AreEqual(1, r.Val);
            Assert.AreEqual(2, r.Next.Val);
            Assert.AreEqual(3, r.Next.Next.Val);            
        }

        [TestMethod]
        public void LinkedListIntv_RemoveNthFromEndTest2()
        {
            ListNode h0 = new ListNode(0);
            ListNode r = RemoveNthFromEnd(h0, 1);
            Assert.IsNull(r);
        }

        [TestMethod]
        public void LinkedListIntv_RemoveNthFromEndTest3()
        {
            ListNode h0 = new ListNode(0); 
            ListNode h1 = new ListNode(1);

            h0.Next = h1;
            ListNode r = RemoveNthFromEnd(h0, 1);
            Assert.AreEqual(0, r.Val);
        }

        [TestMethod]
        public void LinkedListIntv_RemoveNthFromEndTest4()
        {
            ListNode h0 = new ListNode(0); 
            ListNode h1 = new ListNode(1);

            h0.Next = h1;
            ListNode r = RemoveNthFromEnd(h0, 2);
            Assert.AreEqual(1, r.Val);
        }
    };
}