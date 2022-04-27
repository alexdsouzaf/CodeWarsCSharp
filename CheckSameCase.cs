using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ExerciciosCodeWars
{
    internal class CheckSameCase
    {
        #region[First Solution]
        static string upperCase = "ABCDEFGHIJKLMNOPQRSTUVWXYZ";
        static string lowerCase = "abcdefghijklmnopqrstuvwxyz";
        public static int SameCase(char a, char b)
        {
            //same case return 1
            if ( ( IsUpper(a) && IsUpper(b) ) || ( IsLower(a) && IsLower(b) ) )
                return 1;


            //diferent case return 0
            if (( IsUpper(a) && IsLower(b) ) || IsUpper(b) && IsLower(a))
                return 0;
            

            //not letter -1
            return -1;
        }

        private static bool IsUpper(char p) => upperCase.Contains(p);
        private static  bool IsLower(char p) => lowerCase.Contains(p);
        #endregion

        #region[Second Solution]
        public static int SameCase2(char a, char b)
        {
            if (!char.IsLetter(a) || !char.IsLetter(b))
                return -1;

            return char.IsLower(a) == char.IsLower(b) ? 1 : 0;
        }
        #endregion
    }
}
