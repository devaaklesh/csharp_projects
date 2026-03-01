using System;

// ===== Program: Sum of Array Elements =====

class Program
{
    static void Main()
    {
        int[] numbers = { 1, 2, 3, 4, 5 };
        int sum = 0;

        foreach (int num in numbers)
        {
            sum = sum + num;
        }

        Console.WriteLine("Sum = " + sum);
    }
}