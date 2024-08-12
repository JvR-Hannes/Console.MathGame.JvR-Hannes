namespace MathGame.JvR_Hannes
{
    internal class Menu
    {
        GameEngine gameClass = new();
        internal void ShowMenu(string name, DateTime date)
        {
            Console.WriteLine("----------------------------------------");
            Console.WriteLine($"Hello {name}. It's {date.DayOfWeek}. This is your math's game. It's great that you're working on improving yourself\n");

            var isGameOn = true;

            do
            {
                Console.Clear();
                Console.WriteLine(
         @$"What game would you like to play today? Choose from the options below:

         V - View Previous Games
         A - Addition
         S - Subtraction
         M - Multiplication
         D - Division
         R - Random Game
         Q - Quit the Program");

                Console.WriteLine("----------------------------------------");

                var gameSelected = Console.ReadLine();

                switch (gameSelected.Trim().ToLower())
                {
                    case "v":
                        Helpers.GetPreviousGames();
                        break;
                    case "a":
                        gameClass.AdditionGame("Addition game");
                        break;
                    case "s":
                        gameClass.SubtractionGame("Subtraction game");
                        break;
                    case "m":
                        gameClass.MultiplicationGame("Multiplication game");
                        break;
                    case "d":
                        gameClass.DivisionGame("Division game");
                        break;
                    case "r":
                        gameClass.RandomGame("Random game");
                        break;
                    case "q":
                        Console.WriteLine("Goodbye!");
                        isGameOn = false;
                        break;
                    default:
                        Console.WriteLine("Invalid Input!");
                        Environment.Exit(1);
                        break;
                }
            } while (isGameOn);
        }
    }
}
