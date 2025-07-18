using System;

class Program
{
    // Creative Extension:
    // - Smart word hiding that avoids already-hidden words.
    // - Motivational messages to inspire scripture mastery.

    static void Main(string[] args)
    {
        Console.WriteLine("Hello World! This is the ScriptureMemorizer Project.");

        Reference reference = new Reference("Proverbs", 3, 5, 6);
        Scripture scripture = new Scripture(reference, "Trust in the Lord with all thine heart; and lean not unto thine own understanding. In all thy ways acknowledge him, and he shall direct thy paths");

        string[] messages = {
            "Keep going, you're doing great",
            "ONe more step toward mastery!",
            "Your memory is strengthening!",
            "Amazing progress so far!",
            "You're almost there!"
        };
        int step = 0;

        while (!scripture.AllWordsHidden())
        {
            Console.Clear();
            Console.WriteLine(scripture.GetDisplayText());
            Console.WriteLine($"\n💡 {messages[step % messages.Length]}");
            Console.WriteLine("Press enter to continue or type 'quit' to finish: ");

            string input = Console.ReadLine();
            if (input.ToLower() == "quit")
                break;

            scripture.HideRandomWords(5);
            step++;
        }

        Console.Clear();
        Console.WriteLine(scripture.GetDisplayText());
        Console.WriteLine("\n🎉 You've mastered the scripture! Well done!");
    }
}