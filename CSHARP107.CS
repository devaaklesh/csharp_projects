using System;
class Program
{
    static void Main()
    {
        int n;
        Console.Write("Enter number: ");
        n=int.Parse(Console.ReadLine());
        if(n%2==0)
            Console.WriteLine("Even");
        else
            Console.WriteLine("Odd");
    }
}