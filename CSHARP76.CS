using System;

class SegmentTree
{
    static int[] tree;
    static int n;

    static void Build(int[] arr)
    {
        n = arr.Length;
        tree = new int[2 * n];
        for (int i = 0; i < n; i++)
            tree[n + i] = arr[i];

        for (int i = n - 1; i > 0; i--)
            tree[i] = tree[i * 2] + tree[i * 2 + 1];
    }

    static int Query(int l, int r)
    {
        int sum = 0;
        l += n;
        r += n;

        while (l <= r)
        {
            if ((l % 2) == 1) sum += tree[l++];
            if ((r % 2) == 0) sum += tree[r--];
            l /= 2;
            r /= 2;
        }
        return sum;
    }

    static void Main()
    {
        int[] arr = { 1, 3, 5, 7, 9, 11 };
        Build(arr);
        Console.WriteLine(Query(1, 3));
    }
}