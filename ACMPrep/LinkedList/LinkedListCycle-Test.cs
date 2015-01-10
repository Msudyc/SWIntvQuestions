using System;
using System.Collections.Generic;
using Microsoft.VisualStudio.TestTools.UnitTesting;

namespace ACMPrep
{
    public partial class LinkedListIntv
    {
        [TestMethod]
        public void LinkedListIntv_HasCycleTest1()
        {
            ListNode l0 = new ListNode(0), 
                l1 = new ListNode(1), 
                l2 = new ListNode(2),
                l3 = new ListNode(3), 
                l4 = new ListNode(4);
            l0.Next = l1; 
            l1.Next = l2; 
            l2.Next = l3; 
            l3.Next = l4; 
            l4.Next = l1;
            Assert.IsTrue(HasCycle(l0));
        }

        [TestMethod]
        public void LinkedListIntv_HasCycleTest2()
        {
            ListNode l0 = new ListNode(0), 
                l1 = new ListNode(1), 
                l2 = new ListNode(2), 
                l3 = new ListNode(3), 
                l4 = new ListNode(4);
            l0.Next = l1; 
            l1.Next = l2; 
            l2.Next = l3; 
            l3.Next = l4;
            Assert.IsFalse(HasCycle(l0));
        }
    };
}