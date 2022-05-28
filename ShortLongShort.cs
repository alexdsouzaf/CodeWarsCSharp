using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ExerciciosCodeWars
{
    internal class ShortLongShort
    {
        public static string Solution(string a, string b)
        {
            string sLong = a.Length > b.Length ? a : b;
            string sShort = a.Length < b.Length ? a : b;
            return $"{sShort}{sLong}{sShort}";
        }
    }
}
