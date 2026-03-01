using System;
using System.IO;

// ===== Program: File Handling =====
// Logic:
// 1. Write text into file
// 2. Read file content
// 3. Display content

class Program
{
    static void Main()
    {
        string path = "data.txt";

        // Writing to file
        File.WriteAllText(path, "Hello Avinash!\nWelcome to C# File Handling.");

        Console.WriteLine("Data Written to File.");

        // Reading from file
        string content = File.ReadAllText(path);

        Console.WriteLine("\nFile Content:");
        Console.WriteLine(content);
    }
}