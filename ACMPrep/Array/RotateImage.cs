/*
You are given an n x n 2D matrix representing an image.

Rotate the image by 90 degrees (clockwise).

Follow up:
 Could you do this in-place?

class Solution {
public:
    void rotate(List<List<int> > &matrix) {
        
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
        public static void Rotate(int[,] matrix)
        {
            int n = matrix.GetLength(0);
            for (int layer = 0; layer < n / 2; layer++)
            {
                int first = layer;
                int last = n - 1 - layer;
                for (int i = first; i < last; i++)
                {
                    int offset = i - first;
                    int top = matrix[first, i];
                    matrix[first, i] = matrix[last - offset, first]; //left.top                
                    matrix[last - offset, first] = matrix[last, last - offset]; //bottom.top                
                    matrix[last, last - offset] = matrix[i, last]; //right.bottom                
                    matrix[i, last] = top; //top.Right
                }
            }
        }

        public static void Rotate2(int[,] matrix, int n)
        {
            for (int i = 0; i < n / 2; i++)
                for (int j = 0; j < n; j++)
                    Swap(matrix, i, j, n - 1 - i, j);

            for (int i = 0; i < n; i++)
                for (int j = 0; j <= i; j++)
                    Swap(matrix, i, j, j, i);
        }

        private static void Swap(int[,] matrix, int a, int b, int x, int y)
        {
            int temp = matrix[a, b];
            matrix[a, b] = matrix[x, y];
            matrix[x, y] = temp;
        }
    }
}