using System;
using System.Globalization;
using System.Linq;

namespace Task3
{
    //Разработать консольное приложение.Вычислить сумму чисел, переданных на вход как параметры командной строки.
    class Program
    {
        static void Main(string[] args)
        {
            try
            {
                if (args.Length > 0)
                {
                    var inputNums = args.Select(s => double.Parse(s, CultureInfo.InvariantCulture))
                                //Можно было бы использовать ConvertAll
                                //Но CultureInfo.InvariantCulture позволяет парсить числа с . и ,
                                .ToArray();

                    Console.WriteLine($"Sum {inputNums.Sum()}");
                }
            }
            catch (FormatException)
            {
                Console.WriteLine("Incorrect parameters. Use numbers only.");
            }
            finally
            {
                Console.ReadKey();
            }
        }
    }
}
