using System;

class Program
{
    // Method 1: Swap using a temporary variable
    static void SwapWithTemp(ref int a, ref int b)
    {
        int temp = a;
        a = b;
        b = temp;
    }

    // Method 2: Swap without using a temporary variable (arithmetic method)
    static void SwapWithoutTemp(ref int a, ref int b)
    {
        // Prevent overflow by using 'checked'
        checked
        {
            a = a + b;
            b = a - b;
            a = a - b;
        }
    }

    static void Main()
    {
        try
        {
            Console.Write("Enter first integer: ");
            if (!int.TryParse(Console.ReadLine(), out int num1))
            {
                Console.WriteLine("Invalid input. Please enter an integer.");
                return;
            }

            Console.Write("Enter second integer: ");
            if (!int.TryParse(Console.ReadLine(), out int num2))
            {
                Console.WriteLine("Invalid input. Please enter an integer.");
                return;
            }

            Console.WriteLine($"\nBefore swapping: num1 = {num1}, num2 = {num2}");

            // Swap using temp variable
            SwapWithTemp(ref num1, ref num2);
            Console.WriteLine($"After SwapWithTemp: num1 = {num1}, num2 = {num2}");

            // Swap back without temp variable
            SwapWithoutTemp(ref num1, ref num2);
            Console.WriteLine($"After SwapWithoutTemp: num1 = {num1}, num2 = {num2}");
        }
        catch (OverflowException)
        {
            Console.WriteLine("Error: Integer overflow occurred during swapping.");
        }
        catch (Exception ex)
        {
            Console.WriteLine($"Unexpected error: {ex.Message}");
        }
    }
}
