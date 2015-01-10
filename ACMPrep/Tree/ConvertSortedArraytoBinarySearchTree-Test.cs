using System;
using System.Collections.Generic;
using Microsoft.VisualStudio.TestTools.UnitTesting;

namespace ACMPrep
{
    public partial class TreeIntv
    {
        [TestMethod]
        public void TreeIntv_SortedArrayToBSTTest1()
        {
            int[] row0 = { 1, 2, 3 };
            TreeNode r = SortedArrayToBST(row0);
            Assert.AreEqual(2, r.Val);
            Assert.AreEqual(1, r.Left.Val);
            Assert.AreEqual(3, r.Right.Val);
        }
    };
}