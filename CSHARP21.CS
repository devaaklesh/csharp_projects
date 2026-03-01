using System;

// ===== Program: Matrix Addition (2x2) =====
// Logic: Add corresponding elements

class Program
{
    static void Main()
    {
        int[,] A = { {1, 2}, {3, 4} };
        int[,] B = { {5, 6}, {7, 8} };
        int[,] C = new int[2, 2];

        for (int i = 0; i < 2; i++)
        {
            for (int j = 0; j < 2; j++)
            {
                C[i, j] = A[i, j] + B[i, j];
            }
        }

        Console.WriteLine("Result Matrix:");

        for (int i = 0; i < 2; i++)
        {
            for (int j = 0; j < 2; j++)
            {
                Console.Write(C[i, j] + " ");
            }
            Console.WriteLine();
        }
    }
}