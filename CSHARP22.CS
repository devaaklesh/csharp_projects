using System;

// ===== Program: Simple Calculator =====
// Logic: Use switch case for operations

class Program
{
    static void Main()
    {
        Console.Write("Enter first number: ");
        int num1 = Convert.ToInt32(Console.ReadLine());

        Console.Write("Enter second number: ");
        int num2 = Convert.ToInt32(Console.ReadLine());

        Console.Write("Choose operation (+, -, *, /): ");
        char op = Convert.ToChar(Console.ReadLine());

        int result = 0;

        switch (op)
        {
            case '+':
                result = num1 + num2;
                break;
            case '-':
                result = num1 - num2;
                break;
            case '*':
                result = num1 * num2;
                break;
            case '/':
                if (num2 != 0)
                    result = num1 / num2;
                else
                    Console.WriteLine("Cannot divide by zero!");
                break;
            default:
                Console.WriteLine("Invalid Operator!");
                return;
        }

        Console.WriteLine("Result: " + result);
    }
}