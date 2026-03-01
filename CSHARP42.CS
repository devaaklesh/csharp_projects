using System;

// ===== Program: Menu Driven Calculator =====
// Logic:
// 1. Show menu
// 2. Take user choice
// 3. Perform operation using switch
// 4. Repeat until user exits

class Program
{
    static void Main()
    {
        int choice;

        do
        {
            Console.WriteLine("\n===== CALCULATOR MENU =====");
            Console.WriteLine("1. Addition");
            Console.WriteLine("2. Subtraction");
            Console.WriteLine("3. Multiplication");
            Console.WriteLine("4. Division");
            Console.WriteLine("5. Exit");
            Console.Write("Enter your choice: ");

            choice = Convert.ToInt32(Console.ReadLine());

            if (choice >= 1 && choice <= 4)
            {
                Console.Write("Enter first number: ");
                double num1 = Convert.ToDouble(Console.ReadLine());

                Console.Write("Enter second number: ");
                double num2 = Convert.ToDouble(Console.ReadLine());

                double result = 0;

                switch (choice)
                {
                    case 1:
                        result = num1 + num2;
                        Console.WriteLine("Addition Result = " + result);
                        break;

                    case 2:
                        result = num1 - num2;
                        Console.WriteLine("Subtraction Result = " + result);
                        break;

                    case 3:
                        result = num1 * num2;
                        Console.WriteLine("Multiplication Result = " + result);
                        break;

                    case 4:
                        if (num2 != 0)
                        {
                            result = num1 / num2;
                            Console.WriteLine("Division Result = " + result);
                        }
                        else
                        {
                            Console.WriteLine("Error: Cannot divide by zero.");
                        }
                        break;
                }
            }
            else if (choice != 5)
            {
                Console.WriteLine("Invalid Choice! Try again.");
            }

        } while (choice != 5);

        Console.WriteLine("Calculator Closed.");
    }
}