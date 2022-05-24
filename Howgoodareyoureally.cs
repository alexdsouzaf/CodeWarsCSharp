using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ExerciciosCodeWars
{
    internal class Howgoodareyoureally
    {
        public static bool BetterThanAverage(int[] ClassPoints, int YourPoints) => YourPoints > ClassPoints.Average();        
    }
}
