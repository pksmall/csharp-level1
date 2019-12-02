using System;

/*
 * Павел Корженко
 */

/*
 * 7.
 *   - a) Разработать рекурсивный метод, который выводит на экран числа от a до b (a<b);
 *   - б) *Разработать рекурсивный метод, который считает сумму чисел от a до b.*
 */

namespace task07
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.Write("Введите a:");
            var a = Int32.Parse(Console.ReadLine());
            Console.Write("Введите b:");
            var b = Int32.Parse(Console.ReadLine());
            Task07a(a, b);
            Console.WriteLine("Sum = {0,5:N0}", Task07b(a, b));
        }

        static void Task07a(int a, int b)
        {
            if (a < b)
            {
                Console.WriteLine("  {0,5:N0}", a);
                Task07a(a + 1, b);
            } else
            {
                Console.WriteLine("  {0,5:N0}", a);
            }
        }

        static int Task07b(int a, int b)
        {
            return (a == b) ? b : a + Task07b(a + 1, b);
        }
    }
}
