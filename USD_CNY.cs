using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ExerciciosCodeWars
{

    /// <summary>
    /// The conversion rate you should use is 6.75 CNY for every 1 USD. 
    /// All numbers should be represented as a string with 2 decimal places. (e.g. "21.00" NOT "21.0" or "21")
    /// </summary>
    internal class USD_CNY
    {
        public static string Usdcny(int usd) => ((double)usd * 6.75).ToString(format: "0.00") + " Chinese Yuan";
    }
}
