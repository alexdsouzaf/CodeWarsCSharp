using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ExerciciosCodeWars
{
    public class SquareRootOrNot
    {
        public static int[] SquareOrSquareRoot(int[] array)
        {
            List<int> newArray = new List<int>();
            foreach (var item in array)
            {
                newArray.Add(item.FatoracaoExponenciacao());
            }
            return newArray.ToArray<int>();
        }

    }
}
