using System;
using System.Collections.Generic;
using System.Text;
using UsefulMethods;

/*
 * Павел Корженко
 */

/*
 * 2. Разработать класс Message, содержащий следующие статические методы для обработки текста:
 *    - а) Вывести только те слова сообщения, которые содержат не более n букв.
 *    - б) Удалить из сообщения все слова, которые заканчиваются на заданный символ.
 *    - в) Найти самое длинное слово сообщения.
 *    - г) Сформировать строку с помощью StringBuilder из самых длинных слов сообщения.
 *    - д) Построить гистограмму встречаемости слов. Использовать для этих целей Dictionary
 *    - Продемонстрируйте работу программы на текстовом файле с вашей программой.
 */

namespace task0502
{
    class Message
    {
        string message;

        string[] delimiters = { " ", ",", ";", ":", ".", "!", "?", Environment.NewLine };

        public Message()
        {
            message = "";
        }

        public Message(string msg)
        {
            message = msg;
        }

        public string GetMessage
        {
            get
            {
                return message;
            }
        }

        /*
         * - а) Вывести только те слова сообщения, которые содержат не более n букв.
         */
        public void task05a(int n)
        {
            string[] a = message.Split(delimiters, StringSplitOptions.None);

            foreach (string element in a)
            {
                if (element.Length <= n && element.Length > 0 && Char.IsLetterOrDigit(element[0]))
                {
                    UseMethods.Print(element);
                }
            }
        }

        /*
         *  - б) Удалить из сообщения все слова, которые заканчиваются на заданный символ.
         */
        public string task05b(char ch)
        {
            string str = message;
            string[] a = str.Split(delimiters, StringSplitOptions.None);

            for (int i = 0; i < a.Length; i++)
            {
                if (a[i].Length > 0)
                {
                    if (a[i].EndsWith(ch.ToString()))
                    {
                        str = str.Remove(str.IndexOf(a[i]), a[i].Length);
                    }
                }
            }
            return str;
        }

        /*
         * - в) Найти самое длинное слово сообщения.
         */
        public List<string> task05c(bool printElements = false)
        {
            int max = 0;
            List<string> retList = new List<string>();
            string[] a = message.Split(delimiters, StringSplitOptions.None);

            foreach (string element in a)
            {
                if (element.Length > max)
                {
                    max = element.Length;
                }
            }

            foreach (string element in a)
            {
                if (element.Length == max)
                {
                    if (retList.Contains(element) != true)
                    {
                        retList.Add(element);
                        if (printElements)
                        {
                            UseMethods.Print($"'{element}'");
                        }
                    }
                }
            }

            return retList;
        }

        /*
         * - г) Сформировать строку с помощью StringBuilder из самых длинных слов сообщения.
         */
        public void task05d()
        {
            int max = 0;
            string[] a = message.Split(delimiters, StringSplitOptions.None);
            StringBuilder bStr = new StringBuilder("");

            foreach (string element in a)
            {
                if (element.Length > max)
                {
                    max = element.Length;
                }
            }

            foreach (string element in a)
            {
                if (element.Length == max)
                {
                    bStr.Append(element + " ");
                }
            }

            UseMethods.Print(bStr);
        }

        /* 
         * - д) Построить гистограмму встречаемости слов.Использовать для этих целей Dictionary
         */
        public Dictionary<String, int> task05g()
        {
            string[] a = message.Split(delimiters, StringSplitOptions.None);

            Dictionary<String, int> result = new Dictionary<string, int>();

            foreach(var word in a)
            {
                if (!result.ContainsKey(word)) result.Add(word, 0);
                result[word]++;
            }
            return result;
        }
    }
}
