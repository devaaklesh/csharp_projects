using System;
class Program
{
    static void Main()
    {
        int n,i;
        long fact=1;
        Console.Write("Enter number: ");
        n=int.Parse(Console.ReadLine());
        for(i=1;i<=n;i++)
            fact*=i;
        Console.WriteLine("Factorial: "+fact);
    }
}