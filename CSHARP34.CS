using System;

// ===== Program: Check Strong Number =====
// Logic: Sum of factorial of digits = Original number
// Example: 145 → 1! + 4! + 5! = 145

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
            int digit = num % 10;
            sum += Factorial(digit);
            num = num / 10;
        }

        if (sum == original)
            Console.WriteLine(original + " is a Strong Number.");
        else
            Console.WriteLine(original + " is NOT a Strong Number.");
    }

    static int Factorial(int n)
    {
        int fact = 1;
        for (int i = 1; i <= n; i++)
        {
            fact *= i;
        }
        return fact;
    }
}