using System;
class Program
{
    static void Main()
    {
        int n,i,flag=0;
        Console.Write("Enter number: ");
        n=int.Parse(Console.ReadLine());
        for(i=2;i<=n/2;i++)
        {
            if(n%i==0)
            {
                flag=1;
                break;
            }
        }
        if(flag==0 && n!=1)
            Console.WriteLine("Prime");
        else
            Console.WriteLine("Not Prime");
    }
}