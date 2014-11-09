/*

Sub set by using an integer
No dup elements.

*/

namespace ACMPrep
{
    #region using
    using System;
    using System.Collections.Generic;
    using System.Text;
    #endregion

    public partial class DFS
    {
        public static List<List<char>> GetAllSubSets(char[] elements)
        {
            List<List<char>> result = new List<List<char>>();
            List<char> empty = new List<char>();
            result.Add(empty);

            int n = elements.Length;
            if (n == 0)
                return result;

            for (int i = 1; i < (1 << n); i++)
            {
                List<char> temp = new List<char>();
                for (int j = 0; j < n; j++)
                {
                    if((i & (1 << j)) > 0)
                        temp.Add(elements[j]);
                }

                result.Add(temp);
            }

            return result;
        }
    }
}