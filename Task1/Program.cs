using System;
using TestCore;

namespace Task1
{
    //Разработать консольное приложение.
    //С клавиатуры последовательно вводятся данные: имя, фамилия, возраст, рост, вес. 
    //Вывести данные одной строкой по центру.
    //Использовать форматный вывод.
    //Использовать интерполированные строки.
    class Program
    {
        static void Main(string[] args)
        {
            const int nameMaxLength = 35;
            const int numberMaxLength = 3;


            //TODO: Message
            string name = Console.ReadLine().Truncate(nameMaxLength);
            string surname = Console.ReadLine().Truncate(nameMaxLength);
            string age = Console.ReadLine().Truncate(numberMaxLength);
            string height = Console.ReadLine().Truncate(numberMaxLength);
            string weight = Console.ReadLine().Truncate(numberMaxLength);


            var formatResult = string.Format("{0} {1} {2} {3} {4}", name, surname, age, height, weight);
            var interResult = $"{name} {surname} {age} {height} {weight}";
            Console.SetCursorPosition((Console.WindowWidth - formatResult.Length) / 2, Console.CursorTop);
            Console.WriteLine(formatResult);
            Console.SetCursorPosition((Console.WindowWidth - interResult.Length) / 2, Console.CursorTop);
            Console.WriteLine(interResult);

            MessageHelper.AnyKey();
        }
    }
}
