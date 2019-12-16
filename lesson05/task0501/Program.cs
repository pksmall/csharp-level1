using UsefulMethods;

/*
 * Павел Корженко
 */

/*
 * 1. Создать программу, которая будет проверять корректность ввода логина. Корректным логином будет 
 *    строка от 2 до 10 символов, содержащая только буквы латинского алфавита или цифры, при этом цифра 
 *    не может быть первой:
 *    - а) без использования регулярных выражений;
 *    - б) с использованием регулярных выражений.
 */
namespace task0501
{
    class Program
    {
        static void Main(string[] args)
        {
            CheckLogin loginName = new CheckLogin();

            UseMethods.Print("Simpe check.");
            if (loginName.CheckLoginSimple())
            {
                UseMethods.Print($"Login name \x1b[1;12m'{loginName.GetUsername}'\x1b[0m is correct.");   
            }

            UseMethods.Print("Regex check.");
            if (loginName.CheckLoginRegEx())
            {
                UseMethods.Print($"Login name \x1b[1;12m'{loginName.GetUsername}'\x1b[0m is correct.");
            }
        }
    }
}
