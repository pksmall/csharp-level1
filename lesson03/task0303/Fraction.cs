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
    class Fraction
    {
        int numerator;
        int denominator;
        int remainder;

        public Fraction() { }

        public Fraction(int num, int den)
        {
            if (den == 0) throw new ArgumentException("Знаменатель не может быть равен 0");
            numerator = num;
            denominator = den;
            remainder = 0;
        }

        public int Numerator
        {
            get
            {
                return numerator;
            }

            set
            {
                numerator = value;
            }
        }

        public int Denominator
        {
            get
            {
                return denominator;
            }

            set
            {
                denominator = value;
            }
        }

        public int Remainder
        {
            get
            {
                return remainder;
            }

            set
            {
                remainder = value;
            }
        }

        public string Print()
        {
            if (numerator > denominator)
            {
                return Simple();
            }
            else
            {
                int nod = Nod(numerator, denominator);
                if (nod > 1)
                {
                    return $"{numerator}/{denominator} -> {numerator/nod}/{denominator/nod}";

                }
                else
                {
                    return $"{numerator}/{denominator}";
                }
            }
        }

        public static int Nod(int x, int y)
        {
            if (x == y)
            {
                return x;
            } else
            {
                if (x > y)
                {
                    return Nod(x-y, y);
                } else
                {
                    return Nod(x, y-x);
                }
            }
        }

        public string Simple()
        {
            int quotient = Math.DivRem(numerator, denominator, out remainder);
            int nod = Nod(remainder, denominator); 
            if (nod > 1)
            {
                return $"{numerator}/{denominator} -> {quotient} {remainder}/{denominator} -> {quotient} {remainder / nod}/{denominator / nod}";
            }
            else
            {
                return $"{numerator}/{denominator} -> {quotient} {remainder}/{denominator}";
            }
        }

        public static Fraction Plus(Fraction frac1, Fraction frac2)
        {
            Fraction dr = new Fraction();

            if (frac1.Denominator != frac2.Denominator)
            {
                dr.Numerator = frac1.Numerator * frac2.Denominator + frac2.Numerator * frac1.Denominator;
                dr.Denominator = frac1.Denominator * frac2.Denominator;
            }
            else
            {
                dr.Numerator = frac1.Numerator + frac2.Numerator;
                dr.Denominator = frac1.Denominator;
            }
            return dr;
        }
        public static Fraction Minus(Fraction frac1, Fraction frac2)
        {
            Fraction dr = new Fraction();

            if (frac1.Denominator != frac2.Denominator)
            {
                dr.Numerator = frac1.Numerator * frac2.Denominator - frac2.Numerator * frac1.Denominator;
                dr.Denominator = frac1.Denominator * frac2.Denominator;
            }
            else
            {
                dr.Numerator = frac1.Numerator - frac2.Numerator;
                dr.Denominator = frac1.Denominator;
            }
            return dr;
        }
        public static Fraction Multi(Fraction frac1, Fraction frac2)
        {
            Fraction dr = new Fraction();

            if (frac1.Denominator != frac2.Denominator)
            {
                dr.Numerator = frac1.Numerator * frac2.Numerator;
                dr.Denominator = frac1.Denominator * frac2.Denominator;
            } else
            {
                dr.Numerator = frac1.Numerator * frac2.Numerator;
                dr.Denominator = frac1.Denominator;
            }

            return dr;
        }

        public static Fraction Devide(Fraction frac1, Fraction frac2)
        {
            Fraction dr = new Fraction();

            if (frac1.Denominator != frac2.Denominator)
            {
                dr.Numerator = frac1.Numerator * frac2.Denominator;
                dr.Denominator = frac1.Denominator * frac2.Numerator;
            }
            else
            {
                dr.Numerator = frac1.Numerator / frac2.Numerator;
                dr.Denominator = frac1.Denominator;
            }
            return dr;
        }
    }
}
