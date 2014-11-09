/*

Decimal to Octal number. Ex. decimal 120 to octal 170.

*/

namespace ACMPrep
{
    #region using
    using System;
    using System.Collections.Generic;
    using System.Text;
    #endregion

    public partial class StackAndQueue
    {
        public static string DecimalToOctal(int num)
        {
            bool sign = true;
            if (num < 0)
            {
                sign = false;
                num = -num;
            }

            Stack<int> stk = new Stack<int>();
            while (num > 0)
            {
                char c = (char)(num % 8);
                stk.Push(c);
                num /= 8;
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