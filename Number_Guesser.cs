using System;

namespace NumberGuessingGame
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("=== Number Guessing Game ===");
            Console.WriteLine("Try to guess the secret number!");
            Console.WriteLine();

            bool playAgain = true;

            while (playAgain)
            {
                PlayGame();

                Console.WriteLine();
                Console.Write("Would you like to play again? (y/n): ");
                string response = Console.ReadLine().ToLower();

                playAgain = response == "y";
                Console.WriteLine();
            }

            Console.WriteLine("Thanks for playing!");
            Console.ReadKey();
        }

        static void PlayGame()
        {
            int min = 1;
            int max = SelectDifficulty();

            Random random = new Random();
            int secretNumber = random.Next(min, max + 1);

            int guess = 0;
            int attempts = 0;

            Console.WriteLine($"\nGuess a number between {min} and {max}");

            while (guess != secretNumber)
            {
                Console.Write("Enter your guess: ");

                if (!int.TryParse(Console.ReadLine(), out guess))
                {
                    Console.WriteLine("Invalid input. Please enter a valid number.");
                    continue;
                }

                attempts++;

                if (guess > secretNumber)
                {
                    Console.WriteLine("Too high! Try again.");
                }
                else if (guess < secretNumber)
                {
                    Console.WriteLine("Too low! Try again.");
                }
                else
                {
                    Console.WriteLine($"\nCorrect! You guessed it in {attempts} attempts.");
                }
            }
        }

        static int SelectDifficulty()
        {
            Console.WriteLine("Select difficulty:");
            Console.WriteLine("1 - Easy (1 to 50)");
            Console.WriteLine("2 - Medium (1 to 100)");
            Console.WriteLine("3 - Hard (1 to 500)");

            int choice;

            while (!int.TryParse(Console.ReadLine(), out choice) || choice < 1 || choice > 3)
            {
                Console.WriteLine("Invalid choice. Please select 1, 2, or 3.");
            }

            switch (choice)
            {
                case 1:
                    return 50;
                case 2:
                    return 100;
                case 3:
                    return 500;
                default:
                    return 100;
            }
        }
    }
}
