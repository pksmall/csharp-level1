using System;

/*
 * Павел Корженко
 */

/*
 * 1. Изменить программу вывода таблицы функции так, чтобы можно было передавать функции 
 *    типа double (double, double). Продемонстрировать работу на функции с функцией a*x^2 и 
 *    функцией a*sin(x).
 */
namespace task0601
{
    // делегат для решения задачи
    public delegate double FunA(double a, double x);

    public delegate double Fun(double x);

    class Program
    {
        // перегруженый метод для решения задачи
        public static void Table(FunA F, double a, double x, double b)
        {
            Console.WriteLine("------- X ------ Y -----\n");
            while (x <= b)
            {
                Console.WriteLine("| {0,8:0.000} | {1,8:0.000} |", x, F(a, x));
                x += 1;
            }
            Console.WriteLine("------------------------\n");
        }

        static void Main(string[] args)
        {
            // демонстрация решения
            Console.WriteLine("Таблица функции a*x^2");
            Table(delegate (double a, double x) { return a * x * x; }, -3, -3, 3);
            Console.WriteLine("Таблица функции a*sin(x)");
            Table(delegate (double a, double x) { return a * Math.Sin(x); }, -3, -3, 3);

            // примеры из методички
            Console.WriteLine("Таблица функции MyFunc (x^3)");
            Table(new Fun(MyFunc), -2, 2);
            Console.WriteLine("Еще раз та же таблица, но вызов организован по новому.");
            Table(MyFunc, -2, 2);
            Console.WriteLine("Таблица фунции Sin:");
            Table(Math.Sin, -2, 2);
            Console.WriteLine("Таблица фунции x^2:");
            Table(delegate (double x) { return x * x; }, 0, 3);
        }
        public static void Table(Fun F, double x, double b)
        {
            Console.WriteLine("------- X ------ Y -----\n");
            while (x <= b)
            {
                Console.WriteLine("| {0,8:0.000} | {1,8:0.000} |", x, F(x));
                x += 1;
            }
            Console.WriteLine("------------------------\n");
        }

        public static double MyFunc(double x)
        {
            return x * x * x;
        }
    }
}
