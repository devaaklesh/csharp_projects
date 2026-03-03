using System;

class MatrixChain
{
    static void Main()
    {
        int[] p = { 1, 2, 3, 4 };
        int n = p.Length - 1;
        int[,] m = new int[n, n];

        for (int L = 2; L <= n; L++)
        {
            for (int i = 0; i < n - L + 1; i++)
            {
                int j = i + L - 1;
                m[i, j] = int.MaxValue;

                for (int k = i; k < j; k++)
                {
                    int q = m[i, k] + m[k + 1, j] + p[i] * p[k + 1] * p[j + 1];
                    if (q < m[i, j])
                        m[i, j] = q;
                }
            }
        }

        Console.WriteLine(m[0, n - 1]);
    }
}