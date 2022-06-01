using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ExerciciosCodeWars
{
    internal class Ghostbusterswhitespaceremoval
    {
        public static string GhostBusters(string building)
        {
            if (!building.Contains(" "))
                return "You just wanted my autograph didn't you?";
            
            return building.Replace(" ", "");
        }
    }
}
