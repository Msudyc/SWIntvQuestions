/*
Find the increasing subsequence of greatest length.
ex. 5  2  8  6  3  6  9  7
Sol is 4, 2->3->6->9

*/

namespace ACMPrep
{
    #region using
    using System;
    using System.Collections.Generic;
    using System.Text;
    #endregion

    public partial class DynamicProgramming
    {
        public static int LongestIncrSubSeqs(int[] nums)
        {
            /*
             * for j = 1,2,...,n:
             *   L(j) = 1 + Max{L(i):(i,j) in E}
             * return max L(j)
             */

            int n = nums.Length;
            if (n <= 1)
                return n;

            int[] dp = new int[n];
            int max = 0;
            for (int i = 0; i < n; i++)
            {
                dp[i] = 1;
                for (int j = i - 1; j >= 0; j--)
                {
                    if (nums[j] < nums[i])
                        dp[i] = Math.Max(dp[i], dp[j] + 1);
                }

                max = Math.Max(max, dp[i]);
            }

            return max;
        }
    }
}