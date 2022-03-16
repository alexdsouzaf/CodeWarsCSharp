using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ExerciciosCodeWars
{
    internal class LoveDetector
    {
        public static bool lovefunc(int flower1, int flower2) => ((flower1 % 2 == 0) && (flower2 % 2 != 0)) || ((flower1 % 2 != 0) && (flower2 % 2 == 0));

    }
}
