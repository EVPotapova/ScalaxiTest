//Разработать консольное приложение.
//    С клавиатуры вводится произвольная строка.Проверить, что она представляет собой корректный ip-адрес(IPv4).
using System;
using System.Text.RegularExpressions;
using TestCore;

namespace Task7
{
    class Program
    {
        static void Main(string[] args)
        {
            string str = Console.ReadLine();

            //Без указания длины маски подсети
            Regex ip = new Regex(@"^(?:(?:25[0-5]|2[0-4][0-9]|[01]?[0-9][0-9]?)\.){3}(?:25[0-5]|2[0-4][0-9]|[01]?[0-9][0-9]?)$");

            Console.WriteLine(ip.IsMatch(str.Trim()) ? "Correct" : "Incorrect");

            MessageHelper.AnyKey();
        }
    }
}
