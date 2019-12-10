using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;

/*
 * Павел Корженко
 */

/*
 * 2. Реализуйте задачу 1 в виде статического класса StaticClass;
 *     а) Класс должен содержать статический метод, который принимает на вход массив и решает задачу 1;
 *     б) *Добавьте статический метод для считывания массива из текстового файла. Метод должен возвращать 
 *         массив целых чисел;
 *     в) **Добавьте обработку ситуации отсутствия файла на диске.
 */

namespace task0402
{
    class Program
    {
        static void Main(string[] args)
        {
            Task0402 myArray = new Task0402(20, -10000, 10000);
            Console.WriteLine(myArray.ToString());
            myArray.DivBy3();
            int[] arr = myArray.ReadArrayFromFile("../../../../../myarray.txt");
            foreach(int i in arr)
            {
                Console.WriteLine($"{i}");
            }
        }
    }

    public class Task0402
    {
        private int[] am;

        public Task0402(int n, int min, int max)
        {
            am = new int[n];
            Random random = new Random();
            for (int i = 0; i < n; i++)
                am[i] = random.Next(min, max);
        }

        public int[] ReadArrayFromFile(string fileName)
        {
            int[] retArr;
            try
            {
                retArr = File.ReadLines(fileName).Select(l => Convert.ToInt32(l)).ToArray();
            }
            catch (Exception ex)
            {
                retArr = new int[0];
                Console.WriteLine($"File {fileName} not found. {ex}");
            }
            return retArr;
        }
        private static IEnumerable<int[]> ExtractData(StreamReader sr)
        {
            string line;
            while ((line = sr.ReadLine()) != null)
            {
                yield return line.Split(",").Select(i => Convert.ToInt32(i)).ToArray();
            }
        }

        public int DivBy3()
        {
            int count = 0;
            for (int i = 0; i < am.Length - 1; i++)
            {
                if (am[i] % 3 == 0 || am[i + 1] % 3 == 0)
                    count++;
                Console.WriteLine("Пара чисел: {0} и {1}", am[i], am[i + 1]);
            }
            Console.WriteLine("Количество пар: " + count);
            return count;
        }

        override public string ToString()
        {
            string stringarray = "";
            foreach (int x in am)
                stringarray = stringarray + x + " ";
            return stringarray;
        }
    }
}
