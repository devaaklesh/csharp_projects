using System;

// ===== Program: Swapping Two Numbers Using Third Variable =====

class Program
{
    static void Main()
    {
        int a = 5;
        int b = 10;
        int temp;

        temp = a;
        a = b;
        b = temp;

        Console.WriteLine("After Swapping:");
        Console.WriteLine("a = " + a);
        Console.WriteLine("b = " + b);
    }
}