using System;

class Program
{
    static void Main(string[] args)
    {
        Console.WriteLine("Hello World! This is the Exercise2 Project.");
        Console.WriteLine(); // To create an empty line or space
        Console.Write("What is your grade percentage?: ");

        string input = Console.ReadLine(); //Read user input
        int grade = int.Parse(input); //Convert to integer
        string letter = "";
        if (grade >= 90)
        {
            letter = "A";
        }
        else if (grade >= 80)
        {
            letter = "B";
        }
        else if (grade >= 70)
        {
            letter = "C";

        }
        else if (grade >= 60)
        {
            letter = "D";
        }
        else
        {
            letter = "F";
        }
        Console.WriteLine();
        Console.WriteLine($"Your grade is {letter}");
        Console.WriteLine();

        if (grade >= 70)
        {
            Console.Write("🎉Congratulations! You've passed the course. Keep up the great work!");
        }
        else
        {
            Console.Write("💡Don't get discouraged. Every setback is a setup for a comeback. You'll do even better next time!");
        }

        //Stretch Challenge

        string sign = "";
        int lastDigit = grade % 10; //gets the last digit
        if (lastDigit >= 7)
        {
            sign = "+";
        }
        else if (lastDigit < 3)
        {
            sign = "-";
        }
        Console.Write($" Your grade is: {letter}{sign}");
    }
}