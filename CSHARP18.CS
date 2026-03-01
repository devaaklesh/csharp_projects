using System;

// ===== Program: Reverse a String =====
// Logic: Traverse string from last to first

class Program
{
    static void Main()
    {
        Console.Write("Enter a string: ");
        string input = Console.ReadLine();

        string reverse = "";

        for (int i = input.Length - 1; i >= 0; i--)
        {
            reverse = reverse + input[i];
        }

        Console.WriteLine("Reversed String: " + reverse);
    }
}