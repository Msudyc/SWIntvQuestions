/*
Given an integer n, return the number of trailing zeroes in n!.

Note: Your solution should be in logarithmic time complexity.

class Solution {
public:
    int trailingZeroes(int n) {
        
    }
};
*/

namespace ACMPrep
{
    #region using
    using System;
    using System.Collections.Generic;
    #endregion

    public partial class MathIntv
    {
        public static int TrailingZeroes(int n)
        {
            int c = 0;
            while (n >= 5) 
            {
                n /= 5;
                c += n;
            }
            
            return c;
        }
    }
}