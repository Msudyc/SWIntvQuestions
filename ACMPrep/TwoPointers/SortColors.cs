/*
Given an array with n objects colored red, white or blue, 
sort them so that objects of the same color are adjacent, 
with the colors in the order red, white and blue. 

Here, we will use the integers 0, 1, and 2 to represent 
the color red, white, and blue respectively. 

Note:
 You are not suppose to use the library's sort function for 
 this problem. 
 
Follow up:
 A rather straight forward solution is a two-pass algorithm 
 using counting sort. First, iterate the array counting number
 of 0's, 1's, and 2's, then overwrite array with total number 
 of 0's, then 1's and followed by 2's.

Could you come up with an one-pass algorithm using only 
constant space?

class Solution {
public:
    void sortColors(int A[], int n) {
        
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
        public static void SortColors(int[] A)
        {
            int red = 0;
            int blue = A.Length - 1;
         
            while (A[red] == 0) 
                red++;

            while (A[blue] == 2) 
                blue--;
         
            int i = red;
            while (i <= blue)
            {
                if (A[i] == 0 && i > red) 
                { 
                    Swap(A, i, red++); 
                    continue; 
                }
                else if (A[i] == 2) 
                { 
                    Swap(A, i, blue--); 
                    continue; 
                }

                i++;
            }
        }

        private static void Swap(int[] A, int i, int j)
        {
            int tmp = A[i];
            A[i] = A[j];
            A[j] = tmp;
        }
    }
}