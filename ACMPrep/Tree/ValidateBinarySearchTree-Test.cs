using System;
using System.Collections.Generic;
using Microsoft.VisualStudio.TestTools.UnitTesting;

namespace ACMPrep
{
    public partial class TreeIntv
    {
        [TestMethod]
        public void TreeIntv_IsValidBSTTest1()
        {
            TreeNode root = new TreeNode(1), 
                r = new TreeNode(2), 
                rr = new TreeNode(3);
            root.Right = r; 
            r.Right = rr;
            Assert.IsTrue(IsValidBST(root));
        }

        [TestMethod]
        public void TreeIntv_IsValidBSTTest2()
        {
            TreeNode root = new TreeNode(1), 
                r = new TreeNode(2), 
                rr = new TreeNode(3);
            root.Right = r; 
            r.Left = rr;
            Assert.IsFalse(IsValidBST(root));
        }

        [TestMethod]
        public void TreeIntv_IsValidBSTTest3()
        {
            TreeNode root = new TreeNode(1);
            Assert.IsTrue(IsValidBST(root));
        }

        [TestMethod]
        public void TreeIntv_IsValidBSTTest4()
        {
            Assert.IsTrue(IsValidBST(null));
        }
    };
}