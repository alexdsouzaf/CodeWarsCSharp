using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ExerciciosCodeWars
{
    internal class Whatisbetween
    {
        public static int[] Between(int a, int b)
        {
            // your code here

            List<int> list = new List<int>();
            for (int i = a; i <= b; i++)
            {
                list.Add( i );
            }

            return list.ToArray();
        }
    }
}
