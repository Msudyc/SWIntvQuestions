using System;
using System.Collections.Generic;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using ACMPrep;

namespace FB
{
    public partial class FBEx
    {
        [TestMethod]
        public void FB_CloneGraphTest1()
        {
            UndirectedGraphNode t0 = new UndirectedGraphNode(0), 
                t1 = new UndirectedGraphNode(1), 
                t2 = new UndirectedGraphNode(2);

            t0.Neighbors.Add(t1); 
            t0.Neighbors.Add(t2);
            t1.Neighbors.Add(t0); 
            t1.Neighbors.Add(t2);
            t2.Neighbors.Add(t0); 
            t2.Neighbors.Add(t1); 
            t2.Neighbors.Add(t2);

            UndirectedGraphNode r = CloneGraph(t0);
            Assert.AreEqual(0, r.Label);
            Assert.AreEqual(2, r.Neighbors.Count);

            UndirectedGraphNode r1 = r.Neighbors[0];
            Assert.AreEqual(1, r1.Label);
            Assert.AreEqual(2, r1.Neighbors.Count);

            UndirectedGraphNode r2 = r.Neighbors[1];
            Assert.AreEqual(2, r2.Label);
            Assert.AreEqual(3, r2.Neighbors.Count);
        }
    };
}