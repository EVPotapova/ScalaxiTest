using System;
using System.IO;
using TestCore;

//Разработать консольное приложение.С клавиатуры вводится строка, представляющая собой корректный полный путь к файлу(стиль Windows). 
//Вывести следующую информацию: букву диска, количество папок на пути к файлу, имя файла без расширения, расширение файла.

namespace Task9
{
    class Program
    {
        static void Main(string[] args)
        {
            string path = Console.ReadLine().Trim('"');
            //Is correct

            if (!File.Exists(path))
            {
                Console.WriteLine("Incorrect path");
                MessageHelper.AnyKey();
                return;
            }

            Console.WriteLine(Path.GetPathRoot(path));
            var split = path.Split('\\');
            Console.WriteLine(split.Length-2);//Минус буква диска и файл
            Console.WriteLine(Path.GetFileNameWithoutExtension(path));
            if (Path.HasExtension(path))
                Console.WriteLine(Path.GetExtension(path));
            MessageHelper.AnyKey();
        }
    }
}
