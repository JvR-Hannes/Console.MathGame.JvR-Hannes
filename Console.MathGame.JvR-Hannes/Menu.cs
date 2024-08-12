namespace MathGame.JvR_Hannes
{
    internal class Menu
    {
        GameEngine gamesClass = new();
        internal void ShowMenu(string name, DateTime date)
        {
            Console.Clear();
            Console.WriteLine($"Hello {name}. It's {date.DayOfWeek}. This is your math's game. It's great that you're working on improving yourself\n");
            Console.ReadLine();
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

                while (string.IsNullOrEmpty(gameSelected))
                {
                    Console.WriteLine("Please choose a option from the menu");
                    gameSelected = Console.ReadLine();
                    continue;
                }
                

                switch (gameSelected.Trim().ToLower())
                {
                    case "v":
                        Helpers.GetPreviousGames();
                        break;
                    case "a":
                        gamesClass.AdditionGame("Addition game");
                        break;
                    case "s":
                        gamesClass.SubtractionGame("Subtraction game");
                        break;
                    case "m":
                        gamesClass.MultiplicationGame("Multiplication game");
                        break;
                    case "d":
                        gamesClass.DivisionGame("Division game");
                        break;
                    case "r":
                        gamesClass.RandomGame("Random game");
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
