using System;

class BoyerMoore
{
    static int[] BadChar(string pat)
    {
        int[] bad = new int[256];
        for (int i = 0; i < 256; i++) bad[i] = -1;
        for (int i = 0; i < pat.Length; i++)
            bad[pat[i]] = i;
        return bad;
    }

    static void Main()
    {
        string txt = "HERE IS A SIMPLE EXAMPLE";
        string pat = "EXAMPLE";
        int[] bad = BadChar(pat);

        int shift = 0;
        while (shift <= txt.Length - pat.Length)
        {
            int j = pat.Length - 1;
            while (j >= 0 && pat[j] == txt[shift + j])
                j--;

            if (j < 0)
            {
                Console.WriteLine("Match at " + shift);
                shift += (shift + pat.Length < txt.Length) ?
                    pat.Length - bad[txt[shift + pat.Length]] : 1;
            }
            else
                shift += Math.Max(1, j - bad[txt[shift + j]]);
        }
    }
}