using System;
using TestCore;

namespace Task5
{
    //Разработать консольное приложение.
    //С клавиатуры вводится произвольная строка.
    //Вывести количество слов в строке.Учесть, что слова могут быть разделены пробелами или знаками препинания.
    class Program
    {
        static void Main(string[] args)
        {
            var text = Console.ReadLine();


            char[] delimiters = new char[] { ' ', '.', ',', '!', '?' , '—' };
            var res = text.Split(delimiters, StringSplitOptions.RemoveEmptyEntries).Length;
            Console.WriteLine($"Count of words {res}");
            MessageHelper.AnyKey();

        }
    }
}
