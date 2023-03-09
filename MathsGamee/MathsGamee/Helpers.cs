using System.Runtime.InteropServices.JavaScript;
using System.Security.AccessControl;
using MathsGame.Models;

namespace MathsGame
{
    internal class Helpers
    {
        internal static List<GamesDetails> games = new List<GamesDetails>()
        {
            new GamesDetails { Date = DateTime.Now.AddDays(1), Type = GameType.Addition, Score = 5 },
            new GamesDetails{Date = DateTime.Now.AddDays(2), Type = GameType.Multiplication, Score = 2 },
        };
        internal static void PrintGames()
        {
            var gamesToPrint = games.Where(x => x.Date > new DateTime(2022, 00, 09)).OrderByDescending(x => x.Score);

            Console.Clear();
            Console.WriteLine("Games History");
            Console.WriteLine(".....................................");

            foreach (GamesDetails game in games)
            {
                Console.WriteLine($"{game.Date} - {game.Type}: {game.Score}pts");
            }
            Console.WriteLine(".....................................");
            Console.WriteLine("Press any key to return to Main Menu");
            Console.ReadLine();

        }

        internal static int[] GetDivisionNumbers()
        {
            Random random = new Random();
            int firstNumber = random.Next(0, 99);
            int secondNumber = random.Next(0, 99);

            int[] result = new int[2];

            while (firstNumber % secondNumber != 0)
            {
                firstNumber = random.Next(1, 99);
                secondNumber = random.Next(1, 99);
            }

            result[0] = firstNumber;
            result[1] = secondNumber;
            return result;
        }

        internal static void AddToHistory(int gameScore, GameType gameType)
        {
            games.Add(new GamesDetails
            {
                Date = DateTime.Now,
                Score = gameScore,
                Type = gameType

            });
        }

        internal static string? ValidateResult(string result)
        {
            while (string.IsNullOrEmpty(result) || !Int32.TryParse(result, out _))
            {
                Console.WriteLine("Your answer needs to be an integer.Try again.");
                result = Console.ReadLine();
            }
            return result;
        }

        internal static string GetName()
        {   
            Console.WriteLine("...........................................");
            Console.WriteLine("Please enter your name");
            Console.WriteLine("...........................................");
            string name = Console.ReadLine();
            
            while (string.IsNullOrEmpty(name))
            {
                Console.WriteLine("Name can't be empty");
                name = Console.ReadLine();
                
            }
            return name;
        }

    }
}

