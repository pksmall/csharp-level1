using System;
using System.Collections.Generic;
using System.IO;

/*
 * Павел Корженко
 */

/*
 * 3. Переделать программу Пример использования коллекций для решения следующих задач:
 *   - а) Подсчитать количество студентов учащихся на 5 и 6 курсах;
 *   - б) подсчитать сколько студентов в возрасте от 18 до 20 лет на каком курсе учатся (*частотный массив);
 *   - в) отсортировать список по возрасту студента;
 *   - г) *отсортировать список по курсу и возрасту студента;
 */

namespace task0603
{
    public delegate bool Cmp(int x, int a, int b);

    class Program
    {
        public static int SortByFirstName(Student st1, Student st2)
        {
            return String.Compare(st1.firstName, st2.firstName);
        }
        public static int CompareByAge(Student st1, Student st2)
        {
            return st1.age.CompareTo(st2.age);
        }

        static void Main(string[] args)
        {
            string dbFile = "db.csv";
            GenerateList fl = new GenerateList();
            fl.Generate(dbFile, 15);

            int bakalavr = 0;
            int magistr = 0;
            int sumMB = 0;            
            List<Student> list = new List<Student>();

            DateTime dt = DateTime.Now;
            StreamReader sr = new StreamReader(dbFile);
            while(!sr.EndOfStream)
            {
                try
                {
                    string[] s = sr.ReadLine().Split(';');
                    list.Add(new Student(s[0], s[1], s[2], s[3], s[4], int.Parse(s[5]), int.Parse(s[6]), int.Parse(s[7]), s[8]));
                    if (int.Parse(s[5]) >= 5) sumMB++;
                    if (int.Parse(s[5]) < 5) bakalavr++; else magistr++;
                } catch (Exception e)
                {
                    Console.WriteLine(e);
                    Console.WriteLine("Ошибка! ESC - пректарить выполнения программы.");
                    if (Console.ReadKey().Key == ConsoleKey.Escape) return;
                }
            }
            sr.Close();

            //б) подсчитать сколько студентов в возрасте от 18 до 20 лет на каком курсе учатся (*частотный массив);
            // 1st int - курс
            // 2nd int - кол-во стунтов с выбраным параметром (18 - 20 лет).
            Dictionary<int, int> dictResult = GetDictByParams(list, AgeCmp, 18, 20);

            Console.WriteLine("Всего стундентов: " + list.Count);
            Console.WriteLine("Студентов на 5 и 6-х курсах: {0}", sumMB);
            Console.WriteLine("Магистров: {0}", magistr);
            Console.WriteLine("Баклавров: {0}", bakalavr);
            Console.WriteLine("От 18 до 20 лет:");
            foreach (var item in dictResult)
            {
                Console.WriteLine(item);
            }

            list.Sort(new Comparison<Student>(SortByFirstName));
            foreach (var v in list)
            {
                Console.WriteLine(v.firstName + " " + v.course + " " + v.age);
            }
            Console.WriteLine("--------------------");
            Console.WriteLine("*-в) отсортировать список по возрасту студента;");
            Console.WriteLine("--------------------");
            list.Sort(new Comparison<Student>(CompareByAge));
            foreach (var v in list)
            {
                Console.WriteLine(v.firstName + " " + v.course + " " + v.age);
            }
            Console.WriteLine("--------------------");
            Console.WriteLine("*-г) *отсортировать список по курсу и возрасту студента;");
            Console.WriteLine("--------------------");
            list.Sort((x, y) =>
            {
                int result = decimal.Compare(x.course, y.course); 
                if (result == 0)
                    result = decimal.Compare(x.age, y.age);
                return result;
            });
            foreach (var v in list)
            {
                Console.WriteLine(v.firstName + " " + v.course + " " + v.age);
            }

            Console.WriteLine(DateTime.Now - dt);
        }

        static bool AgeCmp(int x, int a, int b)
        {
            if (x >= a && x <= b)
            {
                return true;
            }
            else
            {
                return false;
            }
        }

        public static Dictionary<int, int> GetDictByParams(List<Student> l, Cmp F, int a, int b)
        {
            Dictionary<int, int> dictResult = new Dictionary<int, int>();

            foreach(var v in l)
            {
                if (F(v.age, a, b))
                {
                    if (!dictResult.ContainsKey(v.age)) dictResult.Add(v.age, 0);
                    dictResult[v.age]++;
                }
            }
            return dictResult;
        }
    }
}
