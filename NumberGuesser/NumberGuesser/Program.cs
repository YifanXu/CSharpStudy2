//-----------------------------------------------------------------------
// <copyright file="Program.cs" company="Yifan Xu">
//     No copyright lol
// </copyright>
//-----------------------------------------------------------------------
namespace NumberGuesser
{
    using System;
    using System.Collections.Generic;
    using System.Linq;
    using System.Text;

    /// <summary>
    /// Main Program
    /// </summary>
    public class Program
    {
        /// <summary>
        /// Global RNG
        /// </summary>
        private static Random r = new System.Random();

        /// <summary>
        /// Application Entry
        /// </summary>
        /// <param name="args">Application Argument</param>
        public static void Main(string[] args)
        {
            int numberOfPlayers = 2;
            string input;
            do
            {
                int round = 0;
                int currentPlayer = 0;
                int range;

                Console.ForegroundColor = ConsoleColor.Cyan;
                Console.WriteLine("Enter Maximum value for the number");
                Console.ForegroundColor = ConsoleColor.White;
                input = Console.ReadLine();
                while (!int.TryParse(input, out range) || range < 1)
                {
                    input = input.Trim();
                    Console.ForegroundColor = ConsoleColor.Red;
                    Console.WriteLine("Input is not a number or number is less than 1");
                    Console.ForegroundColor = ConsoleColor.White;
                    input = Console.ReadLine();
                }

                int target = r.Next(1, range);
                Console.ForegroundColor = ConsoleColor.Green;
                Console.WriteLine("The target number will be between 1 and {0}", range);

                while (true)
                {
                    Console.ForegroundColor = ConsoleColor.Cyan;
                    Console.WriteLine("Round {0}", (round / numberOfPlayers) + 1);
                    Console.WriteLine("Player {0}, enter your guess.", currentPlayer + 1);
                    Console.ForegroundColor = ConsoleColor.White;
                    input = Console.ReadLine();
                    int guess;
                    while (!int.TryParse(input, out guess))
                    {
                        input = input.Trim();
                        Console.ForegroundColor = ConsoleColor.Red;
                        Console.WriteLine("Input is not a number");
                        Console.ForegroundColor = ConsoleColor.White;
                        input = Console.ReadLine();
                    }

                    if (guess == target)
                    {
                        Console.ForegroundColor = ConsoleColor.Green;
                        Console.WriteLine("Player {0} wins! It took you {1} turns", currentPlayer + 1, (round / numberOfPlayers) + 1);
                        break;
                    }

                    Console.ForegroundColor = ConsoleColor.Magenta;
                    if (guess > target)
                    {
                        Console.WriteLine("Number is too big");
                    }
                    else
                    {
                        Console.WriteLine("Numer is too small");
                    }

                    round++;
                    currentPlayer++;
                    currentPlayer = currentPlayer % numberOfPlayers;
                }

                Console.ForegroundColor = ConsoleColor.Cyan;
                Console.WriteLine("Play Again? (y/n)");
                Console.ForegroundColor = ConsoleColor.White;
                input = Console.ReadLine();
                while (input != "y" && input != "n")
                {
                    Console.ForegroundColor = ConsoleColor.Red;
                    Console.WriteLine("Enter \"y\" or \"n\"");
                    Console.ForegroundColor = ConsoleColor.White;
                    input = Console.ReadLine();
                }
            }
            while (input == "y");

            Console.ForegroundColor = ConsoleColor.DarkRed;
            Console.WriteLine("Well, Too bad.");
            Console.ReadLine();
        }

        /// <summary>
        /// Check if a guess on a number is right
        /// </summary>
        /// <param name="generator">Delegate that generate the answer</param>
        /// <param name="input">Delegate that generate the input</param>
        /// <returns>Whether the guess was correct or not</returns>
        public static bool GuessNumber(int generator, int input)
        {
            return generator == input;
        }

        /// <summary>
        /// Guess a number that keeps querying for new guesses until the guess is correct
        /// </summary>
        /// <param name="generator">Delegate that generate the answer</param>
        /// <param name="input">Delegate that generate the input</param>
        public static int GuessNumberAdvanced(int generator, Func<int> input)
        {
            if(input == null)
            {
                throw new ArgumentNullException(nameof(input));
            }

            int count = 0;
            int guess;
            do
            {
                guess = input();
                count++;
            }
            while (guess != generator);

            return count;
        }
    }
}
