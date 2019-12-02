using System;

/*
 * Павел Корженко
 */

/*
 * 4. Реализовать метод проверки логина и пароля. На вход подается логин и пароль. На выходе истина, если прошел
 * авторизацию, и ложь, если не прошел (Логин: root, Password: GeekBrains). Используя метод проверки логина и
 * пароля, написать программу: пользователь вводит логин и пароль, программа пропускает его дальше или не пропускает.
 * С помощью цикла do while ограничить ввод пароля тремя попытками.
 */
namespace task04
{
    class Program
    {
        static void Main(string[] args)
        {
            GetLoginPass();
        }

        static void GetLoginPass()
        {
            int tryCount = 3;

            do
            {
                Console.Write("Login: ");
                String login = Console.ReadLine();
                Console.Write("Password: ");
                String password = Console.ReadLine();
                if (Task04(login, password))
                {
                    Console.WriteLine("Login Successful!");
                    break;
                } else
                {
                    Console.WriteLine("Try again.");
                    tryCount--;
                }
            } while (tryCount != 0);
        }

        /*
         * Task04
         *  check login and password
         *  return true or false
         */
        static bool Task04(String login, String password)
        {
            String l = "root";
            String p = "GeekBrains";

            if (login == l && password == p)
            {
                return true;
            } else
            {
                return false;
            }
        }
    }
}
