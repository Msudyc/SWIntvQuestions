/*

Mice and holes are placed in a straight line. There are n holes on this line. 
Each hole can accomodate only 1 mouse. A mouse can stay at his position, move 
one step right from x to x+1, or move one step left from x to x−1. Any of these 
moves consumes 1 minute. Assign mice to holes so that the time when the last mouse
gets inside a hole is minimized. 

for example if there are 3 mice positions of mice are: 
4 -4 2 
positions of holes are: 
4 0 5 

the answer should be 4 
because: 
Assign mouse at position x=4 to hole at position x=4 : Time taken is 0 minutes 
Assign mouse at postion x=-4 to hole at position x=0 : Time taken is 4 minutes 
Assign mouse at postion x=2 to hole at postion x=5 : Time taken is 3 minutes 
After 4 minutes all of the mice are in the holes.

*/

namespace ACMPrep
{
    #region using
    using System;
    using System.Collections.Generic;
    using System.Text;
    #endregion

    public partial class AMZN
    {
        /*
         * Let m1 < m2 be the positions of two mice and let h1 < h2 be the positions of two holes.
         * then max(|m1 - h1|, |m2 - h2|) <= max(|m1 - h2|, |m2 - h1|)
         * by induction apply to 3, 4, .. m mice
         */
        public static int MiceAndHoles(int[] mice, int[] holes)
        {
            int m = mice.Length;
            int n = holes.Length;
            if (m == 0 || m > n)
                return -1;

            int[] positions = new int[m];
            Array.Sort(mice);
            Array.Sort(holes);
            return GetMin(0, n - m, positions, mice, holes);
        }

        private static int GetMin(int index, int extra, int[] positions, int[] mice, int[] holes)
        {
            if (index == mice.Length)
            {
                int max = 0;
                for (int i = 0; i < mice.Length; i++)
                    max = Math.Max(max, Math.Abs(mice[i] - holes[positions[i]]));
                return max;
            }
            else
            {
                int min = int.MaxValue;
                for (int i = 0; i <= extra; i++)
                {
                    positions[index] = index > 0 ? positions[index - 1] + 1 + i : i;
                    int nextExtra = extra - i > 0 ? extra - i : 0;
                    int v = GetMin(index + 1, nextExtra, positions, mice, holes);
                    min = Math.Min(min, v);
                }

                return min;
            }
        }
    }
}