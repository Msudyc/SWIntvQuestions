using System;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using ACMPrep;

namespace FB
{
    public partial class FBEx
    {
        [TestMethod]
        public void FB_CommonAncestorTest1()
        {
            TreeNode n0 = new TreeNode(0);
            TreeNode n1 = new TreeNode(1);
            TreeNode n2 = new TreeNode(2);
            TreeNode n3 = new TreeNode(3);
            TreeNode n4 = new TreeNode(4);
            TreeNode n5 = new TreeNode(5);
            TreeNode n6 = new TreeNode(6);

            n0.Left = n1;
            n0.Right = n2;

            n1.Left = n3;
            n1.Right = n4;

            n2.Left = n5;
            n2.Right = n6;

            TreeNode result = CommonAncestor(n0, n3, n5);
            Assert.AreEqual(0, result.Val);
        }

        [TestMethod]
        public void FB_CommonAncestorTest2()
        {
            TreeNode n0 = new TreeNode(0);
            TreeNode n1 = new TreeNode(1);
            TreeNode n2 = new TreeNode(2);
            TreeNode n3 = new TreeNode(3);
            TreeNode n4 = new TreeNode(4);
            TreeNode n5 = new TreeNode(5);
            TreeNode n6 = new TreeNode(6);

            n0.Left = n1;
            n0.Right = n2;

            n1.Left = n3;
            n1.Right = n4;

            n2.Left = n5;
            n2.Right = n6;

            TreeNode result = CommonAncestor(n0, n3, n3);
            Assert.AreEqual(3, result.Val);
        }

        [TestMethod]
        public void FB_CommonAncestorTest3()
        {
            TreeNode n0 = new TreeNode(0);
            TreeNode n1 = new TreeNode(1);
            TreeNode n2 = new TreeNode(2);
            TreeNode n3 = new TreeNode(3);
            TreeNode n4 = new TreeNode(4);
            TreeNode n5 = new TreeNode(5);
            TreeNode n6 = new TreeNode(6);
            TreeNode n7 = new TreeNode(7);

            n0.Left = n1;
            n0.Right = n2;

            n1.Left = n3;
            n1.Right = n4;

            n2.Left = n5;
            n2.Right = n6;

            TreeNode result = CommonAncestor(n0, n3, n7);
            Assert.IsNull(result);
        }
    }
}
