using System;

// ===== Program: Count Number of Digits =====
// Logic: Divide number by 10 until it becomes 0

class Program
{
    static void Main()
    {
        Console.Write("Enter a number: ");
        int num = Convert.ToInt32(Console.ReadLine());

        int count = 0;

        while (num > 0)
        {
            num = num / 10;
            count++;
        }

        Console.WriteLine("Total digits = " + count);
    }
}