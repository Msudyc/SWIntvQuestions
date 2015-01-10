/*

Decimal to Hex number. Ex. 150->96, 190 -> BE.

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
        public static string DecimalToHex(int num)
        {
            char[] map = {'0','1','2','3','4','5','6','7','8','9','A','B','C','D','E','F'};
            bool sign = true;
            if (num < 0)
            {
                sign = false;
                num = -num;
            }

            Stack<char> stk = new Stack<char>();
            while (num > 0)
            {
                char c = map[num % 16];
                stk.Push(c);
                num /= 16;
            }

            if (stk.Count == 0)
                return "0";

            StringBuilder result = new StringBuilder();
            while (stk.Count > 0)
                result.Append(stk.Pop());

            return sign ? result.ToString() : "-" + result.ToString();
        }
    }
}