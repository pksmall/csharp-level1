using System;
using System.IO;
using System.Linq;
using System.Text;
using System.Text.RegularExpressions;
using UsefulMethods;

/*
 * Павел Корженко
 */

/* 
 * 4. На вход программе подаются сведения о сдаче экзаменов учениками 9-х классов некоторой средней
 *    школы. В первой строке сообщается количество учеников N, которое не меньше 10, но не
 *    превосходит 100, каждая из следующих N строк имеет следующий формат:
 *    <Фамилия> <Имя> <оценки>,
 *    где <Фамилия> — строка, состоящая не более чем из 20 символов, <Имя> — строка, состоящая не
 *    более чем из 15 символов, <оценки> — через пробел три целых числа, соответствующие оценкам по
 *    пятибалльной системе. <Фамилия> и <Имя>, а также <Имя> и <оценки> разделены одним пробелом.
 *    Пример входной строки:
 *        Иванов Петр 4 5 3
 *    Требуется написать как можно более эффективную программу, которая будет выводить на экран
 *    фамилии и имена трёх худших по среднему баллу учеников. Если среди остальных есть ученики,
 *    набравшие тот же средний балл, что и один из трёх худших, следует вывести и их фамилии и имена.
 */

namespace task0504
{
    class Program
    {
        static void Main(string[] args)
        {
            string fileName = "../../../../../pupils.txt";
            try
            {
                string[] pupils = File.ReadLines(fileName, Encoding.UTF8).ToArray();
                ToCalc(pupils);
            }
            catch (Exception ex)
            {
                UseMethods.Print($"File {fileName} not found.");
                UseMethods.Print($"{ex}");
            }
        }

        static void ToCalc(string[] aPupils)
        {
            int numOfPupils = 0;
            try
            {
                numOfPupils = int.Parse(aPupils[0]);
            } catch
            {
                UseMethods.Print("\x1b[1;31mНеверные данные.\x1b[0m Первая строка файла, должна содержать число учеников.");
                return;
            }

            for (int idx = 1; idx < numOfPupils; idx++)
            {
                Match matchResutls = null;
                string pName = "";
                string pValues = "";
                UseMethods.Print($"{aPupils[idx]}");
                try
                {
                    matchResutls = Regex.Match(aPupils[idx], @"^(\w+.\w+).(\d.\d.\d)", RegexOptions.IgnoreCase);
                    if (matchResutls.Success)
                    {
                        pName = matchResutls.Groups[1].Value;
                        pValues = matchResutls.Groups[2].Value;
                    } else
                    {
                        UseMethods.Print("Фамилия Имя и Оценки не распознаны.");

                    }
                } catch (AggregateException ex)
                {
                    UseMethods.Print($"{ex}");
                }

                UseMethods.Print($"'{pName}'  => '{pValues}'");
            }
        }
    }
}
