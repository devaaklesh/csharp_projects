using System;

// ===== Program: Class and Object Example =====
// Logic: Create class with method and call using object

class Student
{
    public string name;
    public int marks;

    public void Display()
    {
        Console.WriteLine("Name: " + name);
        Console.WriteLine("Marks: " + marks);
    }
}

class Program
{
    static void Main()
    {
        Student s1 = new Student();

        s1.name = "Avinash";
        s1.marks = 85;

        s1.Display();
    }
}