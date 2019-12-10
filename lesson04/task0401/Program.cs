using System;

/*
 * Павел Корженко
 */

/*
 * 1. Дан  целочисленный  массив  из 20 элементов.  Элементы  массива  могут 
 *    принимать  целые  значения  от –10 000 до 10 000 включительно. Заполнить 
 *    случайными числами.  Написать программу, позволяющую найти и вывести 
 *    количество пар элементов массива, в которых только одно число делится на 3. 
 *    В данной задаче под парой подразумевается два подряд идущих элемента 
 *    массива. Например, для массива из пяти элементов: 6; 2; 9; –3; 6 ответ — 2. 
 */

namespace task0401
{
    class Program
    {
        static void Main(string[] args)
        {
            int num = 20;
            int min = -10000;
            int max = 10000;

            var myArray = new int[num];
            Random random = new Random();
            for (int i = 0; i < num; i++)
                myArray[i] = random.Next(min, max);
            
            string stringarray = "";
            for (int x = 0; x < num; x++)
            {
                stringarray = stringarray + myArray[x] + " ";
            }
            Console.WriteLine(stringarray);

            DivBy3(myArray);
        }

        public static int DivBy3(int[] arr)
        {
            int count = 0;
            for (int i = 0; i < arr.Length - 1; i++)
            {
                if (arr[i] % 3 == 0 || arr[i + 1] % 3 == 0)
                    count++;
                Console.WriteLine("Пара чисел: {0} и {1}", arr[i], arr[i + 1]);
            }
            Console.WriteLine("Количество пар: " + count);
            return count;
        }
    }
}
