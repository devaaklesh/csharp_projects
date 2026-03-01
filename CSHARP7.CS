using System;

// ===== Program: Function with Parameters =====

class Program
{
    static void Main()
    {
        Add(5, 3);
    }

    static void Add(int a, int b)
    {
        int sum = a + b;
        Console.WriteLine("Sum = " + sum);
    }
}