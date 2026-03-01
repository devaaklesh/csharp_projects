using System;

// ===== Program: Student Grade System =====
// Logic:
// 1. Take marks for 5 subjects
// 2. Calculate total and average
// 3. Assign grade based on average

class Program
{
    static void Main()
    {
        int total = 0;
        int subjects = 5;

        for (int i = 1; i <= subjects; i++)
        {
            Console.Write("Enter marks for subject " + i + ": ");
            int marks = Convert.ToInt32(Console.ReadLine());

            // Validate marks
            if (marks < 0 || marks > 100)
            {
                Console.WriteLine("Invalid marks! Enter between 0 and 100.");
                i--; // repeat same subject
                continue;
            }

            total += marks;
        }

        double average = total / (double)subjects;

        Console.WriteLine("Total Marks = " + total);
        Console.WriteLine("Average Marks = " + average);

        if (average >= 90)
            Console.WriteLine("Grade: A+");
        else if (average >= 75)
            Console.WriteLine("Grade: A");
        else if (average >= 60)
            Console.WriteLine("Grade: B");
        else if (average >= 50)
            Console.WriteLine("Grade: C");
        else
            Console.WriteLine("Grade: Fail");
    }
}