using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

/*
 * Павел Корженко
 */

/*
 * 2. 
 *   - а) С клавиатуры вводятся числа, пока не будет введен 0 (каждое число в
 *        новой строке). Требуется подсчитать сумму всех нечетных положительных чисел.
 *        Сами числа и сумму вывести на экран, используя tryParse;
 *   - б) Добавить обработку исключительных ситуаций на то, что могут быть введены
 *        некорректные данные. При возникновении ошибки вывести сообщение.
 *        Напишите соответствующую функцию;
 */

namespace task0302
{
    class Program
    {
        static string message = "Введите число, для окончания ввода введите 0: ";

        static void Main(string[] args)
        {
            Console.WriteLine("Sum of odd number is {0}", Task02());
        }

        static int Task02()
        {
            int x;
            int sum = 0;

            do
            {
                x = GetValue();
                if (x == -1)
                {
                    PrintErrorMessage();
                }
                else
                {
                    if (x % 2 != 0)
                    {
                        sum += x;
                    }
                }
            } while (x != 0);

            return sum;
        }

        static void PrintErrorMessage()
        {
            Console.WriteLine("\x1b[1;31mОшибка!\x1b[0m \x1b[1;36mВы ввели не конвертируемое число.\x1b[0m");
        }

        static int GetValue()
        {
            int x;
            string s;
            bool flag;

            Console.WriteLine(message);
            s = Console.ReadLine();
            flag = int.TryParse(s, out x);
            if (flag)
            {
                return x;
            } else
            {
                return -1;
            }
        }
    }
}
