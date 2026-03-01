using System;

// ===== Program: Factorial Using Recursion =====
// Logic: n! = n * factorial(n-1)

class Program
{
    static void Main()
    {
        Console.Write("Enter a number: ");
        int num = Convert.ToInt32(Console.ReadLine());

        int result = Factorial(num);

        Console.WriteLine("Factorial = " + result);
    }

    static int Factorial(int n)
    {
        if (n == 0 || n == 1)
            return 1;
        else
            return n * Factorial(n - 1);
    }
}