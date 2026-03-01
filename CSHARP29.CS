using System;

// ===== Program: Swap Two Numbers Using ref Parameter =====
// Logic: ref allows method to modify original variables

class Program
{
    static void Main()
    {
        int a = 10;
        int b = 20;

        Console.WriteLine("Before Swap: a = " + a + ", b = " + b);

        Swap(ref a, ref b);

        Console.WriteLine("After Swap: a = " + a + ", b = " + b);
    }

    static void Swap(ref int x, ref int y)
    {
        int temp = x;
        x = y;
        y = temp;
    }
}