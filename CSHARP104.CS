using System;
class Program
{
    static void Main()
    {
        int n,rev=0,r,temp;
        Console.Write("Enter number: ");
        n=int.Parse(Console.ReadLine());
        temp=n;
        while(n>0)
        {
            r=n%10;
            rev=rev*10+r;
            n/=10;
        }
        if(temp==rev)
            Console.WriteLine("Palindrome");
        else
            Console.WriteLine("Not Palindrome");
    }
}