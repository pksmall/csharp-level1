using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

/*
 * Павел Корженко
 */

/*
 * 3. 
 *   - *Описать класс дробей - рациональных чисел, являющихся отношением двух 
 *      целых чисел. Предусмотреть методы сложения, вычитания, умножения и деления 
 *      дробей. Написать программу, демонстрирующую все разработанные элементы 
 *      класса.*
 *   - **Добавить проверку, чтобы знаменатель не равнялся 0. Выбрасывать исключение
 *     ArgumentException("Знаменатель не может быть равен 0"). Добавить упрощение дробей.**
 */

namespace task0303
{
    class Program
    {
        static void Main(string[] args)
        {
            try
            {
                Fraction x1 = new Fraction(5, 7);
                Console.WriteLine("X1 = " + x1.Print());
                Fraction x2 = new Fraction(3, 6);
                Console.WriteLine("X2 = " + x2.Print());
                Fraction x3 = Fraction.Plus(x1, x2);
                Console.WriteLine("Plus = " + x3.Print());
                Fraction x4 = Fraction.Minus(x1, x2);
                Console.WriteLine("Minus = " + x4.Print());
                Fraction x5 = Fraction.Devide(x1, x2);
                Console.WriteLine("Devide = " + x5.Print());
                Fraction x6 = Fraction.Multi(x1, x2);
                Console.WriteLine("Multi = " + x6.Print());
            }
            catch (ArgumentException ex)
            {
                Console.WriteLine(ex);
            }
        }
    }
}