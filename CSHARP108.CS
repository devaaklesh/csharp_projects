using System;
class Program
{
    static void Main()
    {
        int n,count=0;
        Console.Write("Enter number: ");
        n=int.Parse(Console.ReadLine());
        while(n>0)
        {
            count++;
            n/=10;
        }
        Console.WriteLine("Digits: "+count);
    }
}