using System;

/*
 * Павел Корженко
 */

/*
 * 1. Написать метод, возвращающий минимальное из трех чисел.
 */

namespace task01
{
    class Program
    {
        static void Main(string[] args)
        {
            int a = 15;
            int b = 6;
            a %= b;
            Console.WriteLine(a);
            Console.WriteLine("Min Number is {0}", Task01(13, 11, 11));
        }

        /*
         *  Mostly
         *   mostly return min int of three
         */
        static bool Mostly(int min, int x, int y)
        {
            return min < x && min < y;
        }

        /*
         * Task01 
         *  return min int of three
         *  otherwise will return 0 if one of them contans equal a numeric
         */
        static int Task01(int x, int y, int z)
        {
            int min = 0;

            if (Mostly(x,y,z))
            {
                return x;
            }
            if (Mostly(y, x, z))
            {
                return y;
            }
            if (Mostly(z, x, y))
            {
                return z;
            }

            return min;
        }
    }
}
