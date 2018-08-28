using System;

namespace Task2
{
    //Разработать консольное приложение.Ввести с клавиатуры число n, вывести n-ый член последовательность Фибоначчи.
    //Вычислить, используя рекурсию.
    //Вычислить без рекурсии.
    //(*) Вычислить, используя формулу Бине.

    class Program
    {
        static void Main(string[] args)
        {
            string positionStr = Console.ReadLine();
            var res = int.TryParse(positionStr, out int position);
            if (!res || position < 1)
            {
                //TODO: Message
                Console.ReadLine();
                return;
            }

            int left = 1;
            int right = 1;
            int pos = 2;
            int sum = 0;
            while (pos < position)
            {
                sum = left + right;
                left = right;
                right = sum;
                pos += 1;
            }
            Console.WriteLine($"Without recursion {sum}");

            Console.WriteLine($"With recursion {Fib(position)}");


            //Формула Бине
            var bSum = (Math.Pow(((1 + Math.Sqrt(5)) / 2), position) - Math.Pow(((1 - Math.Sqrt(5)) / 2), position)) / (Math.Sqrt(5));


            Console.WriteLine($"Binet {bSum}");
            Console.ReadLine();
        }

        private static int Fib(int position)
        {
            if (position == 1 || position == 2)
            {
                return 1;
            }
            else
            {
                return Fib(position - 1) + Fib(position - 2);
            }
        }
    }
}
