using System;

class Program
{
    static void Main(string[] args)
    {
        //Stretch Challenge
        string playAgain = "yes";
        while (playAgain.ToLower() == "yes")
        {

            Console.WriteLine("Hello World! This is the Exercise3 Project.");
            Console.WriteLine();

            Random randomGenerator = new Random();
            int number = randomGenerator.Next(1, 100);

            int guess = -1;
            while (guess != number)
            {
                Console.Write("What is your guess? ");
                string guessInput = Console.ReadLine();
                guess = int.Parse(guessInput); //Convert input to integer

                if (guess < number)
                {
                    Console.WriteLine("Higher");
                }
                else if (guess > number)
                {
                    Console.WriteLine("Lower");
                }
                else
                {
                    Console.WriteLine("You guessed it");
                }
            }
            Console.Write("Do you want to play again? (yes/no): ");
            playAgain = Console.ReadLine();
            Console.WriteLine();
        }
        Console.WriteLine("Thanks for playing");
    }   
}

