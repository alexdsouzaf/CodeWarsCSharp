using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ExerciciosCodeWars
{
    internal class DifferenceofVolumesofCuboids
    {
        public static int FindDifference(int[] a, int[] b)
        {
            int multA = 1;
            for (int i = 0; i < a.Length; i++)
            {
                multA = multA * a[i];
            }

            int multB = 1;
            for (int i = 0; i < b.Length; i++)
            {
                multB = multB * b[i];
            }
            return Math.Abs(multA - multB);
        }
    }
}
