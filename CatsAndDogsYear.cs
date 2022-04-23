using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ExerciciosCodeWars
{
    internal class CatsAndDogsYear
    {
        public static int[] humanYearsCatYearsDogYears(int humanYears) => new int[] { humanYears, Years(humanYears,true), Years(humanYears, false) };



        private static int Years(int humanYears, bool IsCat) //or IsDog whatever
        {
            int year = 0;
            if (humanYears == 1)
                return year = 15;

            if (humanYears == 2)
                return year = 15 + 9;

            if (humanYears > 2)
            {
                year = 15 + 9;
                for (int i = 3; i <= humanYears; i++)
                {
                    if (IsCat)
                        year += 4;
                    else
                        year += 5;
                }
            }

            return year;
        }
    }
}
