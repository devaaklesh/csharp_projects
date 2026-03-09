using System;
class Program
{
    static void Main()
    {
        int n,r,sum=0,temp;
        Console.Write("Enter number: ");
        n=int.Parse(Console.ReadLine());
        temp=n;
        while(n>0)
        {
            r=n%10;
            sum+=r*r*r;
            n/=10;
        }
        if(temp==sum)
            Console.WriteLine("Armstrong");
        else
            Console.WriteLine("Not Armstrong");
    }
}