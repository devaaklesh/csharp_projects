using System;

// ===== Program: Find LCM =====
// Logic: LCM = (a * b) / GCD

class Program
{
    static void Main()
    {
        Console.Write("Enter first number: ");
        int a = Convert.ToInt32(Console.ReadLine());

        Console.Write("Enter second number: ");
        int b = Convert.ToInt32(Console.ReadLine());

        int x = a, y = b;

        while (y != 0)
        {
            int temp = y;
            y = x % y;
            x = temp;
        }

        int gcd = x;
        int lcm = (a * b) / gcd;

        Console.WriteLine("LCM = " + lcm);
    }
}