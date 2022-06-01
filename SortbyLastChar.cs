using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ExerciciosCodeWars
{
    internal class SortbyLastChar
    {
        public static string[] Last(string x) => x.Split(' ').AsEnumerable().OrderBy(x => x.Last()).ToArray();
    }
}
