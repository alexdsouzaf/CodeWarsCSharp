using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ExerciciosCodeWars
{
    internal class CountSheep
    {
        public static string CountingSheep(int n)
        {
            string sheep = "";
            for (int i = 1; i <= n; i++)
            {
                sheep += $"{i} sheep...";
            }
            return sheep;
        }
    }
}
