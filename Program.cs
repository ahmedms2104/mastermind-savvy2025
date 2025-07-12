
using System;
using System.Collections.Generic;
using System.Linq;

namespace Mastermind
{
    class Program
    {
        static void Main(string[] args)
        {
            string secretCode = null;
            int attempts = 10;

            // Handle command-line arguments
            for (int i = 0; i < args.Length; i++)
            {
                if (args[i] == "-c" && i + 1 < args.Length)
                    secretCode = args[i + 1];
                else if (args[i] == "-t" && i + 1 < args.Length && int.TryParse(args[i + 1], out int t))
                    attempts = t;
            }

            MastermindGame game = new MastermindGame(secretCode, attempts);
            game.Start();
        }
    }

    class MastermindGame
    {
        private string SecretCode;
        private int Attempts;
        private readonly string Pieces = "012345678";
        private bool GameWon = false;

        public MastermindGame(string code, int attempts)
        {
            Attempts = attempts;
            if (code != null && IsValidCode(code))
                SecretCode = code;
            else
                SecretCode = GenerateRandomCode();
        }

        public void Start()
        {
            Console.WriteLine("Can you break the code? Enter a valid guess.");

            for (int round = 0; round < Attempts; round++)
            {
                Console.WriteLine($"Round {round}");
                Console.Write("> ");
                string input = Console.ReadLine();

                if (input == null)
                    break;

                if (!IsValidCode(input))
                {
                    Console.WriteLine("Wrong input!");
                    round--; // Do not count invalid input
                    continue;
                }

                if (input == SecretCode)
                {
                    Console.WriteLine("Congratz! You did it!");
                    GameWon = true;
                    break;
                }

                int wellPlaced = CountWellPlaced(input);
                int misplaced = CountMisplaced(input);

                Console.WriteLine($"Well placed pieces: {wellPlaced}");
                Console.WriteLine($"Misplaced pieces: {misplaced}");
            }

            if (!GameWon)
                Console.WriteLine($"You lost! The code was: {SecretCode}");
        }

        private string GenerateRandomCode()
        {
            Random rnd = new Random();
            List<char> numbers = Pieces.ToList();
            string result = "";

            while (result.Length < 4)
            {
                int index = rnd.Next(numbers.Count);
                result += numbers[index];
                numbers.RemoveAt(index);
            }

            return result;
        }

        private bool IsValidCode(string code)
        {
            return code.Length == 4 &&
                   code.All(c => Pieces.Contains(c)) &&
                   code.Distinct().Count() == 4;
        }

        private int CountWellPlaced(string guess)
        {
            int count = 0;
            for (int i = 0; i < 4; i++)
            {
                if (guess[i] == SecretCode[i])
                    count++;
            }
            return count;
        }

        private int CountMisplaced(string guess)
        {
            int count = 0;
            for (int i = 0; i < 4; i++)
            {
                if (guess[i] != SecretCode[i] && SecretCode.Contains(guess[i]))
                    count++;
            }
            return count;
        }
    }
}
