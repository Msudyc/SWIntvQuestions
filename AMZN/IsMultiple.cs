/*
A long string is made of multiple times of another short string.
The minimum length for the small string is 2. Give you a string to
determine if it is such a string.
Examples:
 * abcabcabc -> true
 * bcdbcdbcde -> false
 * abcdabcd -> true
 * xyz -> false
 * aaaaaaaaaa -> false (cannot be thought of 5 aa)

Require O(n).
public boolean isMultiple(String s){

 }
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
        public static bool IsMultiple(string str)
        {
            int n = str.Length;
            if (n < 4)
                return false;

            for (int i = 2; i < n / 2; i++)
            {
                if (n % i != 0)
                    continue;

                int len = n / i;
                string sub = str.Substring(0, len);
                int j = len;
                for (; j + len <= n; j = j + len)
                {
                    if (str.Substring(j, len) != sub)
                        break;
                }

                if (j + len > n)
                {
                    char c = sub[0];
                    foreach (char a in sub)
                        if (a != c)
                            return true;
                }
            }

            return false;
        }
    }
}
