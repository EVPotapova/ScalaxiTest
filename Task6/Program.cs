//Разработать консольное приложение.
//    С клавиатуры вводится произвольное целое число.
//    Вывести сумму цифр числа.
//    Подсчет суммы цифр оформить отдельным методом, реализовать 2 варианта подсчета суммы цифр.
using System;
using System.Linq;
using TestCore;

namespace Task6
{
    class Program
    {
        static void Main(string[] args)
        {
            string numberStr = Console.ReadLine();

            if (!int.TryParse(numberStr, out var number))
            {
                Console.WriteLine("Incorrect number");
                MessageHelper.AnyKey();
                return;
            }


            Console.WriteLine($"Sum via first method {SumDigits(number)}");
            Console.WriteLine($"Sum via second method {SumDigitsFromString(numberStr)}");
            MessageHelper.AnyKey();

        }


        public static int SumDigitsFromString(string number)
        {
            number = number.Replace("-", "");
            return number.Sum(c => (int)char.GetNumericValue(c));
        }

        public static int SumDigits(int number)
        {
            number = Math.Abs(number);
            int sum = 0;
            while (number != 0)
            {
                int rem;
                number = Math.DivRem(number, 10, out rem);
                sum += rem;
            }
            return sum;
        }
    }
}
