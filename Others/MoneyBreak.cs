/*
$0.01, $0.05, $0.10, $0.25, $1, $2, $5, $10, $20, $100
Give you a double value representing some money, ask you to 
return most closest breaking down.
Ex:
103.35 => 100 2 1 .25 .10
104.03 => 100 2 2 .01 .01 .01
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
        public static string MoneyBreak(decimal money)
        {
            if (money <= 0)
                return string.Empty;

            decimal[] map = { .01m, .05m, .10m, .25m, 1m, 2m, 5m, 10m, 20m, 100m };
            StringBuilder sb = new StringBuilder();
            int i = map.Length - 1;
            while (money > 0)
            {
                while (money >= map[i])
                {
                    sb.Append(map[i]).Append(" ");
                    money -= map[i];
                }

                i--;
            }

            return sb.ToString();
        }
    }
}