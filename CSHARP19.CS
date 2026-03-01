using System;

// ===== Program: Find Largest Element in Array =====
// Logic: Compare each element with current max

class Program
{
    static void Main()
    {
        int[] numbers = { 12, 45, 7, 89, 23 };

        int max = numbers[0];

        for (int i = 1; i < numbers.Length; i++)
        {
            if (numbers[i] > max)
            {
                max = numbers[i];  // Update max value
            }
        }

        Console.WriteLine("Largest number is: " + max);
    }
}