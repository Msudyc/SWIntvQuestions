/*
Given an char array, remove 'a' and 'b' in place.
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
        public static void RemoveAandB(char[] arr)
        {
            int n = arr.Length;
            int p = 0;
            for (int i = 0; i < n; i++)
            {
                if (arr[i] != 'a' && arr[i] != 'b')
                    arr[p++] = arr[i];
                arr[i] = '\0';
            }
        }
    }
}