namespace MathsGame
{
    internal class Menu
    {
        private GameEngine gameEngine = new GameEngine();
        internal void ShowMenu(string name)
        {
            Console.Clear();
            Console.WriteLine("...........................................");
            Console.WriteLine($"Hello {name.ToUpper()}. Time to play MathsUp!");
            Console.WriteLine("Press any key to show menu");
            Console.WriteLine("...........................................");
            Console.ReadLine();

            bool isGameOn = true;
            do
            {
                Console.Clear();
                Console.WriteLine("..............................................................................");
                Console.WriteLine(@$"Which game would you like to play? Please pick one of the following options:
V - View Previous Games
A - Addition 
S - Subtraction
M - Multiplication
D - Division");

                Console.WriteLine("..............................................................................");

                string option = Console.ReadLine();


                //Choosing Option Type

                switch (option.Trim().ToLower())
                {
                    case "v":
                        Helpers.PrintGames();
                        break;
                    case "a":
                        gameEngine.AdditionGame("Addition Game");
                        break;
                    case "s":
                        gameEngine.SubtractionGame("Subtraction Game");
                        break;
                    case "m":
                        gameEngine.MultiplicationGame("Multiplication Game");
                        break;
                    case "d":
                        gameEngine.DivisionGame("Division Game");
                        break;
                    case "q":
                        Console.WriteLine("Goodbye");
                        isGameOn = false;
                        break;
                    default:
                        Console.WriteLine("Invalid Input");
                        break;
                }

                Console.ReadLine();
            } while (isGameOn);

        }

    }
}

