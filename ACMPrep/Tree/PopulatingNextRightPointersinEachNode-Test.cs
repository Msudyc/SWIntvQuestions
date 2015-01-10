using System;
using System.Collections.Generic;
using Microsoft.VisualStudio.TestTools.UnitTesting;

namespace ACMPrep
{
    public partial class TreeIntv
    {
        [TestMethod]
        public void TreeIntv_ConnectTest1()
        {
            TreeLinkNode root = new TreeLinkNode(1),
                l = new TreeLinkNode(2),
                r = new TreeLinkNode(3),
                ll = new TreeLinkNode(4),
                lr = new TreeLinkNode(5),
                rl = new TreeLinkNode(6),
                rr = new TreeLinkNode(7);
            root.Left = l;
            root.Right = r;
            l.Left = ll;
            l.Right = lr;
            r.Left = rl;
            r.Right = rr;
            Connect(root);
            Assert.AreEqual(3, l.Next.Val);
            Assert.AreEqual(5, ll.Next.Val);
            Assert.AreEqual(6, lr.Next.Val);
            Assert.AreEqual(7, rl.Next.Val);
        }

        [TestMethod]
        public void TreeIntv_ConnectTest2()
        {
            TreeLinkNode root = new TreeLinkNode(1),
                l = new TreeLinkNode(2);
            root.Left = l;
            Connect(root);
            Assert.IsNull(l.Next);
        }
    };
}