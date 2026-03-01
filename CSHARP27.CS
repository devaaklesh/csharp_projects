using System;

// ===== Program: Constructor Example =====
// Logic: Constructor initializes values when object is created

class Person
{
    string name;

    public Person(string n)
    {
        name = n;
    }

    public void Show()
    {
        Console.WriteLine("Name is: " + name);
    }
}

class Program
{
    static void Main()
    {
        Person p1 = new Person("Avinash");
        p1.Show();
    }
}