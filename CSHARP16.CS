using System;

// ===== Program: Bubble Sort =====
// Logic: Compare adjacent elements and swap if needed

class Program
{
    static void Main()
    {
        int[] numbers = { 5, 2, 8, 1, 3 };

        for (int i = 0; i < numbers.Length - 1; i++)
        {
            for (int j = 0; j < numbers.Length - 1 - i; j++)
            {
                if (numbers[j] > numbers[j + 1])
                {
                    // Swap
                    int temp = numbers[j];
                    numbers[j] = numbers[j + 1];
                    numbers[j + 1] = temp;
                }
            }
        }

        Console.WriteLine("Sorted Array:");
        foreach (int num in numbers)
        {
            Console.Write(num + " ");
        }
    }
}