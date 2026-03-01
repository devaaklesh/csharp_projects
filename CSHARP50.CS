using System;
using System.Collections.Generic;

// ===== Program: Hospital Management System =====
// Logic: Store patient records and display them

class Patient
{
    public int Id;
    public string Name;
    public string Disease;
}

class Program
{
    static List<Patient> patients = new List<Patient>();

    static void Main()
    {
        int choice;

        do
        {
            Console.WriteLine("\n===== HOSPITAL MENU =====");
            Console.WriteLine("1. Add Patient");
            Console.WriteLine("2. View Patients");
            Console.WriteLine("3. Exit");
            Console.Write("Enter choice: ");

            choice = Convert.ToInt32(Console.ReadLine());

            if (choice == 1)
            {
                Patient p = new Patient();

                Console.Write("Enter ID: ");
                p.Id = Convert.ToInt32(Console.ReadLine());

                Console.Write("Enter Name: ");
                p.Name = Console.ReadLine();

                Console.Write("Enter Disease: ");
                p.Disease = Console.ReadLine();

                patients.Add(p);

                Console.WriteLine("Patient Added Successfully.");
            }
            else if (choice == 2)
            {
                foreach (Patient p in patients)
                {
                    Console.WriteLine("ID: " + p.Id +
                                      " | Name: " + p.Name +
                                      " | Disease: " + p.Disease);
                }
            }

        } while (choice != 3);
    }
}