using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ExerciciosCodeWars
{
    internal class SentenceSmash
    {
        public static string Smash(string[] words)
        {
            string frase = "";
            
            // Smash words
            foreach (var item in words)
            {
                frase += item + " ";                
            }

            return frase.TrimEnd();
        }
    }
}
