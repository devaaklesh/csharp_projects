using System;
class Program
{
    static void Main()
    {
        int n,i;
        Console.Write("Enter number: ");
        n=int.Parse(Console.ReadLine());
        for(i=1;i<=10;i++)
            Console.WriteLine(n+" x "+i+" = "+(n*i));
    }
}