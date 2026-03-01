using System;

// ===== Program: Inheritance Example =====
// Logic:
// 1. Create base class
// 2. Derived class inherits properties
// 3. Use object of derived class

class Person
{
    public string name;
    public int age;

    public void GetDetails()
    {
        Console.Write("Enter Name: ");
        name = Console.ReadLine();

        Console.Write("Enter Age: ");
        age = Convert.ToInt32(Console.ReadLine());
    }

    public void Display()
    {
        Console.WriteLine("Name: " + name);
        Console.WriteLine("Age: " + age);
    }
}

class Student : Person
{
    public int marks;

    public void GetMarks()
    {
        Console.Write("Enter Marks: ");
        marks = Convert.ToInt32(Console.ReadLine());
    }

    public void ShowResult()
    {
        Display();
        Console.WriteLine("Marks: " + marks);
    }
}

class Program
{
    static void Main()
    {
        Student s = new Student();

        s.GetDetails();
        s.GetMarks();
        s.ShowResult();
    }
}