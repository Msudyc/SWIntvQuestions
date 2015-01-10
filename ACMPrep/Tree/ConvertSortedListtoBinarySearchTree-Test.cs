using System;
using System.Collections.Generic;
using Microsoft.VisualStudio.TestTools.UnitTesting;

namespace ACMPrep
{
    public partial class TreeIntv
    {
        [TestMethod]
        public void TreeIntv_SortedListToBSTTest1()
        {
            ListNode l1 = new ListNode(1),
                l2 = new ListNode(2),
                l3 = new ListNode(3);
            l1.Next = l2; l2.Next = l3;
            TreeNode r = SortedListToBST(l1);
            Assert.AreEqual(2, r.Val);
            Assert.AreEqual(1, r.Left.Val);
            Assert.AreEqual(3, r.Right.Val);
        }
    };
}