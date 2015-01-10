using System;
using System.Collections.Generic;
using Microsoft.VisualStudio.TestTools.UnitTesting;

namespace ACMPrep
{
    public partial class Backtracking
    {
        [TestMethod]
        public void Backtracking_LetterCombinationsTest1()
        {
            List<string> r = LetterCombinations("23");
            Assert.AreEqual(9, r.Count);
        }

        [TestMethod]
        public void Backtracking_LetterCombinationsTest2()
        {
            List<string> r = LetterCombinations("27");
            Assert.AreEqual(12, r.Count);
        }

        [TestMethod]
        public void Backtracking_LetterCombinationsTest3()
        {
            List<string> r = LetterCombinations("279");
            Assert.AreEqual(48, r.Count);
        }
    };
}