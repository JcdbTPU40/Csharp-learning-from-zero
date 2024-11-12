using System;

namespace GuessTheNumberGame
{
    class Program
    {
        static void Main(string[] args)
        {
            bool playAgain = true;

            while (playAgain)
            {
                Random random = new Random();
                int targetNumber = 0;   // Initialize to a default value
                int maxGuesses = 0;     // Initialize to a default value
                int maxNumber = 0;      // Initialize to a defalut value
                int guessCount = 0;     // Initialize guess counter

                // Choose difficulty level

                bool validDifficulty = false;
                while (!validDifficulty)
                {
                    Console.WriteLine("Choose a difficulty level: Easy, Medium, Hard");
                    string difficulty = Console.ReadLine().ToLower();

                    if (difficulty == "easy")
                    {
                        targetNumber = random.Next(1, 51);
                        maxGuesses = 15;
                        maxNumber = 50;
                        validDifficulty = true;
                    }
                    else if (difficulty == "medium")
                    {
                        targetNumber = random.Next(1, 101);
                        maxGuesses = 10;
                        maxNumber = 100;
                        validDifficulty = true;
                    }
                    else if(difficulty == "hard")
                    {
                        targetNumber = random.Next(1,201);
                        maxGuesses = 5;
                        maxNumber = 200;
                        validDifficulty = true;
                    }
                    else
                    {
                        Console.WriteLine("Invalid choice. Please enter 'Easy', 'Medium', or 'Hard'.");
                    }
                }

                bool guessedCorrectly = false;

                while (!guessedCorrectly && guessCount < maxGuesses)
                {
                    Console.WriteLine($"Guess the number between 1 and {maxNumber}: ");
                    string userInput = Console.ReadLine();
                    int userGuess;

                    if(int.TryParse(userInput, out userGuess))
                    {

                        if (userGuess > targetNumber)
                        {
                            Console.WriteLine("Too High!");
                        }
                        else if (userGuess < targetNumber)
                        {
                            Console.WriteLine("Too Low!");
                        }
                        else
                        {
                            Console.WriteLine($"Congratulations! You guessed the number in {guessCount} attempts.");
                            guessedCorrectly = true;
                        }
                    }
                    else
                    {
                        Console.WriteLine("Please enter a valid number.");
                    }

                    guessCount++;

                    if(guessCount == maxGuesses && !guessedCorrectly)
                    {
                        Console.WriteLine("Sorry! You've reached the maximum number of guesses.");
                        Console.WriteLine($"The correct number was: {targetNumber}");
                    }

                }

                Console.WriteLine("Would you like to play again? (yes/no)");
                string response = Console.ReadLine().ToLower();

                playAgain = response == "yes";
            }
        }
    }
}