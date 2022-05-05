using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ExerciciosCodeWars
{
    /// <summary>
    /// Método para fatorar um numero e verificar se deve executar a exponenciacao do mesmo 
    /// ou apenas retornar sua raiz
    /// </summary>
    /// <param name="num"></param>
    /// <returns></returns>
    public static class KataExtensions
    {
        public static int FatoracaoExponenciacao(this int num)
        {
            decimal numCalc = num;
            decimal i = 1;
            while (true)            
            {

                if (numCalc / i == 1)
                    return (i * i).ToInt32();

                if (numCalc / i == i)
                    return i.ToInt32();

                i++;
            }
        }
        public static int ToInt32(this decimal num ) => Convert.ToInt32(num);
        public static int ToInt32(this string num ) => Convert.ToInt32(num);
    }



}
