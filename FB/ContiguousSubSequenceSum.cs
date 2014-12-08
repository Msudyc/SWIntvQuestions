/*
Given an integer array and a target number, find if there exists 
an contiguous sub array whose sum equals to the target.
*/

namespace FB
{
    #region using
    using System;
    using System.Collections.Generic;
    using System.Text;
    #endregion

    public partial class FBEx
    {
        public static bool ContiguousSubSequenceSum(int[] arr, int target)
        {
            if (arr.Length == 0)
                return false;

            int n = arr.Length;
            int[] acc = new int[n];
            Dictionary<int, int> map = new Dictionary<int, int>();

            acc[0] = arr[0];
            for (int i = 1; i < n; i++)
                acc[i] = arr[i] + acc[i - 1];

            for (int i = 0; i < n; i++)
            {
                if (!map.ContainsKey(acc[i]))
                {
                    if (!map.ContainsKey(acc[i] + target))
                        map.Add(acc[i] + target, i);
                }
                else
                    return true;
            }

            return false;
        }
    }
}