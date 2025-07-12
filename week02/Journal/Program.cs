using System;
using System.Collections.Generic;
using System.Reflection.Metadata.Ecma335;

class Program
{
    static void Main(string[] args)
    {
        Console.WriteLine("Hello World! This is the Journal Project.");
        Console.WriteLine();

        List<string> prompts = new List<string>
        {
            "Who was the most interesting person I interacted with today?",
            "What was the best part of my day?",
            "How did I see the hand of the Lord in my life today?",
            "What was the strongest emotion I felt today?",
            "If I had one thing I could do over today, what would it be?",

            // this is the creativity
            
            "What was the most interesting thing that happened today?",
            "Was there any opportunity for service? What did I do? Why?",
            "What is one thing you're grateful about? Why?"
        };


        Journal journal = new Journal();
        string list = "";
        while (list != "5")
        {
            Console.WriteLine("Please select one of the following choices: ");

            Console.WriteLine("\nPlease select one of the following:");
            Console.WriteLine("1) Write: ");
            Console.WriteLine("2) Display: ");
            Console.WriteLine("3) Save: ");
            Console.WriteLine("4) Load: ");
            Console.WriteLine("5) Quit: ");
            Console.WriteLine();
            Console.Write("What would you like to do?: ");
            list = Console.ReadLine();

            switch (list)
            {
                case "1":
                    string prompt = prompts[new Random().Next(prompts.Count)];
                    Console.WriteLine($"{prompt}");
                    Console.Write("> ");
                    string response = Console.ReadLine();
                    journal.AddEntry(new Entry(prompt, response));
                    break;

                case "2":
                    journal.DisplayJournal();
                    break;
                case "3":
                    Console.Write("Enter filename: ");
                    string saveFile = Console.ReadLine();
                    break;

                case "4":
                    Console.Write("What is the filename?: ");
                    string loadFile = Console.ReadLine();
                    // journal.LoadFromFile(loadFile);
                    break;

                case "5":
                    Console.WriteLine("");
                    break;
            }
        }
    }
}