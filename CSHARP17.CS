using System;

// ===== Program: Check Armstrong Number =====
// Logic: Sum of cubes of digits = Original number (Example: 153)

class Program
{
    static void Main()
    {
        Console.Write("Enter a number: ");
        int num = Convert.ToInt32(Console.ReadLine());

        int original = num;
        int sum = 0;

        while (num > 0)
        {
            int digit = num % 10;          // Extract last digit
            sum = sum + (digit * digit * digit);  // Cube and add
            num = num / 10;               // Remove last digit
        }

        if (sum == original)
            Console.WriteLine(original + " is an Armstrong Number.");
        else
            Console.WriteLine(original + " is NOT an Armstrong Number.");
    }
}