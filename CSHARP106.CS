using System;
class Program
{
    static void Main()
    {
        int n,sum=0,r;
        Console.Write("Enter number: ");
        n=int.Parse(Console.ReadLine());
        while(n>0)
        {
            r=n%10;
            sum+=r;
            n/=10;
        }
        Console.WriteLine("Sum: "+sum);
    }
}