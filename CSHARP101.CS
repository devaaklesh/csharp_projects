using System;

// CSHARP101.CS
// Problem statement: Demonstrate static methods
// This file is created after the existing numbered C# files in the workspace.

public class Program
{
    public static void Main(string[] args)
    {
        Console.WriteLine("CSHARP101 - Demonstrate static methods");
        Console.WriteLine("5 + 7 = " + Add(5, 7));
        Console.WriteLine("10 * 3 = " + Multiply(10, 3));
        DisplayMessage();
    }

    static int Add(int x, int y)
    {
        return x + y;
    }

    static int Multiply(int x, int y)
    {
        return x * y;
    }

    static void DisplayMessage()
    {
        Console.WriteLine("Static methods can be called without creating an instance of a class.");
    }
}
