/*
Given an array of inteter [a1, a2, ..., an], return a new array like
[a2*a3*...*an, a1*a3*...*an, ..., a1*a2*an-1]
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
        public static int[] Multiplication(int[] integers)
        {
            int n = integers.Length;
            int[] result = new int[n];
            if(n == 0)
                return result;

            int left = 1;
            int right = 1;
            for (int i = 0; i < n; i++)
            {
                if (result[i] == 0)
                    result[i] = 1;
                if (result[n - 1 - i] == 0)
                    result[n - 1 - i] = 1;

                result[i] *= left;
                result[n - 1 - i] *= right;
                left *= integers[i];
                right *= integers[n - 1 - i];
            }

            return result;
        }
    }
}