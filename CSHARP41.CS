using System;

// ===== Program: Number Guessing Game =====
// Logic: Compare user guess with random number

class Program
{
    static void Main()
    {
        Random rnd = new Random();
        int secret = rnd.Next(1, 101);  // Random number between 1 and 100

        int guess;

        do
        {
            Console.Write("Guess the number (1-100): ");
            guess = Convert.ToInt32(Console.ReadLine());

            if (guess > secret)
                Console.WriteLine("Too High!");
            else if (guess < secret)
                Console.WriteLine("Too Low!");
            else
                Console.WriteLine("Correct Guess!");
        }
        while (guess != secret);
    }
}