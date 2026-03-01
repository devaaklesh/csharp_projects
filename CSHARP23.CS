using System;

// ===== Program: Find Sum of Digits =====
// Logic: Extract each digit using % and add them

class Program
{
    static void Main()
    {
        Console.Write("Enter a number: ");
        int num = Convert.ToInt32(Console.ReadLine());

        int sum = 0;

        while (num > 0)
        {
            int digit = num % 10;  // get last digit
            sum = sum + digit;     // add digit
            num = num / 10;        // remove last digit
        }

        Console.WriteLine("Sum of digits = " + sum);
    }
}