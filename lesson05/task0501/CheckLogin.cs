using System;
using System.Text.RegularExpressions;
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
    class CheckLogin
    {
        string username;

        public CheckLogin()
        {
            username = "";
        }

        public string GetUsername
        {
            get
            {
                return username;
            }
        }

        public bool CheckLoginSimple()
        {
            bool letterOrDigits = true;

            do
            {
                username = UseMethods.GetValue("Введите логин: ");
                letterOrDigits = true;
                foreach (char c in username)
                {
                    if (!char.IsLetterOrDigit(c))
                    {
                        letterOrDigits = false;
                    }
                }

            } while (username.Length < 2 || username.Length > 10 || Char.IsDigit(username[0]) || !letterOrDigits);

            return true;

        }

        public bool CheckLoginRegEx()
        {
            Regex regex = new Regex(@"^[a-zA-Z][0-9a-zA-Z]{2,9}$");
            do
            {
                username = UseMethods.GetValue("Введите логин: ");

            } while (!regex.IsMatch(username));

            return true;
        }
    }
}
