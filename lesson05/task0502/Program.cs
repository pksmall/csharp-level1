using System;
using System.IO;
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
 *    - Продемонстрируйте работу программы на текстовом файле с вашей программой.
 */

namespace task0502
{
    class Program
    {
        static void Main(string[] args)
        {
            string fileName = "../../../../../bigtext.txt";
            try
            {
                Message message = new Message(File.ReadAllText(fileName, Encoding.UTF8));
                message.task05a(3);
                UseMethods.Print(message.task05b('t'));
                UseMethods.Print("Find max words:");
                message.task05c(true);
                UseMethods.Print("Use StringBuilder Class:");
                message.task05d();
            }
            catch (Exception ex)
            {
                UseMethods.Print($"File {fileName} not found.");
                UseMethods.Print($"{ex}");
            }

        }
    }
}
