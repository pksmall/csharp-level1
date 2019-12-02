using System;

/*
 * Павел Корженко
 */

/*
 * 5. 
 *   - а) Написать программу, которая запрашивает массу и рост человека, вычисляет его индекс массы и сообщает, 
 *       нужно ли человеку похудеть, набрать вес или все в норме;
 *   - б) *Рассчитать, на сколько кг похудеть или сколько кг набрать для нормализации веса.*
 */

namespace task05
{
    class Program
    {
        private const double V1 = 24.99;
        private const double V2 = 18.6;
        public static double BIG_IMT => V1;
        public static double LOW_IMT => V2;

        static void Main(string[] args)
        {
            Task05();
        }

        /*
         * ImtCalc 
         *  return body mass index
         *   volume in kg
         *   height ing cm
         */
        static double ImtCalc(double volume, double height)
        {
            return volume / (height / 100 * height / 100);
        }

        static void Task05()
        {
            Console.Write("Введите Ваш Рост в см:");
            double height = double.Parse(Console.ReadLine());
            Console.Write("Введите Ваш Вес в кг:");
            double volume = double.Parse(Console.ReadLine());
            double imt = ImtCalc(volume, height);
            String msg = String.Format("Ваш Индекс массы тела = {0,-6:N2} кг/м2", imt);
            Print(msg);

            double normVal = 0;
            if (imt > BIG_IMT)
            {
                normVal = Normalize(volume, height, BIG_IMT);
                msg = String.Format("Ваш Индекс массы тела выше нормы, надо скинуть {0,-2:N0} кг.", normVal);
                Print(msg);
            } else if (imt < LOW_IMT)
            {
                normVal = Normalize(volume, height, LOW_IMT);
                msg = String.Format("Ваш Индекс массы тела ниже нормы, надо набрать {0,-2:N0} кг.", normVal);
                Print(msg);
            }
            else
            {
                msg = String.Format("Ваш Индекс массы тела идельный, вам не надо полнеть или худеть.");
                Print(msg);
            }
        }

        /*
         * Normalize
         *   v volume of mass
         *   h height
         *   n bmi normalize value
         */
        static double Normalize(double v, double h, double n)
        {
            double normVal = v;
            double valStep = 1;
            double imt = n;
            var retVal = 0.0;

            if (n >= BIG_IMT)
            {
                do
                {
                    normVal -= valStep;
                    imt = ImtCalc(normVal, h);
                } while (imt >= BIG_IMT);
                retVal = v - normVal;
            } else if (n <= LOW_IMT)
            {
                do
                {
                    normVal += valStep;
                    imt = ImtCalc(normVal, h);
                } while (imt <= LOW_IMT);
                retVal =  (v - normVal) * -1;
            }

            return retVal;
        }
        static void Print(string msg)
        {
            Console.WriteLine(msg);
        }
    }
}
