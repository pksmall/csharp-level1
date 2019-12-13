using System;
using System.Linq;
using UsefulMethods;

/*
 * Павел Корженко
 */

/*
 * 3. *Для двух строк написать метод, определяющий, является ли одна строка перестановкой другой. 
 *     Регистр можно не учитывать:
 *     - а) с использованием методов C#;
 *     - б) *разработав собственный алгоритм.
 *         Например:
 *           badc являются перестановкой abcd.
 */

namespace task0503
{
    class Program
    {
        static void Main(string[] args)
        {
            string str1 = "abcd";
            string str2 = "badc";

            if (IsAnagram(str1, str2))
            {
                UseMethods.Print($"Строка {str1}  явлеяет анаграммой строки {str2}.");
            }
            else
            {
                UseMethods.Print($"Строка {str1}  не явлеяет анаграммой  строки {str2}.");
            }

            if (IsAnagramV2(str1, str2))
            {
                UseMethods.Print($"Строка {str1}  явлеяет анаграммой строки {str2}.");
            }
            else
            {
                UseMethods.Print($"Строка {str1}  не явлеяет анаграммой  строки {str2}.");
            }

        }
        
        static bool IsAnagram(string str1, string str2)
        {
            if (str1.Length != str2.Length)
            {
                return false;
            }
            return str1.Select(Char.ToLower).OrderBy(x => x).SequenceEqual(str2.Select(Char.ToLower).OrderBy(x => x)); ;
        }
 
        static bool IsAnagramV2(string str1, string str2)
        {
            if (str1.Length != str2.Length)
            {
                return false;
            }
            string s1 = Alphabetize(str1);
            string s2 = Alphabetize(str2);

            if (s1 == s2)
            {
                return true;
            } else
            {
                return false;
            }
        }
        static string Alphabetize(string s)
        {
            char[] a = s.ToCharArray();
            Array.Sort(a);
            return new string(a);
        }
    }
}