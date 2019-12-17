using System;
using System.Collections.Generic;
using System.Threading;
using System.Threading.Tasks;
using System.IO;
using System.Linq;

/*
 * Есть файл в формате csv, представляющий собой информацию о студентах в следующем виде:
 * firstName	secondName	univercity	faculty	department	age	          сourse	             group	      city
 * Строка	      Строка	  Строка	 Строка	  Строка	Целое число	 Целое число от 1 до 6	Целое число	 Строка
 * Имя студента	Фамилия студента	Наименование университета	Наименование факультета	Наименование кафедры	Возраст студента	Номер курса; 1..4 бакалавр; 5..6 магистр	Номер группы	Название города студента
 */

namespace task0603
{
    class GenerateList
    {

        public void Generate(string path = "db.csv", int count = 100)
        {
            List<string> university = new List<string>(new string[] { "МГУ", "СПбУГ", "Хоргвардс" });
            List<string> faculty = new List<string>(new string[] { "ИТ науки", "Прикладная математика", "Магия струн", "Зелье варение", "Атомная физика"});
            List<string> department = new List<string>(new string[] { "Прикладные науки", "Математика", "Грифиндор", "Информатика" });
            List<string> cities = new List<string>(new string[] { "Москва", "Ленинград", "Саратов", "Лондон", "Нью-Йорк" });

            File.Delete(path);
            for (int i = 0; i < count; i++)
            {
                Random r = new Random();
                int uIdx = r.Next(university.Count);
                int fIdx = r.Next(faculty.Count);
                int dIdx = r.Next(department.Count);
                int cIdx = r.Next(cities.Count);
                System.IO.File.AppendAllText(path,
                    $"Иван_{i + 1};Иванов_{i + 1};{university[uIdx]};{faculty[fIdx]};{department[dIdx]};{GetRand(1,6)};{GetRand(17, 24)};{GetRand(100,110)};{cities[cIdx]}\n"
                );
            }
        }
        private int GetRand(int a, int b)
        {
            Random r = new Random();
            return r.Next(a, b);
        }

        // replace from new Random(DateTime.Now.Ticks.GetHashCode());
        // Since similar code is done in default constructor internally
        public Random a = new Random();
        public List<int> randomList = new List<int>();
        int MyNumber = 0;
        private void NewNumber()
        {
            MyNumber = a.Next(1, 10);
            if (!randomList.Contains(MyNumber))
            {
                randomList.Add(MyNumber);

            }
            foreach(var item in randomList)
            {
                Console.WriteLine(item);
            }
        }
    }
}
