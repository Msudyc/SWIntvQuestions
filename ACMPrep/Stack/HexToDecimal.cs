/*

Hex to Decimal number. Ex. 78,  -> BE->190.

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
        public static int HexToDecimal(string num)
        {
            bool sign = num[0] == '-' ? false : true;
            if (sign == false)
                num = num.Substring(1);
            num = num.ToLower();

            int result = 0;
            for (int i = 0; i < num.Length; i++)
            {
                int current;
                if (num[i] >= '0' && num[i] <= '9')
                    current = num[i] - '0';
                else if (num[i] >= 'a' && num[i] <= 'f')
                    current = 10 + num[i] - 'a';
                else
                    throw new ArgumentException("Bad input!");
                result = result * 16 + current;
            }

            return sign ? result : -result;
        }
    }
}