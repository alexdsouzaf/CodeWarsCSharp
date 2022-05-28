using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ExerciciosCodeWars
{
    /// <summary>
    /// incompleto
    /// problema com espaço em branco no fim da string
    /// NAO RESOLVIDO
    /// </summary>
    internal class ReversedWords
    {
        public static string ReverseWords(string str)
        {
            string[] palavras = str.Split(" ");
            string result = string.Empty;
            foreach (var item in palavras.Reverse())
            {
                result += $"{item} ";
            }

            return result;
        }
    }
}
