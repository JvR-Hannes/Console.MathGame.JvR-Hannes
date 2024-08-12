using MathGame.JvR_Hannes;
using System.Diagnostics;

var menu = new Menu();

var date = DateTime.UtcNow;

var games = new List<string>();

string name = GetName();

menu.ShowMenu(name, date);

string GetName()
{
    Console.WriteLine("Please type your name");

    var name = Console.ReadLine();
    return name.ToUpper();
}
void GetPreviousGames()
{
    Console.Clear();
    Console.WriteLine("Games History");
    Console.WriteLine("----------------------------");
    foreach (var game in games)
    {
        Console.WriteLine(game);
    }
    Console.WriteLine("-----------------------------\n");
    Console.WriteLine("Press any key to go back to the main menu");
    Console.ReadLine();
}


void AddToHistory(int gameScore, string gameType)
{
    games.Add($"{DateTime.Now} - {gameType}: Score = {gameScore}pts");
}

int[] GetDivisionNumbers()
{
    var random = new Random();
    var firstNumber = random.Next(1, 99);
    var secondNumber = random.Next(1, 99);

    var result = new int[2];

    while (firstNumber % secondNumber != 0)
    {
       firstNumber = random.Next(1, 99);
       secondNumber = random.Next(1, 99);
    }

    result[0] = firstNumber;
    result[1] = secondNumber;

    return result;
}