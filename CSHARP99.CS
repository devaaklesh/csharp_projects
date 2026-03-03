using System;

class Program
{
    static int[] BIT;
    static int n;

    static void Update(int i, int val)
    {
        for (; i <= n; i += i & -i)
            BIT[i] += val;
    }

    static int Query(int i)
    {
        int sum = 0;
        for (; i > 0; i -= i & -i)
            sum += BIT[i];
        return sum;
    }

    static void Main()
    {
        int[] arr = {1,2,3,4,5};
        n = arr.Length;
        BIT = new int[n+1];

        for (int i = 0; i < n; i++)
            Update(i+1, arr[i]);

        Console.WriteLine(Query(3));
    }
}