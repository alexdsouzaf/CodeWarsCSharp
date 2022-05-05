using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ExerciciosCodeWars
{
    internal class HumanReadableTime
    {
        
        public static string GetReadableTime(int seconds)
        {
            string sTimeSpan = TimeSpan.FromSeconds(seconds).ToString();
            
            if ( sTimeSpan.Length > 8 )
            {                
                string[] arrOriginal = sTimeSpan.Split('.');
                string[] data = arrOriginal[1].Split(':');
                int diasDeSobra = arrOriginal[0].ToInt32();

                int index = 0;
                while (index < diasDeSobra)
                {
                    data[0] = (data[0].ToInt32() + 24).ToString();
                    index++;
                }
                return $"{data[0]}:{data[1]}:{data[2]}";
            }

            return sTimeSpan;
        }
    }

}
