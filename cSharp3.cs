using System;

// ===== Program: Swapping Two Numbers Without Third Variable =====

class Program
{
    static void Main()
    {
        int a = 5;
        int b = 10;

        Console.WriteLine("Before Swapping:");
        Console.WriteLine("a = " + a);
        Console.WriteLine("b = " + b);

        a = a + b;
        b = a - b;
        a = a - b;

        Console.WriteLine("After Swapping:");
        Console.WriteLine("a = " + a);
        Console.WriteLine("b = " + b);
    }
}