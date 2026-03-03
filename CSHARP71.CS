using System;

class RabinKarp
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
                if (txt.Substring(i, m) == pat)
                    Console.WriteLine("Match at " + i);

            if (i < n - m)
            {
                t = (d * (t - txt[i] * h) + txt[i + m]) % q;
                if (t < 0) t += q;
            }
        }
    }
}