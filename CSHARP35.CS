using System;

// ===== Program: Check Perfect Number =====
// Logic: Sum of proper divisors = number
// Example: 6 → 1 + 2 + 3 = 6

class Program
{
    static void Main()
    {
        Console.Write("Enter a number: ");
        int num = Convert.ToInt32(Console.ReadLine());

        int sum = 0;

        for (int i = 1; i < num; i++)
        {
            if (num % i == 0)
            {
                sum += i;
            }
        }

        if (sum == num)
            Console.WriteLine(num + " is a Perfect Number.");
        else
            Console.WriteLine(num + " is NOT a Perfect Number.");
    }
}