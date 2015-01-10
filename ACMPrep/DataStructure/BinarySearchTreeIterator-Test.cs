using System;
using System.Collections.Generic;
using Microsoft.VisualStudio.TestTools.UnitTesting;

namespace ACMPrep
{
    [TestClass]
    public partial class DataStructure
    {
        [TestMethod]
        public void DataStructure_BSTIteratorTest1()
        {
            TreeNode root = new TreeNode(4),
                l = new TreeNode(2),
                r = new TreeNode(5),
                ll = new TreeNode(1),
                lr = new TreeNode(3);
            root.Left = l;
            root.Right = r;
            l.Left = ll;
            l.Right = lr;

            BSTIterator it = new BSTIterator(root);
            Assert.IsTrue(it.HasNext());
            Assert.AreEqual(1, it.Next());
            Assert.AreEqual(2, it.Next());
            Assert.AreEqual(3, it.Next());
            Assert.AreEqual(4, it.Next());
            Assert.AreEqual(5, it.Next());
            Assert.IsFalse(it.HasNext());
        }
    };
}