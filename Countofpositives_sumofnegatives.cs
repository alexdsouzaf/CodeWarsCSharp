using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ExerciciosCodeWars
{
    internal class Countofpositives_sumofnegatives
    {
        public static int[] CountPositivesSumNegatives(int[] input)
        {
            if (input == null || input.Length == 0)
                return new int[0];
            

            int sums = 0;
            List<int> result = new List<int>();
            foreach (var item in input.Where( x => x != 0 ) )
            {
                if (item > 0)
                    result.Add(item);

                if (item < 0)
                    sums += item;
                
            }
            List<int> final = new List<int>();
            final.Add(result.Count);
            final.Add(sums);
            return final.ToArray(); //return an array with count of positives and sum of negatives
        }
    }
}
