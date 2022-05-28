using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ExerciciosCodeWars
{
    internal class RemoveFirstandLastCharacter
    {
        public static string Remove_char(string s)
        {
            return s.Remove(s.Length - 1, 1).Remove(0,1);
            
        }
    }
}
