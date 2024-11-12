using System;

namespace GuessTheNumberGame
{
    class Program
    {
        static void Main(string[] args)
        {
            Random random = new Random();
            int targetNumber = random.Next(1, 101); // Generate a number between 1 and 100

            bool guessedCorrectly = false;
            while (!guessedCorrectly)
            {
                Console.WriteLine("Guess the number between 1 and 100: ");
                string userInput = Console.ReadLine();
                int userGuess;

                if(int.TryParse(userInput, out userGuess))
                {

                if (userGuess > targetNumber)
                {
                    Console.Write("Too High!");
                }
                else if (userGuess < targetNumber)
                {
                    Console.WriteLine("Too Low!");
                }
                else
                {
                    Console.WriteLine("Congratulations! You guessed the number.");
                    guessedCorrectly = true;
                }
                }
                else
                {
                    Console.WriteLine("Please enter a valid number.");
                }
            }
        }
    }
}