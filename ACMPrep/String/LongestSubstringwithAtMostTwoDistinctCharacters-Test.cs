using System;
using System.Collections.Generic;
using Microsoft.VisualStudio.TestTools.UnitTesting;

namespace ACMPrep
{
    public partial class StringIntv
    {
        [TestMethod]
        public void StringIntv_lengthOfLongestSubstringTwoDistinctTest1()
        {
            Assert.AreEqual(3, lengthOfLongestSubstringTwoDistinct("eceba"));
        }
    };
}