using System;
class Program
{
    static void Main()
    {
        int a,b,c;
        Console.Write("Enter first number: ");
        a=int.Parse(Console.ReadLine());
        Console.Write("Enter second number: ");
        b=int.Parse(Console.ReadLine());
        Console.Write("Enter third number: ");
        c=int.Parse(Console.ReadLine());
        if(a>b && a>c)
            Console.WriteLine("Largest: "+a);
        else if(b>c)
            Console.WriteLine("Largest: "+b);
        else
            Console.WriteLine("Largest: "+c);
    }
}