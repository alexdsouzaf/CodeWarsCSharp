using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ExerciciosCodeWars
{
    internal class MissingNumbers
    {
        public static int[] FindMissingNumbers(int[] arr)
        {
            int[] result = new int[arr.Length];
            for (int i = 0; i < arr.Length; i++)
            {
                //diferença de um index para outro
                int a = arr[i] - arr[i + 1];

            }

            return arr;
        }
    }
}
