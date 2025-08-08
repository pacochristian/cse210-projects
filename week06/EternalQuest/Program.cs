using System;

class Program
{
    static void Main(string[] args)
    {
        Console.WriteLine("Hello World! This is the EternalQuest Project.");
        GoalManager manager = new GoalManager();
        int choice = 0;

        while (choice != 5)
        {
            Console.WriteLine("Choose an option:");
            Console.WriteLine("1. Create a new goal");
            Console.WriteLine("2. Record an event");
            Console.WriteLine("3. List all goals");
            Console.WriteLine("4. Save goals");
            Console.WriteLine("5. Exit");

            Console.WriteLine();
            if (int.TryParse(Console.ReadLine(), out choice))
            {
                switch (choice)
                {
                    case 1:
                        manager.CreateGoal();
                        break;
                    case 2:
                        manager.RecordEvent();
                        break;
                    case 3:
                        manager.ListGoals();
                        break;
                    case 4:
                        manager.SaveGoals();
                        break;
                    case 5:
                        Console.WriteLine("Exiting the program.");
                        break;
                    default:
                        Console.WriteLine("Invalid choice. Please try again.");
                        break;
                }
            }
            else
            {
                Console.WriteLine("Please enter a valid number.");
            }
        }
    }
}