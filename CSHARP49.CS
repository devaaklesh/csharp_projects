using System;

// ===== Program: Interface Example =====
// Logic:
// 1. Define interface
// 2. Implement in class
// 3. Call using object

interface IShape
{
    void Area();
}

class Circle : IShape
{
    public void Area()
    {
        Console.Write("Enter radius: ");
        double r = Convert.ToDouble(Console.ReadLine());

        double area = 3.14 * r * r;
        Console.WriteLine("Circle Area = " + area);
    }
}

class Program
{
    static void Main()
    {
        Circle c = new Circle();
        c.Area();
    }
}