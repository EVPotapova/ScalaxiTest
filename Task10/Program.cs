//(*) Разработать консольное приложение.С клавиатуры вводится число.Вывести 0, если это число 0, иначе вывести 1. 
//    Не использовать явным образом циклы, сравнения и условные операторы.
using System;
using TestCore;

namespace Task10
{
    class Program
    {
        static void Main(string[] args)
        {
            //TODO: TO Core
            string numberStr = Console.ReadLine();
            if (!int.TryParse(numberStr, out var number))
            {

                Console.WriteLine("Incorrect number");
                MessageHelper.AnyKey();
                return;
            }

            Console.WriteLine(Convert.ToInt32(Convert.ToBoolean(number)));

            MessageHelper.AnyKey();
        }
    }
}
