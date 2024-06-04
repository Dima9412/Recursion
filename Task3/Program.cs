// Задача 3: Задайте произвольный массив. Выведете его элементы, начиная с конца.
// Использовать рекурсию, не использовать циклы.

using System;
using System.Linq;

class Program
{
    static void Main(string[] args)
    {
        int[] array = {1, 2, 5, 0, 10, 34};
        Console.WriteLine(String.Join(", ", ReversePrint(array)));
    }

    private static string ReversePrint(int[] array)
    {
        if (array.Length > 0)
        {
            return $"{array[array.Length - 1]}, {ReversePrint(array.Take(array.Length - 1).ToArray())}";
        }
        else
        {
            return "";
        }
    }
}