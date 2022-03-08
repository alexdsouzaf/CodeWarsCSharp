using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ExerciciosCodeWars
{
    internal class SumOfPositive
    {
        public static int PositiveSum(int[] arr)
        {
            // Your code here
            return  arr.Where(x => x > 0).Sum(x => x);           
        }
    }
}
