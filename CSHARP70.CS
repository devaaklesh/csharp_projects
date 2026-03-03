using System;

class KMP
{
    static void ComputeLPS(string pat, int[] lps)
    {
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
    }

    static void Main()
    {
        string txt = "ABABDABACDABABCABAB";
        string pat = "ABABCABAB";

        int[] lps = new int[pat.Length];
        ComputeLPS(pat, lps);

        int i = 0, j = 0;
        while (i < txt.Length)
        {
            if (pat[j] == txt[i]) { i++; j++; }
            if (j == pat.Length)
            {
                Console.WriteLine("Found at " + (i - j));
                j = lps[j - 1];
            }
            else if (i < txt.Length && pat[j] != txt[i])
                j = (j != 0) ? lps[j - 1] : 0;
        }
    }
}