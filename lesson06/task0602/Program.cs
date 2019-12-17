using System;
using System.IO;

/*
 * Павел Корженко
 */

/*
 * 2. Модифицировать программу нахождения минимума функции так, чтобы можно было передавать функцию 
 *    в виде делегата.
 *   - а) Сделать меню с различными функциями и представить пользователю выбор, для какой функции и 
 *        на каком отрезке находить минимум. Использовать массив(или список) делегатов, в котором хранятся 
 *        различные функции.
 *   - б) *Переделать функцию Load, чтобы она возвращала массив считанных значений.Пусть она возвращает 
 *        минимум через параметр(с использованием модификатора out). 
 */

namespace task0602
{
    public delegate double Fun(double x);

    class Program
    {
        public static double A(double x)
        {
            return x * Math.Sin(x) - 10 * x + 10;
        }
        public static double B(double x)
        {
            return x * x - 5 * Math.Cos(x) + 10;
        }
        public static double C(double x)
        {
            return x * x - 50 * x + 10;
        }

        public static void SaveFunc(string fileName, Fun F, double a, double b, double h)
        {
            FileStream fs = new FileStream(fileName, FileMode.Create, FileAccess.Write);
            BinaryWriter bw = new BinaryWriter(fs);
            double x = a;
            while(x <= b)
            {
                bw.Write(F(x));
                x += h;
            }
            bw.Close();
            fs.Close();
        }
        
        public static double[] Load(string fileName, out double min)
        {
            FileStream fs = new FileStream(fileName, FileMode.Open, FileAccess.Read);
            BinaryReader bw = new BinaryReader(fs);
            double[] retArr = new double[fs.Length / sizeof(double)];
            min = double.MaxValue;
            for (int i = 0; i < fs.Length/sizeof(double); i++)
            {
                retArr[i] = bw.ReadDouble();
                if (retArr[i] < min)
                {
                    min = retArr[i];
                }
            }
            bw.Close();
            fs.Close();
            return retArr;
        }

        static void Main(string[] args)
        {
            string fileName = "data.bin";

            Console.WriteLine("Выберете функцию для нахождения минимума: ");
            Console.WriteLine(" 1 -> x * sin(x) - 10 * x + 10 ");
            Console.WriteLine(" 2 -> x * x - 5 * cos(x) + 10 ");
            Console.WriteLine(" 3 -> x * x - 50 * x + 10 ");
            Console.Write("Ваш выбор? ");
            int idx = Int32.Parse(Console.ReadLine());

            Fun F = A;
            switch (idx)
            {
                case 2:
                    F = B;
                    break;
                case 3:
                    F = C;
                    break;
            }
            SaveFunc(fileName, F, -100, 100, 0.5);

            double Min;
            double[] arr = Load(fileName, out Min);
            Console.WriteLine("Min: {0,8:0.000}", Min);
            foreach(double e in arr)
            {
                Console.Write("{0,8:0.000} ", e);
            }
        }
    }
}
