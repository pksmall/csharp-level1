using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

/*
 * Павел Корженко
 */

/*
 * 1. 
 *   - а) Дописать структуру Complex, добавив метод вычитания комплексных чисел. 
 *        Продемонстрировать работу структуры;
 *   - б) Дописать класс Complex, добавив методы вычитания и произведения чисел. 
 *        Проверить работу класса;
 */

namespace task0301
{
    struct ComplexA
    {
        public double a, b;

        public ComplexA(double v1, double v2) 
        {
            a = v1;
            b = v2;
        }

        public string SumPrint()
        {
            return $"{a} + {b}i";
        }
        public string SubPrint()
        {
            return $"{a} - {b}i";
        }

        public string MulPrint()
        {
            return $"{a} * {b}i";
        }

        public static  ComplexA Sum(ComplexA N1, ComplexA N2)
        {
            return new ComplexA(N1.a + N2.a, N1.b + N2.b);
        }
        public static ComplexA Sub(ComplexA N1, ComplexA N2)
        {
            return new ComplexA(N1.a - N2.a, N1.b - N2.b);
        }
        public static ComplexA Mul(ComplexA N1, ComplexA N2)
        {
            return new ComplexA(N1.a * N2.a, N1.b * N2.b);
        }

    }
    class ComplexB
    {
        public double a, b;

        public ComplexB(double v1, double v2)
        {
            a = v1;
            b = v2;
        }

        public string SumPrint()
        {
            return $"{a} + {b}i";
        }
        public string SubPrint()
        {
            return $"{a} - {b}i";
        }

        public string MulPrint()
        {
            return $"{a} * {b}i";
        }

        public static ComplexB Sum(ComplexB N1, ComplexB N2)
        {
            return new ComplexB(N1.a + N2.a, N1.b + N2.b);
        }
        public static ComplexB Sub(ComplexB N1, ComplexB N2)
        {
            return new ComplexB(N1.a - N2.a, N1.b - N2.b);
        }
        public static ComplexB Mul(ComplexB N1, ComplexB N2)
        {
            return new ComplexB(N1.a * N2.a, N1.b * N2.b);
        }

    }



    class Program
    {
        static void Pause()
        {
            Console.ReadKey();
        }

        static void Main(string[] args)
        {
            // show struct work
            ComplexA z1 = new ComplexA(1, 2); 
            Console.WriteLine("Z1 = " + z1.SumPrint());
            ComplexA z2 = new ComplexA(5, 9); 
            Console.WriteLine("Z2 = " + z2.SubPrint());

            ComplexA z3 = ComplexA.Sum(z1, z2);
            Console.WriteLine("Z3 = " + z3.SumPrint());

            ComplexA z4 = ComplexA.Sub(z1, z2);
            Console.WriteLine("Z4 = " + z4.SubPrint());

            ComplexA z5 = ComplexA.Mul(z1, z2);
            Console.WriteLine("Z5 = " + z5.MulPrint());

            // show class work
            ComplexB x1 = new ComplexB(1, 2);
            Console.WriteLine("X1 = " + x1.SumPrint());
            ComplexB x2 = new ComplexB(5, 9);
            Console.WriteLine("X2 = " + x2.SubPrint());

            ComplexB x3 = ComplexB.Sum(x1, x2);
            Console.WriteLine("X3 = " + x3.SumPrint());

            ComplexB x4 = ComplexB.Sub(x1, x2);
            Console.WriteLine("X4 = " + z4.SubPrint());

            ComplexB x5 = ComplexB.Mul(x1, x2);
            Console.WriteLine("X5 = " + z5.MulPrint());

        }
    }
}
