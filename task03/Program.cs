using System;

/*
 * Павел Корженко
 */

/*
 * 3.  С клавиатуры вводятся числа, пока не будет введен 0. Подсчитать сумму всех нечетных положительных чисел.
 */

namespace task03
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Sum of odd number is {0}", Task03());
        }
        
        /*
         * Task03
         *  sum of odd numbers
         */
        static int Task03()
        {
            int sum = 0;
            int num;

            do
            {
                Console.Write("Enter any number or 0 to exit: ");
                num = Convert.ToInt32(Console.ReadLine());
                if (num % 2 != 0)
                {
                    sum += num;
                }
            } while (num > 0);

            return sum;
        }
    }
}
