/*
Given a string array and a string.
Sort the string array by the given string.
Ex. { "face", "ball", "apple", "art", "ah" }, "badpchler"
After sorting { "ball", "apple", "ah", "art", "face" }
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
        private static Dictionary<char, int> map = new Dictionary<char, int>();
        public static void SortByString(List<string> arr, string str)
        {
            for (int i = 0; i < str.Length; i++)
                if (!map.ContainsKey(str[i]))
                    map.Add(str[i], i);

            arr.Sort(CustomCompare);
        }

        private static int CustomCompare(string x, string y)
        {
            if (string.IsNullOrEmpty(x))
                return -y.Length;

            if (string.IsNullOrEmpty(y))
                return x.Length;

            int num = x.Length < y.Length ? x.Length : y.Length;
            for (int i = 0; i < num; i++)
                if (x[i] != y[i])
                {
                    int nx = map.ContainsKey(x[i]) ? map[x[i]] : 0;
                    int ny = map.ContainsKey(y[i]) ? map[y[i]] : 0;
                    return nx - ny;
                }

            return x.Length < y.Length ? -1 : 1;
        }
    }
}