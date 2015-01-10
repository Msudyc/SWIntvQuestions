﻿/*
Implement next permutation, which rearranges numbers into 
the lexicographically next greater permutation of numbers. 

If such arrangement is not possible, it must rearrange it 
as the lowest possible order (ie, sorted in ascending order). 

The replacement must be in-place, do not allocate extra memory. 

Here are some examples. Inputs are in the left-hand column and 
its corresponding outputs are in the right-hand column.

1,2,3 → 1,3,2
3,2,1 → 1,2,3
1,1,5 → 1,5,1

class Solution {
public:
    void nextPermutation(List<int> &num) {
        
    }
};
*/

namespace ACMPrep
{
    #region using
    using System;
    using System.Collections.Generic;
    #endregion

    public partial class ArrayIntv
    {
        public static void nextPermutation(List<int> num)
        {
            int i = num.Count - 1;
            while (i > 0 && (num[i - 1] >= num[i]))
                i--;

            if (i == 0)
            {
                num.Reverse();
                return;
            }

            i--; //left elem to be exchanged

            int j = num.Count - 1;
            while (num[j] < num[i])
                j--;

            int temp = num[i];
            num[i] = num[j];
            num[j] = temp;

            num.Reverse(i + 1, num.Count - i - 1);
        }
    }
}