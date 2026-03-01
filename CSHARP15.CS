using System;

// ===== Program: Linear Search in Array =====
// Logic: Check each element one by one

class Program
{
    static void Main()
    {
        int[] numbers = { 10, 20, 30, 40, 50 };

        Console.Write("Enter number to search: ");
        int search = Convert.ToInt32(Console.ReadLine());

        bool found = false;

        for (int i = 0; i < numbers.Length; i++)
        {
            if (numbers[i] == search)
            {
                Console.WriteLine("Element found at index " + i);
                found = true;
                break;
            }
        }

        if (!found)
        {
            Console.WriteLine("Element not found in array.");
        }
    }
}