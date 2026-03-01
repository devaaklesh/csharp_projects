using System;

// ===== Program: Check Anagram =====
// Logic: Sort both strings and compare

class Program
{
    static void Main()
    {
        Console.Write("Enter first string: ");
        string str1 = Console.ReadLine().ToLower();

        Console.Write("Enter second string: ");
        string str2 = Console.ReadLine().ToLower();

        char[] arr1 = str1.ToCharArray();
        char[] arr2 = str2.ToCharArray();

        Array.Sort(arr1);
        Array.Sort(arr2);

        string sorted1 = new string(arr1);
        string sorted2 = new string(arr2);

        if (sorted1 == sorted2)
            Console.WriteLine("Strings are Anagrams.");
        else
            Console.WriteLine("Strings are NOT Anagrams.");
    }
}