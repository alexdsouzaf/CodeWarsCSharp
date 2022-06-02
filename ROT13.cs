using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ExerciciosCodeWars
{
    public class ROT13
    {
        public static string Rot13(string input)
        {
            char[] alf = new char[26] {'a','b', 'c', 'd', 'e', 'f', 'g', 'h', 'i', 'j', 'k', 'l', 'm', 'n', 'o', 'p', 'q', 'r', 's', 't', 'u', 'v', 'w', 'x', 'y', 'z'};
            string result = string.Empty;

            foreach (var item in input)
            {
                try
                {
                    int index = 0;
                    bool upper = char.IsUpper(item);
                    if (alf.Contains(char.ToLower(item)))
                    {
                        index = alf.ToList().IndexOf(char.ToLower(item)) + 13;
                        if (index >= alf.Length)
                            index = index - alf.Length;
                    
                        result += upper ? char.ToUpper(alf[index]).ToString() : alf[index].ToString();
                    }
                    else
                        result += item;
                }
                catch (Exception ex)
                {
                    string erro = ex.Message;
                }
                
            }

            return result;
        }
    }
}
