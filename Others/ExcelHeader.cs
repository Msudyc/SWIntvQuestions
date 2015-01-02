/*
Given a number, can you return the CSV header string?
Simplify it with 3 letters.
A -- 0, B -- 1, C -- 2, AA -- 3, AB -- 4, AC -- 5, BA -- 6, BB -- 7, BC -- 8, CA -- 9, CB -- 10, CC -- 11,
AAA -- 12, AAB -- 13, AAC -- 14, ABA -- 15, ...
*/

namespace OTHR
{
    #region using
    using System;
    using System.Collections.Generic;
    using System.Text;
    #endregion

    public partial class OTHREx
    {
        public static string GetHeader(int n)
        {
            if (n < 0)
                return null;

            StringBuilder sb = new StringBuilder();
            while (n >= 0)
            {
                sb.Append((char)('A' + n % 3));
                n = n/3 -1;
            }

            return Reverse(sb.ToString());            
        }

        private static string Reverse(string str)
        {
            char[] arr = str.ToCharArray();
            Array.Reverse(arr);
            return new string(arr);
        }
    }
}