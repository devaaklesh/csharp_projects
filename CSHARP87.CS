using System;

class Program
{
    static int[] ComputeLPS(string pat)
    {
        int[] lps = new int[pat.Length];
        int len = 0, i = 1;

        while (i < pat.Length)
        {
            if (pat[i] == pat[len])
                lps[i++] = ++len;
            else if (len != 0)
                len = lps[len - 1];
            else
                lps[i++] = 0;
        }
        return lps;
    }

    static void Main()
    {
        string txt = "ABABDABACDABABCABAB";
        string pat = "ABABCABAB";

        int[] lps = ComputeLPS(pat);
        int i = 0, j = 0;

        while (i < txt.Length)
        {
            if (pat[j] == txt[i]) { i++; j++; }
            if (j == pat.Length)
            {
                Console.WriteLine(i - j);
                j = lps[j - 1];
            }
            else if (i < txt.Length && pat[j] != txt[i])
                j = j != 0 ? lps[j - 1] : 0;
        }
    }
}