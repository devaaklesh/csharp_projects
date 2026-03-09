using System;
class Program
{
    static void Main()
    {
        int n,rev=0,r;
        Console.Write("Enter number: ");
        n=int.Parse(Console.ReadLine());
        while(n>0)
        {
            r=n%10;
            rev=rev*10+r;
            n/=10;
        }
        Console.WriteLine("Reverse: "+rev);
    }
}