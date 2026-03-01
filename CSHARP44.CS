using System;

// ===== Program: Simple ATM System =====
// Logic:
// 1. User has initial balance
// 2. Show menu options
// 3. Perform deposit/withdraw
// 4. Validate sufficient balance

class Program
{
    static void Main()
    {
        double balance = 10000; // initial balance
        int choice;

        do
        {
            Console.WriteLine("\n===== ATM MENU =====");
            Console.WriteLine("1. Check Balance");
            Console.WriteLine("2. Deposit");
            Console.WriteLine("3. Withdraw");
            Console.WriteLine("4. Exit");
            Console.Write("Enter choice: ");

            choice = Convert.ToInt32(Console.ReadLine());

            switch (choice)
            {
                case 1:
                    Console.WriteLine("Current Balance: " + balance);
                    break;

                case 2:
                    Console.Write("Enter deposit amount: ");
                    double deposit = Convert.ToDouble(Console.ReadLine());

                    if (deposit > 0)
                    {
                        balance += deposit;
                        Console.WriteLine("Amount Deposited Successfully.");
                    }
                    else
                    {
                        Console.WriteLine("Invalid Amount.");
                    }
                    break;

                case 3:
                    Console.Write("Enter withdrawal amount: ");
                    double withdraw = Convert.ToDouble(Console.ReadLine());

                    if (withdraw > balance)
                    {
                        Console.WriteLine("Insufficient Balance.");
                    }
                    else if (withdraw > 0)
                    {
                        balance -= withdraw;
                        Console.WriteLine("Withdrawal Successful.");
                    }
                    else
                    {
                        Console.WriteLine("Invalid Amount.");
                    }
                    break;

                case 4:
                    Console.WriteLine("Thank You for Using ATM.");
                    break;

                default:
                    Console.WriteLine("Invalid Choice.");
                    break;
            }

        } while (choice != 4);
    }
}