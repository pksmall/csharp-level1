using System;

/*
 * Павел Корженко
 */

/*
 * 2. Написать метод подсчета количества цифр числа.
 */

namespace task02
{
    class Program
    {
        static void Main(string[] args)
        {
            long digit = 2345298543323232;
            Console.WriteLine("Solution #1. Total Digits in Number {0} is {1}", digit, Task02_v1(digit));
            Console.WriteLine("Solution #2. Total Digits in Number {0} is {1}", digit, Task02_v2(digit));
            Console.WriteLine("Solution #3. Total Digits in Number {0} is {1}", digit, Task02_v3(digit));
            Console.WriteLine("Solution #4. Total Digits in Number {0} is {1}", digit, Task02_v4(digit));
        }

        /*
         * interative solution
         */
        static int Task02_v1(long n)
        {
            int count = 0;
            while (n != 0)
            {
                n /= 10;
                count++;
            }

            return count;
        }

        /*
         *  recursive solution
         */
        static int Task02_v2(long n)
        {
            if (n == 0)
                return 0;
            return 1 + Task02_v2(n / 10);
        }

        /*
         *  log base solution
         */
        static int Task02_v3(long n)
        {
            return (int)Math.Floor(Math.Log10(n) + 1);
        }

        /*
         * string base solution
         */
        static int Task02_v4(long n)
        {
            string myString = $"{n}";
            return myString.Length;
        }
    }
}
