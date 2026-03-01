using System;

// ===== Program: Find Second Largest Number =====
// Logic: Track largest and second largest separately

class Program
{
    static void Main()
    {
        int[] numbers = { 10, 45, 23, 89, 67 };

        int largest = int.MinValue;
        int secondLargest = int.MinValue;

        foreach (int num in numbers)
        {
            if (num > largest)
            {
                secondLargest = largest;
                largest = num;
            }
            else if (num > secondLargest && num != largest)
            {
                secondLargest = num;
            }
        }

        Console.WriteLine("Largest: " + largest);
        Console.WriteLine("Second Largest: " + secondLargest);
    }
}