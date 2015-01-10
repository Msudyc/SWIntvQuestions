/*
Given numRows, generate the first numRows of Pascal's triangle 
with a queue structure.

For example, given numRows = 5,
 Return

[
     [1],
    [1,1],
   [1,2,1],
  [1,3,3,1],
 [1,4,6,4,1]
]

*/

namespace ACMPrep
{
    #region using
    using System;
    using System.Collections.Generic;
    using System.Text;
    #endregion

    public partial class StackIntv
    {
        public static List<List<int>> PascalTriangle(int n)
        {
            List<List<int>> result = new List<List<int>>();
            if (n <= 0)
                return result;

            Queue<int> queue = new Queue<int>();
            queue.Enqueue(1);

            for (int i = 0; i <= n; i++)
            {
                queue.Enqueue(0);
                int pre = 0;
                List<int> r = new List<int>();
                for (int j = 0; j < i + 2; j++)
                {
                    int cur = queue.Dequeue();
                    if (j < i + 1)
                        r.Add(cur);

                    // Calculate next row
                    int temp = pre + cur;
                    queue.Enqueue(temp);
                    pre = cur;                    
                }

                result.Add(r);
            }

            return result;
        }
    }
}