using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Lesson0301
{

    class Worker
    {
        public Worker(string Name, int Age, int Salary)
        {
            //this.Name = Name;
            //this.Age = Age;
            //this.Salary = Salary;

            name = Name;
            age = Age;
            salary = Salary;
        }

        public Worker() { }

        public string Print()
        {
            return $"Name: {name} Age: {age} Salary: {salary}";
            //return $"Name: {this.name} Age: {this.age} Salary: {this.salary}";
        }

        public string name;
        public int age;
        public int salary;
    }


    struct Complex
    {
        public double a, b;

        public Complex(double v1, double v2) 
        {
            a = v1;b = v2;
        }

        public string Print()
        {
            return $"{a} + {b}i";
        }

        public static  Complex Sum(Complex N1, Complex N2)
        {
            return new Complex(N1.a + N2.a, N1.b + N2.b);
        }

    }



    class Program
    {
        #region MyRegion


        static string GetTime()
        {
            return DateTime.Now.ToLongTimeString();
        }



        static void PrintCenter(double msg, int offset)
        {
            Console.SetCursorPosition(Console.WindowWidth / 2 - msg.ToString().Length / 2, Console.WindowHeight / 2 - offset);
            Console.WriteLine(msg);
        }
        static void PrintCenter(string msg, int offset)
        {
            Console.SetCursorPosition(Console.WindowWidth / 2 - msg.Length / 2, Console.WindowHeight / 2 - offset);
            Console.WriteLine(msg);
        }

        static double F(double x)
        {
            return x * x;
        }

        static double G(double x, double y)
        {
            return x + y;
        }

        static void Pause()
        {
            Console.ReadKey();
        }
        #endregion

        public  static void Swap(ref int Value1, ref int Value2)
        {
            int temp = Value1;
            Value1 = Value2;
            Value2 = temp;
        }


        static void Print(int a)
        {
            Console.Write("+ ");
            if (a < 100) Print(++a);
        }


        static void Print(int a, int b)
        {
            Console.WriteLine(a);

            if (a < b) Print(++a, b);

        }

        static int Sum(int a, int b)
        {
            if (a == b) return 1;
            else return Sum(++a, b) + a;
        }

        static int SumDown(int a, int b)
        {
            Console.WriteLine($"a = {a} b = {b}");

            if (b <= a) return 1;
            else return b + SumDown(a, --b);
        }

        static void Main(string[] args)
        {
            //Console.WriteLine(SumDown(1, 5));

            //int n ; //Convert.ToInt32(Console.ReadLine());

            //var flag = int.TryParse(Console.ReadLine(), out n);
            //Console.WriteLine(flag ? "Данные хорошие" : "Данные плохие");


            //Console.ReadLine();
            //#region MyRegion


            //int a = 1, b = 2;
            //Swap(ref a, ref b);
            
            //Print(1,10);





            Complex z1 = new Complex(1, 2); Console.WriteLine(z1.Print());
            Complex z2 = new Complex(5, 9); Console.WriteLine(z2.Print());

            Complex z3 = Complex.Sum(z1, z2);
            Console.WriteLine(z3.Print());


            //Worker worker1 = new Worker()
            //{
            //    name = "Джон",
            //    age = 22,
            //    salary = 1000
            //};

            //Worker worker2 = new Worker("Боб", 22, 2000);

            //Console.WriteLine(worker1.Print());
            //Console.WriteLine(worker2.Print());

            #endregion


            #region MyRegion

            //int c = 1;
            //int d = 2;

            //Console.WriteLine($"a = {c}  b = {d}");

            //Swap(ref c, ref d);
            //Console.WriteLine($"a = {c}  b = {d}");


            //int a = 1;
            //int b = 2;

            //Console.WriteLine($"a = {a}  b = {b}");

            //Swap(ref a, ref b);
            //Console.WriteLine($"a = {a}  b = {b}");


            #endregion

            #region MyRegion

            //string s = GetTime(); PrintCenter(s, 0);



            //Console.ReadLine();



            //double res = G(12, 33);//f(2.2);
            //PrintCenter(res, 0);




            //Console.ReadLine();
            //Pause();

            #endregion

        }
    }
}
