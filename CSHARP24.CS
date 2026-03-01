using System;

// ===== Program: Check Even or Odd =====
// Logic: If number % 2 == 0 → Even else Odd

class Program
{
    static void Main()
    {
        Console.Write("Enter a number: ");
        int num = Convert.ToInt32(Console.ReadLine());

        if (num % 2 == 0)
            Console.WriteLine(num + " is Even.");
        else
            Console.WriteLine(num + " is Odd.");
    }
}