using System;

// ===== Program: Polymorphism using Method Overloading =====
// Logic: Same method name but different parameters

class Calculator
{
    public int Add(int a, int b)
    {
        return a + b;
    }

    public double Add(double a, double b)
    {
        return a + b;
    }

    public int Add(int a, int b, int c)
    {
        return a + b + c;
    }
}

class Program
{
    static void Main()
    {
        Calculator calc = new Calculator();

        Console.WriteLine("Add 2 ints: " + calc.Add(5, 10));
        Console.WriteLine("Add 2 doubles: " + calc.Add(5.5, 2.3));
        Console.WriteLine("Add 3 ints: " + calc.Add(1, 2, 3));
    }
}