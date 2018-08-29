using System;

namespace TestCore
{
    public static class MessageHelper
    {
        public static void AnyKey()
        {
            Console.WriteLine("\nPress any key to continue...");
            Console.ReadKey();
        }
    }
}
