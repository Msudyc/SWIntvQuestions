/*

Given a nested list of integers, returns the sum of all integers in the
list weighted by their depth. 
For example, 
1, given the list {{1, 1}, 2, {1, 1}}  return 10 
(four 1's at depth 2, one 2 at depth 1)
2, given the list {1, {4, {6}}} return 27 
(one 1 at depth 1, one 4 at depth 2, and one 6 at depth 3)

*/

namespace ACMPrep
{
    #region using
    using System;
    using System.Collections.Generic;
    using System.Text;
    #endregion

    public partial class LKTN
    {
        public static int NestedListSum(string str)
        {
            if (string.IsNullOrEmpty(str))
                return 0;

            int sum = 0;
            int depth = 0;
            for (int i = 0; i < str.Length; i++)
            {
                if (str[i] == '{')
                    depth++;
                else if (str[i] == '}')
                    depth--;
                else if (str[i] <= '9' && str[i] >= '0')
                    sum += (str[i] - '0') * depth;
            }

            return sum;
        }
    }
}