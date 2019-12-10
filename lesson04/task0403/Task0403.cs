using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;

/*
 * Павел Корженко
 */

/*
 * 3. а) Дописать класс для работы с одномерным массивом. Реализовать конструктор, создающий массив определенного 
 *       размера и заполняющий массив числами от начального значения с заданным шагом. Создать свойство Sum, 
 *       которое возвращает сумму элементов массива, метод Inverse, возвращающий новый массив с измененными знаками 
 *       у всех элементов массива (старый массив, остается без изменений),  метод Multi, умножающий каждый элемент 
 *       массива на определённое число, свойство MaxCount, возвращающее количество максимальных элементов. 
 *    б) ** Создать библиотеку содержащую класс для работы с массивом. Продемонстрировать работу библиотеки
 *    е) *** Подсчитать частоту вхождения каждого элемента в массив (коллекция Dictionary<int,int>)
 */

namespace task0403
{
    class Task0403
    {
        private int[] am;

        public Task0403(int n, int step, int min, int max)
        {
            am = new int[n];
            am[0] = min;
            for (int i = 1; i < n; i++)
                am[i] = am[i-1] + step;
        }

        public int Sum()
        {
            return am.Sum();
        }

        public long Multi()
        {
            long prod = 1;
            foreach (int val in am)
            {
                prod *= val;
            }
            return prod;
        }

        public int[] Inverse()
        {
            int[] arr = new int[am.Length];
            for(int i = 0; i < am.Length; i++)
            {
                arr[i] = am[i] * -1;
            }
            return arr;
        }

        public void CountFrequency()
        {
            var dict = new Dictionary<int, int>();
            foreach (var item in am)
            {
                if (dict.ContainsKey(item))
                {
                    dict[item]++;
                }
                else { 
                    dict.Add(item, 1); 
                }
            }
            foreach (var item in dict)
            {
                Console.WriteLine(item.Key + "  встречается " + item.Value + " раз");
            }
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
