using System;

class Program
{
    static int[] tree;
    static int n;

    static void Build(int[] arr)
    {
        for (int i = 0; i < n; i++)
            tree[n + i] = arr[i];

        for (int i = n - 1; i > 0; --i)
            tree[i] = tree[i << 1] + tree[i << 1 | 1];
    }

    static int Query(int l, int r)
    {
        int sum = 0;
        for (l += n, r += n; l < r; l >>= 1, r >>= 1)
        {
            if ((l & 1) == 1) sum += tree[l++];
            if ((r & 1) == 1) sum += tree[--r];
        }
        return sum;
    }

    static void Main()
    {
        int[] arr = {1,3,5,7,9,11};
        n = arr.Length;
        tree = new int[2*n];
        Build(arr);
        Console.WriteLine(Query(1,4));
    }
}