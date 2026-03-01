using System;

// ===== Program: Find Factorial of a Number =====
// Logic: Factorial of n = n * (n-1) * (n-2) * ... * 1

class Program
{
    static void Main()
    {
        Console.Write("Enter a number: ");
        int num = Convert.ToInt32(Console.ReadLine());

        int factorial = 1;

        if (num < 0)
        {
            Console.WriteLine("Factorial not defined for negative numbers.");
        }
        else
        {
            for (int i = 1; i <= num; i++)
            {
                factorial = factorial * i;  // multiply each number
            }

            Console.WriteLine("Factorial of " + num + " is " + factorial);
        }
    }
}