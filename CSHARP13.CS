using System;

// ===== Program: Check Palindrome Number =====
// Logic: Reverse the number and compare with original

class Program
{
    static void Main()
    {
        Console.Write("Enter a number: ");
        int num = Convert.ToInt32(Console.ReadLine());

        int original = num;
        int reverse = 0;

        while (num > 0)
        {
            int digit = num % 10;      // get last digit
            reverse = reverse * 10 + digit;
            num = num / 10;           // remove last digit
        }

        if (original == reverse)
            Console.WriteLine("It is a Palindrome Number.");
        else
            Console.WriteLine("It is NOT a Palindrome Number.");
    }
}