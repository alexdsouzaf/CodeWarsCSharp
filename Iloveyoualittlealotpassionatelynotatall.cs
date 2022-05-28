using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ExerciciosCodeWars
{
    internal class Iloveyoualittlealotpassionatelynotatall
    {
        /// <summary>
        /// I love you
        /// a little
        /// a lot
        /// passionately
        /// madly
        /// not at all
        /// </summary>
        /// <param name="nb_petals"></param>
        /// <returns></returns>
        public static string HowMuchILoveYou(int nb_petals)
        {
            // your code
            
            string[] results = new string[6] { "I love you", "a little", "a lot", "passionately", "madly", "not at all"};
            int index = 0;
            int whileIndex = 0;
            while (whileIndex < nb_petals)
            {
                if (index == results.Count())
                {
                    index = 0;
                }

                index++;
                whileIndex++;
            }
            

            return results[index - 1];
        }
    }
}
