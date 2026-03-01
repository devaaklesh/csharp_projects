using System;

// ===== Program: Check Leap Year =====
// Logic: Year divisible by 4 and not by 100 unless divisible by 400

class Program
{
    static void Main()
    {
        Console.Write("Enter year: ");
        int year = Convert.ToInt32(Console.ReadLine());

        if ((year % 4 == 0 && year % 100 != 0) || (year % 400 == 0))
            Console.WriteLine(year + " is a Leap Year.");
        else
            Console.WriteLine(year + " is NOT a Leap Year.");
    }
}