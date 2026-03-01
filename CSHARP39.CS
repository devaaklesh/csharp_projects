using System;

// ===== Program: Decimal to Binary =====
// Logic: Divide by 2 and store remainders

class Program
{
    static void Main()
    {
        Console.Write("Enter a decimal number: ");
        int num = Convert.ToInt32(Console.ReadLine());

        string binary = "";

        while (num > 0)
        {
            binary = (num % 2) + binary;
            num = num / 2;
        }

        Console.WriteLine("Binary = " + binary);
    }
}