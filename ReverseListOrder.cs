using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ExerciciosCodeWars
{
    internal class ReverseListOrder
    {
        public static List<int> ReverseList(List<int> list)
        {
            // Return a new list with its elements in reverse order compared to the input list
            // Do not mutate the original list!
            List<int> reverseList = new List<int>();
            foreach (var item in list)
            {
                reverseList.Add(item);
            }
            reverseList.Reverse();
            return reverseList;
        }
    }
}
