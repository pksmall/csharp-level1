using System;

#region Name
/*
 * Павел Корженко
 */
#endregion

#region Task01
/* 
 * Task01()
 *   1. Написать программу «Анкета». Последовательно задаются вопросы (имя, фамилия, возраст, рост, вес).
 *      В результате вся информация выводится в одну строчку:
 *   а) используя склеивание;
 *   б) используя форматированный вывод;
 *   в) используя вывод со знаком $.
 */
#endregion

#region Task02
/* 
 * Task02()
 *   2. Ввести вес и рост человека. Рассчитать и вывести индекс массы тела (ИМТ) по формуле I=m/(h*h); где
 *   m — масса тела в килограммах, h — рост в метрах.
 */
#endregion

#region Task03
/*
 * Task03()  
 *   3.а) Написать программу, которая подсчитывает расстояние между точками с координатами x1, y1 и x2,y2
 *        по формуле r=Math.Sqrt(Math.Pow(x2-x1,2)+Math.Pow(y2-y1,2). Вывести результат, используя
 *        спецификатор формата .2f (с двумя знаками после запятой);
 *     б) *Выполнить предыдущее задание, оформив вычисления расстояния между точками в виде метода.
 */
#endregion

#region Task04
/*
 * Task04()
 *   4. Написать программу обмена значениями двух переменных:
 *     а) с использованием третьей переменной;
 *     б) *без использования третьей переменной.
 */
#endregion

#region Task05
/*
 * Task05()
 *  5. а) Написать программу, которая выводит на экран ваше имя, фамилию и город проживания.
 *     б) *Сделать задание, только вывод организовать в центре экрана.
 *     в) **Сделать задание б с использованием собственных методов (например, Print(string ms, int x,int y).
 */
#endregion

#region Task06
/* 
 * Task06()
 *  6. *Создать класс с методами, которые могут пригодиться в вашей учебе (Print, Pause).
 */
#endregion


namespace lession01
{
    class Program
    {
        static void Main(string[] args)
        {
            Task01();
            Task02();
            Task03();
            Task04();
            Task05();
        }

        static void Print(string msg)
        {
            Console.WriteLine(msg);
        }
        static void Print(String msg, bool h)
        {
            if (h)
            {
                Console.WriteLine($"\n{msg}");
            } else
            {
                Console.WriteLine(msg);
            }
        }
        /*
         * Print 
         * msg
         * x - если 0, то сообщение выводить в центре экрана 
         * y - если 0, то сообщение выводить в центре экрана
         * иначе по этим координатам.
         */
        static void Print(string msg, int x, int y)
        {
            if (x == 0 && y == 0)
            {
                int leftOffSet = (Console.WindowWidth / 2) - msg.Length / 2;
                int topOffSet = (Console.WindowHeight / 2);
                Console.SetCursorPosition(leftOffSet, topOffSet);
            } else
            {
                Console.SetCursorPosition(x, y);
            }
            Console.WriteLine(msg);
        }

        static void Task01()
        {
            Console.Write("Введите Ваше Имя:");
            string firstName = Console.ReadLine();
            Console.Write("Введите Вашу Фамилию:");
            string lastName = Console.ReadLine();
            Console.Write("Введите Ваш Возраст:");
            double age = double.Parse(Console.ReadLine());
            Console.Write("Введите Ваш Рост:");
            double hieght = double.Parse(Console.ReadLine());
            Console.Write("Введите Ваш Вес:");
            double volume = double.Parse(Console.ReadLine());
            String msg = String.Format("{0,5:G} {1,-10:G} {2,-5} {3,-5} {4,-5}\n", 
                "ФИО", "Возраст", "Возраст", "Рост", "Вес");
            msg += String.Format("{0,5:G} {1,-10:G} {2,-5} {3,-5} {4,-5:N0}\n", 
                firstName, lastName, age, hieght, volume);
            Print(msg);
            Print(msg, true);
        }

        static void Task02()
        {
            Console.Write("Введите Ваш Рост:");
            double hieght = double.Parse(Console.ReadLine());
            Console.Write("Введите Ваш Вес:");
            double volume = double.Parse(Console.ReadLine());
            double imt = volume / (hieght * hieght);
            String msg = String.Format("Ваш Индекс массы тела = {0,-10:N5}", imt);
            Print(msg);
        }

        static double CalcSqrt(double x1, double x2, double y1, double y2)
        {
            return Math.Sqrt(Math.Pow(x2 - x1, 2) + Math.Pow(y2 - y1, 2));
        }
        static void Task03()
        {
            Console.Write("Введите x1:");
            double x1 = double.Parse(Console.ReadLine());
            Console.Write("Введите x2:");
            double x2 = double.Parse(Console.ReadLine());
            Console.Write("Введите y1:");
            double y1 = double.Parse(Console.ReadLine());
            Console.Write("Введите y2:");
            double y2 = double.Parse(Console.ReadLine());
            double res = CalcSqrt(x1, x2, y1, y2);
            String msg = String.Format("Sqrt = {0, 10:N2}", res);
            Print(msg);
        }

        static void Task04()
        {
            int a = 5;
            int b = 6;
            int t;

            String msg = String.Format("Before swap -> A: {0} B: {1}", a, b);
            Print(msg);
            t = a;
            a = b;
            b = t;
            msg = String.Format("After swap  -> A: {0} B: {1}", a, b);
            Print(msg);

            a = a + b;
            b = a - b;
            a = a - b;
            msg = String.Format("Second swap -> A: {0} B: {1}", a, b);
            Print(msg);
        }

        static void Task05()
        {
            String msg = "My First Name and Sure name";
            Print(msg, 0, 0);
        }
    }

    // Task06
    class UseMethods
    {
        /*
         * Print 
         *  String msg - принемает просто строку
         */
        static void Print(string msg)
        {
            Console.WriteLine(msg);
        }

        /*
         * Print 
         *  String msg - принемает просто строку 
         *  bool h - флаг true / false если надо добавить знак $ 
         */
        static void Print(String msg, bool h)
        {
            if (h)
            {
                Console.WriteLine($"\n{msg}");
            }
            else
            {
                Console.WriteLine(msg);
            }
        }
        
        /*
         * Pause
         *  ждем ввода символа
         */
        static void Pause()
        {
            Console.ReadKey();
        }
    }
}
