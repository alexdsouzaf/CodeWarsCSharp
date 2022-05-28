using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ExerciciosCodeWars
{

    /// <summary>
    /// ja nao deu certo
    /// NAO RESOLVIDO
    /// </summary>
    internal class RemovingElements
    {
        public static object[] RemoveEveryOther(object[] arr)
        {
            // happy coding
            int index = 0;
            int tmanho = arr.Length;
            while (index <= tmanho)
            {
                if (index % 2 != 0 )
                    arr.ToList().RemoveAt(index);

                index++;    
            }

            return arr.ToArray();
        }
    }
}
