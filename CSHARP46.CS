using System;
using System.Collections.Generic;

// ===== Program: Library Management System =====
// Logic:
// 1. Store books in List
// 2. Add, View, Search books
// 3. Use loop menu system

class Book
{
    public int Id;
    public string Title;
    public string Author;
}

class Program
{
    static List<Book> library = new List<Book>();

    static void Main()
    {
        int choice;

        do
        {
            Console.WriteLine("\n===== LIBRARY MENU =====");
            Console.WriteLine("1. Add Book");
            Console.WriteLine("2. View Books");
            Console.WriteLine("3. Search Book");
            Console.WriteLine("4. Exit");
            Console.Write("Enter choice: ");

            choice = Convert.ToInt32(Console.ReadLine());

            switch (choice)
            {
                case 1:
                    AddBook();
                    break;

                case 2:
                    ViewBooks();
                    break;

                case 3:
                    SearchBook();
                    break;

                case 4:
                    Console.WriteLine("Exiting Library System.");
                    break;

                default:
                    Console.WriteLine("Invalid choice.");
                    break;
            }

        } while (choice != 4);
    }

    static void AddBook()
    {
        Book b = new Book();

        Console.Write("Enter Book ID: ");
        b.Id = Convert.ToInt32(Console.ReadLine());

        Console.Write("Enter Book Title: ");
        b.Title = Console.ReadLine();

        Console.Write("Enter Author Name: ");
        b.Author = Console.ReadLine();

        library.Add(b);

        Console.WriteLine("Book Added Successfully!");
    }

    static void ViewBooks()
    {
        if (library.Count == 0)
        {
            Console.WriteLine("No Books Available.");
            return;
        }

        foreach (Book b in library)
        {
            Console.WriteLine("ID: " + b.Id + 
                              " | Title: " + b.Title + 
                              " | Author: " + b.Author);
        }
    }

    static void SearchBook()
    {
        Console.Write("Enter Book ID to search: ");
        int id = Convert.ToInt32(Console.ReadLine());

        foreach (Book b in library)
        {
            if (b.Id == id)
            {
                Console.WriteLine("Book Found:");
                Console.WriteLine("Title: " + b.Title);
                Console.WriteLine("Author: " + b.Author);
                return;
            }
        }

        Console.WriteLine("Book Not Found.");
    }
}