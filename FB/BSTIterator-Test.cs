using System;
using System.Collections.Generic;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using ACMPrep;

namespace FB
{
    public partial class FBEx
    {
        [TestMethod]
        public void FB_BSTIteratorTest1()
        {
            TreeNode root = new TreeNode(3),
                l = new TreeNode(2),
                ll = new TreeNode(1),
                r = new TreeNode(4),
                rr = new TreeNode(5);
            root.Left = l;
            root.Right = r;
            l.Left = ll;
            r.Right = rr;

            FBExBSTIterator iterator = new FBExBSTIterator(root);
            Assert.AreEqual(1, iterator.Next().Val);
            Assert.AreEqual(2, iterator.Next().Val);
            Assert.AreEqual(3, iterator.Next().Val);
            Assert.AreEqual(4, iterator.Next().Val);
            Assert.AreEqual(5, iterator.Next().Val);
            Assert.IsNull(iterator.Next());
        }
    }
}
