/*
Given a number, can you return the CSV header string?
Simplify it with 3 letters.
A -- 0, B -- 1, C -- 2, AA -- 3, AB -- 4, AC -- 5, BA -- 6, BB -- 7, BC -- 8, CA -- 9, CB -- 10, CC -- 11,
AAA -- 12, AAB -- 13, AAC -- 14, ABA -- 15, ...
*/

namespace OTHR
{
    #region using
    using System;
    using System.Collections.Generic;
    using System.Text;
    #endregion

    public partial class OTHREx
    {
        public static string GetHeader(int n)
        {
            if (n < 0)
                return null;

            char[] map = {'A', 'B', 'C'};
            List<int> sum = new List<int>();
            sum.Add(0);
            int k = 0;
            while (n >= sum[k])
            {
                k++;
                sum.Add((int)Math.Pow(3, k) + sum[k-1]);
            }

            StringBuilder sb = new StringBuilder();
            while (k > 0)
            {
                int x = (n - sum[k - 1]) / (int)Math.Pow(3, (k - 1));
                sb.Append(map[x]);
                n = n - sum[k-1] - x * (int)Math.Pow(3, (k - 1)) + (k > 1 ? sum[k-2] : 0);
                k--;
            }

            return sb.ToString();
        }
    }
}