using System;

/*
 * Павел Корженко
 */

/*
 * 6. Написать программу подсчета количества «Хороших» чисел в диапазоне от 1 до 1 000 000 000. Хорошим называется
 *    число, которое делится на сумму своих цифр. Реализовать подсчет времени выполнения программы, используя
 *    структуру DateTime.
 */

namespace task06
{
    class Program
    {
        static void Main(string[] args)
        {
            Task06();
        }

        /*
         * Task06
         *  print total 'good' numbers
         */
        static void Task06()
        {
            long minNumber = 1;
            //long maxNumber = 1000000000;
            long maxNumber = 1000000;
            long gns_amount = 0;
            long amountNumbers = 0;

            /*            long i = 386;
                        amountNumbers = CalculateNumbers(i);
                        if ((i % amountNumbers) == 0)
                        {
                            Console.WriteLine("Good number {0:N0} {1:N0}", i, amountNumbers);

                        }
                        else
                        {
                            Console.WriteLine("Bad number {0:N0} {1:N0}", i, amountNumbers);

                        }
            */
            Console.WriteLine("\nКоличество 'Хороших' чисел в интервале от 1 до {0:N0}", maxNumber);
            long ellapledTicks = DateTime.Now.Ticks;
            for (long i = minNumber; i < maxNumber; i++)
            {
                amountNumbers = CalculateNumbers(i);
                if ((i % amountNumbers) == 0)
                    gns_amount++;
            }
            ellapledTicks = DateTime.Now.Ticks - ellapledTicks;
            Console.WriteLine("составило {0:N0} штук", gns_amount);
            Console.WriteLine("Потрачено тактов на выполнение: ");
            TimeSpan elapsedSpan = new TimeSpan(ellapledTicks);
            Console.WriteLine("   {0:N0} nanoseconds", ellapledTicks * 100);
            Console.WriteLine("   {0:N0} ticks", ellapledTicks);
            Console.WriteLine("   {0:N2} seconds", elapsedSpan.TotalSeconds);
            Console.WriteLine("   {0:N2} minutes", elapsedSpan.TotalMinutes);
            Console.WriteLine("   {0:N0} days, {1} hours, {2} minutes, {3} seconds",
                              elapsedSpan.Days, elapsedSpan.Hours,
                              elapsedSpan.Minutes, elapsedSpan.Seconds);
        }

        static long CalculateNumbers(long i)
        {
            long count = 0;
            while (i > 0)
            {
                count = count + i % 10;
                i = i / 10;
            }
            return count;
        }
    }
}
