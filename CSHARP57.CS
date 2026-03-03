using System;

class Knapsack
{
    static int Solve(int W, int[] wt, int[] val, int n)
    {
        int[,] K = new int[n + 1, W + 1];

        for (int i = 0; i <= n; i++)
            for (int w = 0; w <= W; w++)
            {
                if (i == 0 || w == 0)
                    K[i, w] = 0;
                else if (wt[i - 1] <= w)
                    K[i, w] = Math.Max(val[i - 1] + K[i - 1, w - wt[i - 1]], K[i - 1, w]);
                else
                    K[i, w] = K[i - 1, w];
            }

        return K[n, W];
    }

    static void Main()
    {
        int[] val = { 60, 100, 120 };
        int[] wt = { 10, 20, 30 };
        Console.WriteLine(Solve(50, wt, val, 3));
    }
}