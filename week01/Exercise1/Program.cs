using System;

class Program
{
    static void Main(string[] args)
    {
        Console.WriteLine("Hello World! This is the Exercise1 Project.");

        Console.WriteLine("");

        Console.Write("What is your first name? ");
        string name = Console.ReadLine();
        Console.Write("What is your last name? ");
        string Last_name = Console.ReadLine();

        Console.WriteLine("");

        Console.WriteLine($"Your name is {Last_name}, {name} {Last_name}. ");

        Console.WriteLine("");

        Console.Write("What is your first name? ");
        string First_name = Console.ReadLine();
        Console.Write("What is your last name? ");
        string last_Name = Console.ReadLine();

        Console.WriteLine("");

        Console.WriteLine($"Your name is {last_Name}, {First_name} {last_Name}. ");

    }
}