using System;

class Program
{
    static void Main()
    {
        string txt = "GEEKS FOR GEEKS";
        string pat = "GEEK";
        int d = 256, q = 101;

        int m = pat.Length, n = txt.Length;
        int p = 0, t = 0, h = 1;

        for (int i = 0; i < m - 1; i++)
            h = (h * d) % q;

        for (int i = 0; i < m; i++)
        {
            p = (d * p + pat[i]) % q;
            t = (d * t + txt[i]) % q;
        }

        for (int i = 0; i <= n - m; i++)
        {
            if (p == t)
            {
                int j;
                for (j = 0; j < m; j++)
                    if (txt[i + j] != pat[j])
                        break;
                if (j == m)
                    Console.WriteLine(i);
            }
            if (i < n - m)
            {
                t = (d * (t - txt[i] * h) + txt[i + m]) % q;
                if (t < 0) t += q;
            }
        }
    }
}