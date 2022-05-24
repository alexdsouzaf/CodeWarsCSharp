using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ExerciciosCodeWars
{
    internal class Stringcleaning
    {
        /// <summary>
        /// DA PRA RESOLVER COM REGEX
        /// </summary>
        /// <param name="s"></param>
        /// <returns></returns>
        public static string StringClean(string s)
        {
            string result = string.Empty;
            // Function will return the cleaned string
            foreach (char item in s)
            {
                if (!char.IsNumber(item))
                    result += item;
                    //s.Remove(item);

            }

            return result;
        }
    }
}
