using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ExerciciosCodeWars
{
    internal class SumTheStrings
    {
        public static string StringsSum(string s1, string s2)
        {
            // Write your solution here.
            int i1 = 0;
            int i2 = 0;
            
            try{
                i1 = Convert.ToInt32( s1 );
            }catch (Exception ex){
                i1 = 0;
            }
            
            try{
                i2 = Convert.ToInt32( s2 );
            }catch (Exception ex){
                i2 = 0;                
            }

            return (i1 + i2).ToString();
        }
    }
}
