using System;
using Fundamentals.Core.Guards;

namespace Fundamentals.Core.Printers
{
    public static class Printer<T>
    {
        public static void PrintArrayToConsole(T[] array)
        {
            Guard.IsNotNull(array, nameof(array));

            foreach (var a in array)
            {
                Console.Write($"{a}, ");
            }
            Console.WriteLine();
        }
    }
}
