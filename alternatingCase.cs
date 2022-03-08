using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ExerciciosCodeWars
{
    internal class alternatingCase
    {

        public static string alternatingCaseName(string pTexto)
        {
            string newText = "";
            foreach (char letter in pTexto)
            {
                if (char.IsUpper(letter))
                    newText += letter.ToString().ToLower();                    
                else
                    newText += letter.ToString().ToUpper();
            }
            return newText;
        }
    }
}
