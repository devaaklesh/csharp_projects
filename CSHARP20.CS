using System;

// ===== Program: Count Even and Odd Numbers =====
// Logic: Use modulus operator %

class Program
{
    static void Main()
    {
        int[] numbers = { 1, 2, 3, 4, 5, 6, 7, 8 };

        int even = 0;
        int odd = 0;

        foreach (int num in numbers)
        {
            if (num % 2 == 0)
                even++;
            else
                odd++;
        }

        Console.WriteLine("Even Numbers: " + even);
        Console.WriteLine("Odd Numbers: " + odd);
    }
}