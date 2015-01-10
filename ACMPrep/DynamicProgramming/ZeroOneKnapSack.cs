/*
Burglar's bag can only hold a total weight of at most W pounds. There are n items
to pick from, of weight w1, ..., wn and dollar value v1, ..., vn. What is the most
valuable combination of items he can fit into his bag?

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
        public static int ZeroOneKnapSack(int[] weights, int[] values, int W)
        {
            /*
             * K(w, j) = max{K(w-wj, j-1) + vj, K(w, j-1)}
             */

            int n = weights.Length;
            if (n == 0 || W <= 0)
                return 0;

            int[,] dp = new int[n + 1, W + 1];
            for (int i = 1; i <= n; i++)
                for (int j = 0; j <= W; j++)
                {
                    dp[i, j] = dp[i - 1, j];
                    if (j >= weights[i-1])
                    {
                        int temp = dp[i - 1, j - weights[i-1]] + values[i-1];
                        dp[i, j] = Math.Max(dp[i, j], temp);
                    }
                }

            return dp[n, W];
        }

        public static int ZeroOneKnapSack2(int[] weights, int[] values, int W)
        {
            /*
             * K(w, j) = max{K(w-wj, j-1) + vj, K(w, j-1)}
             */

            int n = weights.Length;
            if (n == 0 || W <= 0)
                return 0;

            int[] dp = new int[W + 1];
            for (int i = 1; i <= n; i++)
                for (int j = W; j > 0; j--)
                    if (j >= weights[i - 1])
                    {
                        int temp = dp[j - weights[i - 1]] + values[i - 1];
                        dp[j] = Math.Max(dp[j], temp);
                    }

            return dp[W];
        }
    }
}