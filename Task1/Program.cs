// Задача 1: Задайте значения M и N. Напишите программу, которая выведет все натуральные числа
// в промежутке от M до N. Использовать рекурсию, не использовать циклы.

using System;

class Program
{
    static void Main(string[] args)
    {
        Console.Write("Введите начальное число: ");
        int m = int.Parse(Console.ReadLine());
        Console.Write("Введите конечное число: ");
        int n = int.Parse(Console.ReadLine());

        PrintNumbers(m, n);
    }

    private static void PrintNumbers(int m, int n)
    {
        if (m <= n)
        {
            Console.Write(m + ",");
            m++;
            PrintNumbers(m, n);
        }
    }
}

