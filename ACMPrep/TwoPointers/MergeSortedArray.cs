/*
Given two sorted integer arrays A and B, merge B into A 
as one sorted array.

Note:
 You may assume that A has enough space to hold additional
 elements from B. The number of elements initialized in A 
 and B are m and n respectively.

class Solution {
public:
    void merge(int A[], int m, int B[], int n) {
        
    }
};
*/

namespace ACMPrep
{
    #region using
    using System;
    using System.Collections.Generic;
    #endregion

    public partial class TwoPointers
    {
        public static void Merge(int[] A, int m, int[] B, int n)
        {
            while (n > 0)
            {
                if (m <= 0 || A[m - 1] < B[n - 1])
                {
                    A[n + m - 1] = B[n - 1];
                    n--;
                }
                else
                {
                    A[n + m - 1] = A[m - 1];
                    m--;
                }
            }
        }
    }
}