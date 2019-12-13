using System;
using System.Text;

/*
 * Павел Корженко
 */

/*
 *  часто используемы методы в учебе.
 */
namespace UsefulMethods
{
    public class UseMethods
    {
        /*
         * Print 
         *  String msg - принемает просто строку
         */
        public static void Print(string msg)
        {
            Console.WriteLine(msg);
        }
        public static void Print(StringBuilder msg)
        {
            Console.WriteLine(msg);
        }

        /*
         * Print 
         *  String msg - принемает просто строку 
         *  bool h - флаг true / false если надо добавить знак $ 
         */
        public static void Print(string msg, bool h)
        {
            if (h)
            {
                Console.WriteLine($"\n{msg}");
            }
            else
            {
                Console.WriteLine(msg);
            }
        }

        /*
         * Pause
         *  ждем ввода символа
         */
        static void Pause()
        {
            Console.ReadKey();
        }

        /*
         * Get Value
         *  печатаем msg и ждем ввода строки
         */
        public static string GetValue(string msg)
        {
            Console.Write(msg);
            string retStr = Console.ReadLine();

            return retStr;
        }

    }
}
