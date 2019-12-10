using System;
using System.IO;
using System.Linq;

/*
 * Павел Корженко
 */

/*
 * 4. Решить задачу с логинами из урока 2, только логины и пароли считать из 
 *    файла в массив. Создайте структуру Account, содержащую Login и Password.
 */

namespace task0404
{
    class Program
    {
        static void Main(string[] args)
        {
            string accountFile = "../../../../../account.txt";

            GetLoginPass();
            
            try
            {
                string[] arr = ReadArrayFromFile(accountFile);
                if (Task04(arr[0], arr[1]))
                {
                    Console.WriteLine("Login Successful!");
                }
                else
                {
                    Console.WriteLine("Account not found.");
                }
            } catch (Exception ex)
            {
                Console.WriteLine($"File {accountFile} not found.");
                Console.WriteLine($"{ex}");
            }
        }
        struct Account
        {
            static readonly string Login = "root";
            static readonly string Password = "GeekBrains";

            public static string getLogin()
            {
                return Login;
            }

            public static string getPassword()
            {
                return Password;
            }
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
                }
                else
                {
                    Console.WriteLine("Try again.");
                    tryCount--;
                }
            } while (tryCount != 0);
        }

        public static string[] ReadArrayFromFile(string fileName)
        {
            string[] retArr;
            try
            {
                retArr = File.ReadLines(fileName).Select(l => Convert.ToString(l)).ToArray();
            }
            catch (Exception ex)
            {
                retArr = new string[0];
                Console.WriteLine($"File {fileName} not found. {ex}");
            }
            return retArr;
        }

        static bool Task04(String login, String password)
        {
            if (Account.getLogin() == login && Account.getPassword() == password)
            {
                return true;
            }
            else
            {
                return false;
            }
        }
    }

}
