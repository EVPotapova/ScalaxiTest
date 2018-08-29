using System;
using System.Collections.Generic;
using System.Globalization;
using System.Linq;
using TestCore;

//Разработать консольное приложение.
//    С клавиатуры последовательно(по одному числу в строке) вводятся числа до тех пор, пока вводимая последовательность чисел остается монотонной.
//    Вывести сумму чисел введенной монотонной последовательности.
namespace Task8
{
    class Program
    {
        //Не строго монотонная
        static void Main(string[] args)
        {
            List<double> nums = new List<double>();

            while (true)
            {
                //Is number?
                if (!double.TryParse(Console.ReadLine(), NumberStyles.Number, CultureInfo.InvariantCulture, out var number))
                {
                    break;
                }
                //Is mono?
                else if (nums.Any() && nums.Count > 1)
                {
                    var last = nums[nums.Count - 1];
                    var prelast = nums[nums.Count - 2];
                    if (!(((last <= prelast) && (number <= last)) || ((last >= prelast) && (number >= last))))
                    {
                        break;
                    }
                }
                nums.Add(number);

            }

            Console.WriteLine($"Sum {nums.Sum()}");

            MessageHelper.AnyKey();
        }

    }


}
