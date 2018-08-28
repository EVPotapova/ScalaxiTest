using System;
using System.Text.RegularExpressions;
using TestCore;

//Разработать консольное приложение.С клавиатуры вводится произвольное арифметическое выражение со скобками.Проверить баланс скобок.
namespace Task4
{
    class Program
    {
        static void Main(string[] args)
        {
            var expression = Console.ReadLine();

            //Только баланс скобок.
            //TODO: Проверить направления
            var regex = new Regex(@"^(?:[^()]|(?<counter>\()|(?<-counter>\)))+(?(counter)(?!))$", RegexOptions.IgnorePatternWhitespace);

            Console.WriteLine("Result: " + (regex.IsMatch(expression) ? "Correct" : "Incorrect"));


            MessageHelper.AnyKey();
        }
    }
}
